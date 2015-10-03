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
        private bool end_loop;
        private Random rand;

        private int last_processid;
        private int clock_value;
        private int average_cycles;
        private int sim_speed;
        private int chance;

        private int new_size;
        private int ready_size;
        private int waiting_size;

        private State New;
        private State Ready;
        private State Running;
        private State Waiting;
        private State Using_IO1;
        private State Finished;

        enum MessageCode { Clean=0, ValidNum}
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
            end_loop = false;
            rand = new Random();

            initialDisplay();
            last_processid = 0;
            clock_value = 0;
            average_cycles = 10;
            chance = 50;
            
            timer.Enabled = true;                           
            timer.Stop();                                  

            initializeStates();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            clock_value += 1;
            clock_display.Text = ""+clock_value;
            generateProcess();
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
            Using_IO1 = new State(1);
            Finished = new State();

        }
        public void initialDisplay()
        {
            settings_new.Text = "10";
            settings_ready.Text = "10";
            settings_waiting.Text = "10";
            setttings_chance.Text = "50";
            quantum_display.Text = "5";
            average_cpu.Text = ""+average_cycles;
            clock_display.Text = "0";
            delay_bar.Value = 1;
        }
        public void generateProcess()
        {
            Process n_process;
            if(rand.Next(0,100) <= chance)
            {
                n_process = new Process(last_processid + 1, clock_value, average_cycles, rand);
                last_processid++;
                New.addProcess(n_process);
                pcb_list.AppendText(n_process.getData() + "\r\n");
                new_list.Text += n_process.getId() + "\r\n";
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

        private void algorithm_list_SelectedIndexChanged(object sender, EventArgs e)
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
                messageUpdate((int)MessageCode.Clean);
                average_cycles = Convert.ToInt32(average_cpu.Text);
            }
            else
            {
                average_cpu.Text = "" + average_cycles;
                messageUpdate((int)MessageCode.ValidNum);
            }
        }
        private void setttings_chance_TextChanged(object sender, EventArgs e)
        {
            if (isValidNumber(setttings_chance))
            {
                messageUpdate((int)MessageCode.Clean);
                chance = Convert.ToInt32(setttings_chance.Text);
            }
            else
            {
                setttings_chance.Text = "" + chance;
                messageUpdate((int)MessageCode.ValidNum);
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