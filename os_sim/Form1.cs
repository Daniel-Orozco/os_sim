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

        private ToolTip quantum_tooltip;
        private ToolTip algorithm_tooltip;
        private ToolTip chance_tooltip;
        private ToolTip average_tooltip;
        private ToolTip delay_tooltip;
        private ToolTip new_tooltip;
        private ToolTip ready_tooltip;
        private ToolTip waiting_tooltip;
        private ToolTip stop_tooltip;
        private ToolTip play_tooltip;
        private ToolTip pause_tooltip;

        enum Message { Clean=0, ValidNum, OutOfRange}
        public mainView()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            sim_speed = 1000;
            timer.Interval = sim_speed;
  
            Startup();
        }
        public void Startup()
        {
            Utilities.ResetAllControls(this);

            sim_state = false;
            rand = new Random();

            initialDisplay();
            helpDisplay();

            last_processid = 0;
            clock_value = 0;
            average_cycles = 10;
            chance = 50;
            tquantum = 5;
            io1_use = 0;
            
            timer.Enabled = true;                           
            timer.Stop();                                  

            
            initializeStates();
        }

        public void updateParameters()
        {
            int[] updates = new int[6];
            updates[0] = Utilities.updateParameter(settings_new, new_size, 0, 100);
            updates[1] = Utilities.updateParameter(settings_ready, ready_size, 0, 100);
            updates[2] = Utilities.updateParameter(settings_waiting, waiting_size, 0, 100);
            updates[3] = Utilities.updateParameter(setttings_chance, chance, 0, 100);
            updates[4] = Utilities.updateParameter(quantum_display, tquantum, 0, 100);
            updates[5] = Utilities.updateParameter(average_cpu, average_cycles, 1, 100);

            for(int c = 0; c < updates.Length; c++)
                if (updates[c] == -1)
                    messageUpdate((int)Message.ValidNum);

            new_size = updates[0] == -1 ? new_size : updates[0];
            ready_size = updates[1] == -1 ? ready_size : updates[1];
            waiting_size = updates[2] == -1 ? waiting_size : updates[2];
            chance = updates[3] == -1 ? chance : updates[3];
            tquantum = updates[4] == -1 ? tquantum : updates[4];
            average_cycles = updates[5] == -1 ? average_cycles : updates[5];
        }
        void timer_Tick(object sender, EventArgs e)
        {
            clock_value += 1;
            clock_display.Text = ""+clock_value;

            updateParameters();

            if(Running.Count == 0)
            {
                if (Waiting.Count != 0 && UsingIO1.Count == 0)
                    updateUsingIO1();
                if (Ready.Count != 0)
                    updateRunning();
                if(New.Count != 0)
                    updateReady();
                generateProcess();
            }
            else
            {
                Process current = Running.Peek();
                if ((current.quantum == 0 && isRoundRobin)|| current.current_cpu == current.total_cpu)
                {
                    current.quantum = tquantum;
                    if (current.current_cpu == current.total_cpu)
                    {
                        if (current.current_io1 == current.total_io1)
                            updateFinished();
                        else
                            updateWaiting();
                    }
                    else
                    {
                        returnToReady();
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
                if (io1.current_io1 == io1.total_io1)
                    emptyIO1();
                else
                {
                    io1.current_io1++;
                    io1_use++;
                    io1_cycle.Text = "" + io1_use;
                }
            }
            
        }
        public void updateReady()
        {
            Process t_process = New.Dequeue();

            Ready.addProcess(t_process);
            ready_list.Text += t_process.getID() + "\r\n";

            var lines = new_list.Lines;
            var pline = lines[0];
            updatePCB(t_process, t_process.id - 1);

            var newLines = lines.Skip(1);
            new_list.Lines = newLines.ToArray();
        }
        public void updateRunning()
        {
            Process t_process = Ready.Dequeue();

            Running.addProcess(t_process);
            running_list.Text += t_process.getID() + "\r\n";

            updatePCB(t_process, t_process.id - 1);

            var lines = ready_list.Lines;
            var newLines = lines.Skip(1);
            ready_list.Lines = newLines.ToArray();
        }
        public void updateUsingIO1()
        {
            Process t_process = Waiting.Dequeue();
            t_process.io1_arrival = clock_value;

            UsingIO1.addProcess(t_process);
            io1_list.Text += t_process.getID() + "\r\n";
            updatePCB(t_process, t_process.id - 1);

            var lines = waiting_list.Lines;
            var newLines = lines.Skip(1);
            waiting_list.Lines = newLines.ToArray();
        }
        public void emptyIO1()
        {
            Process t_process = UsingIO1.Dequeue();

            Ready.addProcess(t_process);
            ready_list.Text += t_process.getID() + "\r\n";
            updatePCB(t_process, t_process.id - 1);

            io1_list.Text = "";
            io1_use = 0;
            io1_cycle.Text = "0";
        }
        public void updateFinished()
        {
            Process t_process = Running.Dequeue();

            t_process.finishing_cycle = clock_value;
            t_process.time_in_system = t_process.finishing_cycle - t_process.arrival_cycle;
            t_process.idle_time = t_process.time_in_system - t_process.total_io1 - t_process.total_cpu;

            Finished.addProcess(t_process);
            finished_list.Text += t_process.getID() + "\r\n";
            updatePCB(t_process, t_process.id - 1);

            running_list.Text = "";
        }
        public void updateWaiting()
        {
            Process t_process = Running.Dequeue();

            Waiting.addProcess(t_process);
            waiting_list.Text += t_process.getID() + "\r\n";
            updatePCB(t_process, t_process.id - 1);

            running_list.Text = "";
        }
        public void returnToReady()
        {
            Process t_process = Running.Dequeue();
            Ready.addProcess(t_process);
            ready_list.Text += t_process.getID() + "\r\n";
            updatePCB(t_process, t_process.id - 1);

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

            settings_new.ReadOnly = false;
            settings_ready.ReadOnly = false;
            settings_waiting.ReadOnly = false;
            setttings_chance.ReadOnly = false;
            quantum_display.ReadOnly = false;
            average_cpu.ReadOnly = false;

            settings_new.BackColor = SystemColors.ControlLightLight;
            settings_ready.BackColor = SystemColors.ControlLightLight;
            settings_waiting.BackColor = SystemColors.ControlLightLight;
            setttings_chance.BackColor = SystemColors.ControlLightLight;
            quantum_display.BackColor = SystemColors.ControlLightLight;
            average_cpu.BackColor = SystemColors.ControlLightLight;

            messageUpdate((int)Message.Clean);
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

                updatePCB(n_process,n_process.id-1);
                new_list.Text += n_process.getID() + "\r\n";
            }
        }
        public void updatePCB(Process n_process, int process_line)
        {
            string[] lines = pcb_list.Text.Split('\n');

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < lines.Length; i++)
            {
                if (i == process_line)
                {
                    builder.Append(n_process.getData(clock_value));
                }
                else
                {
                    builder.Append(lines[i]+"\r\n");
                }
            }
            pcb_list.Text = builder.ToString();

            
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
            settings_new.ReadOnly = true;
            settings_ready.ReadOnly = true;
            settings_waiting.ReadOnly = true;
            setttings_chance.ReadOnly = true;
            quantum_display.ReadOnly = true;
            average_cpu.ReadOnly = true;

            settings_new.BackColor = SystemColors.Control;
            settings_ready.BackColor = SystemColors.Control;
            settings_waiting.BackColor = SystemColors.Control;
            setttings_chance.BackColor = SystemColors.Control;
            quantum_display.BackColor = SystemColors.Control;
            average_cpu.BackColor = SystemColors.Control;
        }

        private void pause_Click(object sender, EventArgs e)
        {
            timer.Stop();
            settings_new.ReadOnly = false;
            settings_ready.ReadOnly = false;
            settings_waiting.ReadOnly = false;
            setttings_chance.ReadOnly = false;
            quantum_display.ReadOnly = false;
            average_cpu.ReadOnly = false;

            settings_new.BackColor = SystemColors.ControlLightLight;
            settings_ready.BackColor = SystemColors.ControlLightLight;
            settings_waiting.BackColor = SystemColors.ControlLightLight;
            setttings_chance.BackColor = SystemColors.ControlLightLight;
            quantum_display.BackColor = SystemColors.ControlLightLight;
            average_cpu.BackColor = SystemColors.ControlLightLight;
        }
        private void average_cpu_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void setttings_chance_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void settings_io1use_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void messageUpdate(int code)
        {
            switch(code)
            {
                case 0: message_display.Text = "For Help, hover the mouse above the control you want to know more about.";
                    message_display.ForeColor = System.Drawing.Color.Blue;
                break;
                case 1: message_display.Text = "Error: Please insert a valid positive integer.";
                    message_display.ForeColor = System.Drawing.Color.Red;
                break;
                case 2: message_display.Text = "Error: Number must be within range.";
                    message_display.ForeColor = System.Drawing.Color.OrangeRed;
                break;
                default: message_display.Text = "404 Error Definition not found.";
                    message_display.ForeColor = System.Drawing.Color.Orange;
                break;
            }
           
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
                case 0: sim_speed = 1800;
                    break;
                case 1: sim_speed = 900;
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
        public void helpDisplay()
        {
            quantum_tooltip = new ToolTip();

            quantum_tooltip.ToolTipIcon = ToolTipIcon.Info;
            quantum_tooltip.ToolTipTitle = "Quantum";
            quantum_tooltip.ShowAlways = true;
            quantum_tooltip.SetToolTip(quantum_display, "With Round Robin enabled, determines how many ticks can a process last in Running state.\r\nMust be an integer between 1 and 999.");
            quantum_tooltip.AutoPopDelay = 32000;

            algorithm_tooltip = new ToolTip();

            algorithm_tooltip.ToolTipIcon = ToolTipIcon.Info;
            algorithm_tooltip.ToolTipTitle = "Algorithm Select";
            algorithm_tooltip.ShowAlways = true;
            algorithm_tooltip.SetToolTip(algorithm_list, "Select the algorithm that the process manager will use.\r\nRound Robin: Processes are queued in chronological order, but have limited cycles before being queued for CPU use again.\r\nFirst Come First Serve: Processes are queued in chronological order and will use the CPU until they no longer need it.");
            algorithm_tooltip.AutoPopDelay = 32000;

            chance_tooltip = new ToolTip();

            chance_tooltip.ToolTipIcon = ToolTipIcon.Info;
            chance_tooltip.ToolTipTitle = "Generation Chance";
            chance_tooltip.ShowAlways = true;
            chance_tooltip.SetToolTip(setttings_chance, "Sets the probability in percentage of a process being created each tick if CPU is not being used.\r\nMust be an integer between 0 and 100.");
            chance_tooltip.AutoPopDelay = 32000;


            average_tooltip = new ToolTip();

            average_tooltip.ToolTipIcon = ToolTipIcon.Info;
            average_tooltip.ToolTipTitle = "Average CPU Use";
            average_tooltip.ShowAlways = true;
            average_tooltip.SetToolTip(average_cpu, "Sets the average amount of cycles processes require from the CPU, with a 25% deviation.\r\nMust be an integer between 1 and 999.");
            average_tooltip.AutoPopDelay = 32000;

            delay_tooltip = new ToolTip();

            delay_tooltip.ToolTipIcon = ToolTipIcon.Info;
            delay_tooltip.ToolTipTitle = "Tick Delay";
            delay_tooltip.ShowAlways = true;
            delay_tooltip.SetToolTip(delay_bar, "Controls the time that elapses between ticks.\r\nSlow: 2 seconds per tick.\r\nNormal: 1 second per tick.\r\nFast: 0.25 seconds per tick.");
            delay_tooltip.AutoPopDelay = 32000;

            new_tooltip = new ToolTip();

            new_tooltip.ToolTipIcon = ToolTipIcon.Info;
            new_tooltip.ToolTipTitle = "Hold State Size";
            new_tooltip.ShowAlways = true;
            new_tooltip.SetToolTip(settings_new, "Sets the maximum amount of processes the Hold State can hold.\r\nMust be an integer between 1 and 999.");
            new_tooltip.AutoPopDelay = 32000;

            ready_tooltip = new ToolTip();

            ready_tooltip.ToolTipIcon = ToolTipIcon.Info;
            ready_tooltip.ToolTipTitle = "Ready State Size";
            ready_tooltip.ShowAlways = true;
            ready_tooltip.SetToolTip(settings_ready, "Sets the maximum amount of processes the Ready State can hold.\r\nMust be an integer between 1 and 999.");
            ready_tooltip.AutoPopDelay = 32000;

            waiting_tooltip = new ToolTip();

            waiting_tooltip.ToolTipIcon = ToolTipIcon.Info;
            waiting_tooltip.ToolTipTitle = "Waiting State Size";
            waiting_tooltip.ShowAlways = true;
            waiting_tooltip.SetToolTip(settings_waiting, "Sets the maximum amount of processes the Waiting State can hold.\r\nMust be an integer between 1 and 999.");
            waiting_tooltip.AutoPopDelay = 32000;

            stop_tooltip = new ToolTip();

            stop_tooltip.ToolTipIcon = ToolTipIcon.Info;
            stop_tooltip.ToolTipTitle = "Stop Simulation";
            stop_tooltip.ShowAlways = true;
            stop_tooltip.SetToolTip(stop, "Ends the current simulation, refreshing all controls to their default values and clearing all data from the managers.");
            stop_tooltip.AutoPopDelay = 32000;

            play_tooltip = new ToolTip();

            play_tooltip.ToolTipIcon = ToolTipIcon.Info;
            play_tooltip.ToolTipTitle = "Play Simulation";
            play_tooltip.ShowAlways = true;
            play_tooltip.SetToolTip(play, "Starts or resumes the current simulation, activating the clock and managers.\r\nParameters cannot be changed while the simulation is in Play.");
            play_tooltip.AutoPopDelay = 32000;

            pause_tooltip = new ToolTip();

            pause_tooltip.ToolTipIcon = ToolTipIcon.Info;
            pause_tooltip.ToolTipTitle = "Pause Simulation";
            pause_tooltip.ShowAlways = true;
            pause_tooltip.SetToolTip(pause, "Pauses the current simulation, stopping the clock and managers but saving their current states.\r\nParameters may be changed while the simulation is in Pause.");
            pause_tooltip.AutoPopDelay = 32000;
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
    public static int updateParameter(TextBox t, int data, int min = 0, int max = 100)
    {
        if(isValidNumber(t,min,max))
            return Convert.ToInt32(t.Text);
        t.Text = ""+data;
        return -1;
    }
    public static bool isValidNumber(TextBox t, int min = 0, int max = 100)
    {
        int value = -1;
        string boxText = t.Text;
        return int.TryParse(boxText, out value) && (value >= min && value <= max);
    }
}