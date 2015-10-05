using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace os_sim
{
    public partial class mainView : Form
    {
        private Timer timer;

        private bool sim_state;
        private bool is_idle;
        private bool isRoundRobin;
        private Random rand;

        private int last_processid;
        private int clock_value;
        private int average_cycles;
        private int sim_speed;
        private int chance;
        private int tquantum;
        private int io1_use;

        private int new_size;
        private int ready_size;
        private int waiting_size;

        private State New;
        private State Ready;
        private State Running;
        private State Waiting;
        private State UsingIO1;
        private State Finished;

        private Queue<string> pcb_data;

        enum Message { Clean=0, ValidNum}
        public mainView()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            sim_speed = 2000;
            timer.Interval = sim_speed;
  
            Startup();
        }
        public void Startup()
        {
            Utilities.ResetAllControls(this);

            sim_state = false;
            is_idle = true;
            rand = new Random();

            initialDisplay();
            last_processid = 0;
            clock_value = 0;
            average_cycles = 10;
            chance = 50;
            tquantum = 5;
            io1_use = 0;
            
            timer.Enabled = true;                           
            timer.Stop();                                  

            
            initializeStates();
            pcb_data = new Queue<string>();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            clock_value += 1;
            clock_display.Text = ""+clock_value;
            if(Running.Count == 0)
            {
                if (Waiting.Count != 0)
                    updateUsingIO1();
                if (UsingIO1.Count != 0)
                {
                    Process io1 = UsingIO1.Peek();
                    if (io1.current_io1 == io1.total_io1)
                        emptyIO1();
                }
                if (Ready.Count != 0)
                    updateRunning();
                if(New.Count != 0)
                    updateReady();
                generateProcess();
            }
            else
            {
                Process current = Running.Peek();
                if (current.quantum == 0 || current.current_cpu == current.total_cpu)
                {
                    current.quantum = tquantum;
                    if (current.current_io1 == current.total_io1)
                    {
                        if (current.current_cpu == current.total_cpu)
                            updateFinished();
                        else
                            returnToReady();
                    }
                    else
                    {
                        updateWaiting();
                    }
                    run_cycle.Text = "0";
                }
                else
                {
                    current.quantum--;
                    current.current_cpu++;
                    run_cycle.Text = ""+(tquantum-current.quantum);
                }
            }
            if (UsingIO1.Count != 0)
            {
                Process io1 = UsingIO1.Peek();
                io1.current_io1++;
                io1_use++;
                io1_cycle.Text = ""+io1_use;
            }
        }
        public void updatePCB(string[] lines, string pline)
        {
            string nline = pline;
            int pid = -1;
            if (pline[1] == 0)
                pid += pline[2];
            else
                pid += stringToInt(pline.Substring(1, 2));
            lines = pcb_list.Lines;
            lines[pid] = nline;
            pcb_list.Lines = lines;
        }
        public void updateReady()
        {
            Process t_process = New.Dequeue();

            Ready.addProcess(t_process);
            ready_list.Text += t_process.getID() + "\r\n";

            var lines = new_list.Lines;
            var pline = lines[0];
            updatePCB(lines, t_process.getData());

            var newLines = lines.Skip(1);
            new_list.Lines = newLines.ToArray();
        }
        public void updateRunning()
        {
            Process t_process = Ready.Dequeue();

            Running.addProcess(t_process);
            running_list.Text += t_process.getID() + "\r\n";

            var lines = ready_list.Lines;
            var newLines = lines.Skip(1);
            ready_list.Lines = newLines.ToArray();
        }
        public void updateUsingIO1()
        {
            Process t_process = Waiting.Dequeue();

            UsingIO1.addProcess(t_process);
            io1_list.Text += t_process.getID() + "\r\n";

            var lines = waiting_list.Lines;
            var newLines = lines.Skip(1);
            waiting_list.Lines = newLines.ToArray();
        }
        public void emptyIO1()
        {
            Process t_process = UsingIO1.Dequeue();

            Ready.addProcess(t_process);
            ready_list.Text += t_process.getID() + "\r\n";

            io1_list.Text = "";
            io1_use = 0;
            io1_cycle.Text = "0";
        }
        public void updateFinished()
        {
            Process t_process = Running.Dequeue();

            Finished.addProcess(t_process);
            finished_list.Text += t_process.getID() + "\r\n";

            running_list.Text = "";
        }
        public void updateWaiting()
        {
            Process t_process = Running.Dequeue();

            Waiting.addProcess(t_process);
            waiting_list.Text += t_process.getID() + "\r\n";

            running_list.Text = "";
        }
        public void returnToReady()
        {
            Process t_process = Running.Dequeue();
            Ready.addProcess(t_process);
            ready_list.Text += t_process.getID() + "\r\n";

            running_list.Text = "";
        }
        public void initializeStates()
        {
            clock_value = 0;
            new_size = 10;
            ready_size = 10;
            waiting_size = 10;

            New = new State(new_size);
            Ready = new State(ready_size);
            Running = new State(1);
            Waiting = new State(waiting_size);
            UsingIO1 = new State(1);
            Finished = new State();

        }
        public void initialDisplay()
        {
            settings_new.Text = "10";
            settings_ready.Text = "10";
            settings_waiting.Text = "10";
            setttings_chance.Text = "50";
            quantum_display.Text = "5";
            average_cpu.Text = "10";
            clock_display.Text = "0";
            run_cycle.Text = "0";
            io1_cycle.Text = "0";
            delay_bar.Value = 1;
            algorithm_list.SelectedIndex = 0;
        }
        public void generateProcess()
        {
            Process n_process;
            if(rand.Next(0,100) <= chance)
            {
                n_process = new Process(last_processid + 1, clock_value, average_cycles, rand, tquantum);
                last_processid++;
                New.addProcess(n_process);

                pcb_data.Enqueue(n_process.getData());
                updatePCB();
                new_list.Text += n_process.getID() + "\r\n";
            }
        }
        public void updatePCB()
        {
            Queue<string> backup = new Queue<string>();
            string dq;
            pcb_list.Text = "";
            while(pcb_data.Count != 0)
            {
                dq = pcb_data.Dequeue();
                pcb_list.AppendText(dq + "\r\n");
                backup.Enqueue(dq);
            }
            while(backup.Count != 0)
                pcb_data.Enqueue(backup.Dequeue());
            
        }
        private void algorithm_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (algorithm_list.SelectedIndex == 0)
            {
                isRoundRobin = true;
                quantum_display.BackColor = SystemColors.ControlLightLight;
                quantum_display.ReadOnly = false;
            }
            else
            {
                isRoundRobin = false;
                quantum_display.BackColor = SystemColors.Control;
                quantum_display.ReadOnly = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void waiting_list_TextChanged(object sender, EventArgs e)
        {

        }

        private void waiting_queue_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mainView_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void stop_Click(object sender, EventArgs e)
        {
            Startup();
        }

        private void play_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void average_cpu_TextChanged(object sender, EventArgs e)
        {
            if(isValidNumber(average_cpu))
            {
                messageUpdate((int)Message.Clean);
                average_cycles = Convert.ToInt32(average_cpu.Text);
            }
            else
            {
                average_cpu.Text = "" + average_cycles;
                messageUpdate((int)Message.ValidNum);
            }
        }
        private void setttings_chance_TextChanged(object sender, EventArgs e)
        {
            if (isValidNumber(setttings_chance))
            {
                messageUpdate((int)Message.Clean);
                chance = Convert.ToInt32(setttings_chance.Text);
            }
            else
            {
                setttings_chance.Text = "" + chance;
                messageUpdate((int)Message.ValidNum);
            }
        }
        private void messageUpdate(int code)
        {
            switch(code)
            {
                case 0: message_display.Text = "";
                    message_display.ForeColor = System.Drawing.Color.Black;
                break;
                case 1: message_display.Text = "Error: Please insert a valid positive integer.";
                    message_display.ForeColor = System.Drawing.Color.Black;
                break;
                default: message_display.Text = "404 Error Definition not found.";
                    message_display.ForeColor = System.Drawing.Color.Orange;
                break;
            }
           
        }
        private static bool isValidNumber(TextBox t)
        {
            int value = -1;
            string boxText = t.Text;
            return int.TryParse(boxText, out value);
        }
        private static int stringToInt(string s)
        {
            int value = -1;
            return (int.TryParse(s, out value) ? value : -1);
        }
        private void delay_bar_Scroll(object sender, EventArgs e)
        {
            switch(delay_bar.Value)
            {
                case 0: sim_speed = 2000;
                    break;
                case 1: sim_speed = 1000;
                    break;
                case 2: sim_speed = 250;
                    break;
                default: sim_speed = 1;
                    break;
            }
            timer.Interval = sim_speed;
            if(sim_state)
                timer.Enabled = true;
        }


    }
}
public class Utilities
{
    public static void ResetAllControls(Control form)
    {
        foreach (Control control in form.Controls)
        {
            if (control is TextBox)
            {
                TextBox textBox = (TextBox)control;
                textBox.Text = null;
            }

            if (control is ComboBox)
            {
                ComboBox comboBox = (ComboBox)control;
                if (comboBox.Items.Count > 0)
                    comboBox.SelectedIndex = 0;
            }

            if (control is CheckBox)
            {
                CheckBox checkBox = (CheckBox)control;
                checkBox.Checked = false;
            }

            if (control is ListBox)
            {
                ListBox listBox = (ListBox)control;
                listBox.ClearSelected();
            }
        }
    }
}