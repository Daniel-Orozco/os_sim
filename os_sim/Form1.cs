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
        private bool sim_state;
        private bool is_idle;
        private bool end_loop;
        private Random rand;

        private int last_processid;
        private int clock_value;
        private int average_cycles;
        private int sim_speed;

        private int new_size;
        private int ready_size;
        private int waiting_size;

        private State New;
        private State Ready;
        private State Running;
        private State Waiting;
        private State Using_IO1;
        private State Finished;

        public mainView()
        {
            InitializeComponent();

            sim_state = false;
            is_idle = true;
            end_loop = false;
            rand = new Random();

            last_processid = 0;
            clock_value = 0;
            average_cycles = 10;
            sim_speed = 2000;

            initializeStates();
            initialDisplay();
            loop();
        }
        public void loop()
        {
            while (!sim_state)
            {
                Update();
                if (is_idle)
                    generateProcess();
                wait();
            }
        }
        public async void wait()
        {
            await Task.Delay(sim_speed);
        }
        public void initializeStates()
        {
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
            quantum_display.Text = "5";
            average_cpu.Text = ""+average_cycles;
            clock_display.Text = ""+clock_value;
        }
        public void generateProcess()
        {
            Process n_process = new Process(last_processid + 1, clock_value, average_cycles, rand);
            New.addProcess(n_process);
            settings_new.Text += "\n" + n_process.getData();
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
            sim_state = false;
            end_loop = true;
        }

        private void play_Click(object sender, EventArgs e)
        {
            sim_state = true;
        }

        private void pause_Click(object sender, EventArgs e)
        {
            sim_state = false;
        }

        private void average_cpu_TextChanged(object sender, EventArgs e)
        {
            if(isValidNumber(average_cpu))
            {
                resetMessage();
                average_cycles = Convert.ToInt32(average_cpu.Text);
            }
            else
            {
                average_cpu.Text = "" + average_cycles;
                message_display.Text = "Error: Please insert a valid positive integer.";
                message_display.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void resetMessage()
        {
            message_display.Text = "";
            message_display.ForeColor = System.Drawing.Color.Black;
        }
        private static bool isValidNumber(TextBox t)
        {
            int value = -1;
            string boxText = t.Text;
            return int.TryParse(boxText, out value);
        }
    }
}
