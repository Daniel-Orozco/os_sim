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

            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick); 
            timer.Interval = (1000);
  
            Startup();
        }
        public void Startup()
        {
            Utilities.ResetAllControls(this);

            sim_state = false;
            is_idle = true;
            end_loop = false;
            rand = new Random();

            last_processid = 0;
            clock_value = 0;
            average_cycles = 10;
            sim_speed = 2000;                      // Timer will tick evert 10 seconds
            timer.Enabled = true;                           // Enable the timer
            timer.Start();                                  // Start the timer

            initializeStates();
            initialDisplay();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            clock_value += 1;
            clock_display.Text = ""+clock_value;
            generateProcess();
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
            setttings_chance.Text = "50";
            quantum_display.Text = "5";
            average_cpu.Text = ""+average_cycles;
            clock_display.Text = ""+clock_value;
        }
        public void generateProcess()
        {
            Process n_process = new Process(last_processid + 1, clock_value, average_cycles, rand);
            last_processid++;
            New.addProcess(n_process);
            pcb_list.AppendText(n_process.getData() + "\r\n");
            new_list.Text += n_process.getId() + "\r\n";

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
        //
        // Boolean flag used to determine when a character other than a number is entered.
        private bool nonNumberEntered = false;

        // Handle the KeyDown event to determine the type of character entered into the control.
        private void settings_chance_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // Initialize the flag to false.
            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        // This event occurs after the KeyDown event and can be used to prevent
        // characters from entering the control.
        private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
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