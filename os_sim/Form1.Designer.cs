namespace os_sim
{
    partial class mainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainView));
            this.clock = new System.Windows.Forms.Label();
            this.quantum = new System.Windows.Forms.Label();
            this.new_queue = new System.Windows.Forms.Label();
            this.ready_queue = new System.Windows.Forms.Label();
            this.running_queue = new System.Windows.Forms.Label();
            this.finished_queue = new System.Windows.Forms.Label();
            this.new_list = new System.Windows.Forms.TextBox();
            this.ready_list = new System.Windows.Forms.TextBox();
            this.running_list = new System.Windows.Forms.TextBox();
            this.clock_display = new System.Windows.Forms.TextBox();
            this.quantum_display = new System.Windows.Forms.TextBox();
            this.finished_list = new System.Windows.Forms.TextBox();
            this.waiting_list = new System.Windows.Forms.TextBox();
            this.waiting_queue = new System.Windows.Forms.Label();
            this.io1_queue = new System.Windows.Forms.Label();
            this.io1_list = new System.Windows.Forms.TextBox();
            this.pcb_list = new System.Windows.Forms.TextBox();
            this.pcb_id = new System.Windows.Forms.Label();
            this.pcb_arrival = new System.Windows.Forms.Label();
            this.total_cpu = new System.Windows.Forms.Label();
            this.pcb_elapsed = new System.Windows.Forms.Label();
            this.time_in_system = new System.Windows.Forms.Label();
            this.total_io = new System.Windows.Forms.Label();
            this.io_used = new System.Windows.Forms.Label();
            this.idle_time = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cpu_update = new System.Windows.Forms.CheckBox();
            this.algorithm_list = new System.Windows.Forms.ComboBox();
            this.average_cpu = new System.Windows.Forms.TextBox();
            this.pause = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.setttings_chance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.delay_bar = new System.Windows.Forms.TrackBar();
            this.settings_waiting = new System.Windows.Forms.TextBox();
            this.settings_ready = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.message_display = new System.Windows.Forms.TextBox();
            this.cycle_display = new System.Windows.Forms.Label();
            this.run_cycle = new System.Windows.Forms.Label();
            this.io1_cycle = new System.Windows.Forms.Label();
            this.io1_display = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.finishing_cycle = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.cpu_used = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.settings_new = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.help_button = new System.Windows.Forms.Button();
            this.update_warning = new System.Windows.Forms.Label();
            this.settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delay_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Location = new System.Drawing.Point(29, 13);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(34, 13);
            this.clock.TabIndex = 0;
            this.clock.Text = "Clock";
            // 
            // quantum
            // 
            this.quantum.AutoSize = true;
            this.quantum.Location = new System.Drawing.Point(29, 59);
            this.quantum.Name = "quantum";
            this.quantum.Size = new System.Drawing.Size(50, 13);
            this.quantum.TabIndex = 1;
            this.quantum.Text = "Quantum";
            // 
            // new_queue
            // 
            this.new_queue.AutoSize = true;
            this.new_queue.BackColor = System.Drawing.SystemColors.Control;
            this.new_queue.Location = new System.Drawing.Point(31, 150);
            this.new_queue.Name = "new_queue";
            this.new_queue.Size = new System.Drawing.Size(29, 13);
            this.new_queue.TabIndex = 2;
            this.new_queue.Text = "Hold";
            // 
            // ready_queue
            // 
            this.ready_queue.AutoSize = true;
            this.ready_queue.BackColor = System.Drawing.SystemColors.Control;
            this.ready_queue.Location = new System.Drawing.Point(141, 150);
            this.ready_queue.Name = "ready_queue";
            this.ready_queue.Size = new System.Drawing.Size(38, 13);
            this.ready_queue.TabIndex = 3;
            this.ready_queue.Text = "Ready";
            // 
            // running_queue
            // 
            this.running_queue.AutoSize = true;
            this.running_queue.BackColor = System.Drawing.SystemColors.Control;
            this.running_queue.Location = new System.Drawing.Point(259, 154);
            this.running_queue.Name = "running_queue";
            this.running_queue.Size = new System.Drawing.Size(47, 13);
            this.running_queue.TabIndex = 4;
            this.running_queue.Text = "Running";
            // 
            // finished_queue
            // 
            this.finished_queue.AutoSize = true;
            this.finished_queue.BackColor = System.Drawing.SystemColors.Control;
            this.finished_queue.Location = new System.Drawing.Point(485, 154);
            this.finished_queue.Name = "finished_queue";
            this.finished_queue.Size = new System.Drawing.Size(46, 13);
            this.finished_queue.TabIndex = 5;
            this.finished_queue.Text = "Finished";
            // 
            // new_list
            // 
            this.new_list.BackColor = System.Drawing.SystemColors.ControlLight;
            this.new_list.Location = new System.Drawing.Point(32, 170);
            this.new_list.Multiline = true;
            this.new_list.Name = "new_list";
            this.new_list.ReadOnly = true;
            this.new_list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.new_list.Size = new System.Drawing.Size(106, 114);
            this.new_list.TabIndex = 6;
            // 
            // ready_list
            // 
            this.ready_list.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ready_list.Location = new System.Drawing.Point(144, 170);
            this.ready_list.Multiline = true;
            this.ready_list.Name = "ready_list";
            this.ready_list.ReadOnly = true;
            this.ready_list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ready_list.Size = new System.Drawing.Size(106, 114);
            this.ready_list.TabIndex = 7;
            // 
            // running_list
            // 
            this.running_list.BackColor = System.Drawing.SystemColors.ControlLight;
            this.running_list.Location = new System.Drawing.Point(262, 170);
            this.running_list.Multiline = true;
            this.running_list.Name = "running_list";
            this.running_list.ReadOnly = true;
            this.running_list.Size = new System.Drawing.Size(106, 20);
            this.running_list.TabIndex = 8;
            this.running_list.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clock_display
            // 
            this.clock_display.BackColor = System.Drawing.SystemColors.Control;
            this.clock_display.Location = new System.Drawing.Point(32, 29);
            this.clock_display.Multiline = true;
            this.clock_display.Name = "clock_display";
            this.clock_display.ReadOnly = true;
            this.clock_display.Size = new System.Drawing.Size(60, 20);
            this.clock_display.TabIndex = 9;
            // 
            // quantum_display
            // 
            this.quantum_display.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.quantum_display.Location = new System.Drawing.Point(32, 75);
            this.quantum_display.Multiline = true;
            this.quantum_display.Name = "quantum_display";
            this.quantum_display.Size = new System.Drawing.Size(60, 20);
            this.quantum_display.TabIndex = 10;
            // 
            // finished_list
            // 
            this.finished_list.BackColor = System.Drawing.SystemColors.ControlLight;
            this.finished_list.Location = new System.Drawing.Point(488, 170);
            this.finished_list.Multiline = true;
            this.finished_list.Name = "finished_list";
            this.finished_list.ReadOnly = true;
            this.finished_list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.finished_list.Size = new System.Drawing.Size(106, 114);
            this.finished_list.TabIndex = 11;
            // 
            // waiting_list
            // 
            this.waiting_list.BackColor = System.Drawing.SystemColors.ControlLight;
            this.waiting_list.Location = new System.Drawing.Point(376, 170);
            this.waiting_list.Multiline = true;
            this.waiting_list.Name = "waiting_list";
            this.waiting_list.ReadOnly = true;
            this.waiting_list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.waiting_list.Size = new System.Drawing.Size(106, 114);
            this.waiting_list.TabIndex = 12;
            this.waiting_list.TextChanged += new System.EventHandler(this.waiting_list_TextChanged);
            // 
            // waiting_queue
            // 
            this.waiting_queue.AutoSize = true;
            this.waiting_queue.BackColor = System.Drawing.SystemColors.Control;
            this.waiting_queue.Location = new System.Drawing.Point(373, 150);
            this.waiting_queue.Name = "waiting_queue";
            this.waiting_queue.Size = new System.Drawing.Size(43, 13);
            this.waiting_queue.TabIndex = 13;
            this.waiting_queue.Text = "Waiting";
            this.waiting_queue.Click += new System.EventHandler(this.waiting_queue_Click);
            // 
            // io1_queue
            // 
            this.io1_queue.AutoSize = true;
            this.io1_queue.BackColor = System.Drawing.SystemColors.Control;
            this.io1_queue.Location = new System.Drawing.Point(259, 248);
            this.io1_queue.Name = "io1_queue";
            this.io1_queue.Size = new System.Drawing.Size(37, 13);
            this.io1_queue.TabIndex = 14;
            this.io1_queue.Text = "Printer";
            // 
            // io1_list
            // 
            this.io1_list.BackColor = System.Drawing.SystemColors.ControlLight;
            this.io1_list.Location = new System.Drawing.Point(262, 264);
            this.io1_list.Multiline = true;
            this.io1_list.Name = "io1_list";
            this.io1_list.ReadOnly = true;
            this.io1_list.Size = new System.Drawing.Size(106, 20);
            this.io1_list.TabIndex = 15;
            // 
            // pcb_list
            // 
            this.pcb_list.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pcb_list.Location = new System.Drawing.Point(32, 327);
            this.pcb_list.Multiline = true;
            this.pcb_list.Name = "pcb_list";
            this.pcb_list.ReadOnly = true;
            this.pcb_list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pcb_list.Size = new System.Drawing.Size(562, 247);
            this.pcb_list.TabIndex = 16;
            // 
            // pcb_id
            // 
            this.pcb_id.AutoSize = true;
            this.pcb_id.BackColor = System.Drawing.SystemColors.Control;
            this.pcb_id.Location = new System.Drawing.Point(31, 311);
            this.pcb_id.Name = "pcb_id";
            this.pcb_id.Size = new System.Drawing.Size(18, 13);
            this.pcb_id.TabIndex = 17;
            this.pcb_id.Text = "ID";
            this.pcb_id.Click += new System.EventHandler(this.label1_Click);
            // 
            // pcb_arrival
            // 
            this.pcb_arrival.AutoSize = true;
            this.pcb_arrival.BackColor = System.Drawing.SystemColors.Control;
            this.pcb_arrival.Location = new System.Drawing.Point(75, 311);
            this.pcb_arrival.Name = "pcb_arrival";
            this.pcb_arrival.Size = new System.Drawing.Size(36, 13);
            this.pcb_arrival.TabIndex = 18;
            this.pcb_arrival.Text = "Arrival";
            // 
            // total_cpu
            // 
            this.total_cpu.AutoSize = true;
            this.total_cpu.BackColor = System.Drawing.SystemColors.Control;
            this.total_cpu.Location = new System.Drawing.Point(117, 298);
            this.total_cpu.Name = "total_cpu";
            this.total_cpu.Size = new System.Drawing.Size(31, 26);
            this.total_cpu.TabIndex = 19;
            this.total_cpu.Text = "Total\r\nCPU";
            // 
            // pcb_elapsed
            // 
            this.pcb_elapsed.AutoSize = true;
            this.pcb_elapsed.BackColor = System.Drawing.SystemColors.Control;
            this.pcb_elapsed.Location = new System.Drawing.Point(196, 311);
            this.pcb_elapsed.Name = "pcb_elapsed";
            this.pcb_elapsed.Size = new System.Drawing.Size(45, 13);
            this.pcb_elapsed.TabIndex = 20;
            this.pcb_elapsed.Text = "Elapsed";
            // 
            // time_in_system
            // 
            this.time_in_system.AutoSize = true;
            this.time_in_system.BackColor = System.Drawing.SystemColors.Control;
            this.time_in_system.Location = new System.Drawing.Point(408, 298);
            this.time_in_system.Name = "time_in_system";
            this.time_in_system.Size = new System.Drawing.Size(41, 26);
            this.time_in_system.TabIndex = 21;
            this.time_in_system.Text = "Time in\r\nSystem";
            // 
            // total_io
            // 
            this.total_io.AutoSize = true;
            this.total_io.BackColor = System.Drawing.SystemColors.Control;
            this.total_io.Location = new System.Drawing.Point(246, 311);
            this.total_io.Name = "total_io";
            this.total_io.Size = new System.Drawing.Size(50, 13);
            this.total_io.TabIndex = 22;
            this.total_io.Text = "Total I/O";
            // 
            // io_used
            // 
            this.io_used.AutoSize = true;
            this.io_used.BackColor = System.Drawing.SystemColors.Control;
            this.io_used.Location = new System.Drawing.Point(302, 311);
            this.io_used.Name = "io_used";
            this.io_used.Size = new System.Drawing.Size(51, 13);
            this.io_used.TabIndex = 23;
            this.io_used.Text = "I/O Used";
            // 
            // idle_time
            // 
            this.idle_time.AutoSize = true;
            this.idle_time.BackColor = System.Drawing.SystemColors.Control;
            this.idle_time.Location = new System.Drawing.Point(455, 311);
            this.idle_time.Name = "idle_time";
            this.idle_time.Size = new System.Drawing.Size(50, 13);
            this.idle_time.TabIndex = 24;
            this.idle_time.Text = "Idle Time";
            // 
            // settings
            // 
            this.settings.Controls.Add(this.label10);
            this.settings.Controls.Add(this.cpu_update);
            this.settings.Controls.Add(this.algorithm_list);
            this.settings.Controls.Add(this.average_cpu);
            this.settings.Controls.Add(this.pause);
            this.settings.Controls.Add(this.play);
            this.settings.Controls.Add(this.stop);
            this.settings.Controls.Add(this.setttings_chance);
            this.settings.Controls.Add(this.label7);
            this.settings.Controls.Add(this.label6);
            this.settings.Controls.Add(this.label5);
            this.settings.Controls.Add(this.label4);
            this.settings.Controls.Add(this.delay_bar);
            this.settings.Location = new System.Drawing.Point(102, 12);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(382, 89);
            this.settings.TabIndex = 25;
            this.settings.TabStop = false;
            this.settings.Text = "Settings";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(101, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Average CPU";
            // 
            // cpu_update
            // 
            this.cpu_update.AutoSize = true;
            this.cpu_update.Cursor = System.Windows.Forms.Cursors.Default;
            this.cpu_update.Location = new System.Drawing.Point(12, 50);
            this.cpu_update.Name = "cpu_update";
            this.cpu_update.Size = new System.Drawing.Size(86, 17);
            this.cpu_update.TabIndex = 39;
            this.cpu_update.Text = "CPU Update";
            this.cpu_update.UseVisualStyleBackColor = true;
            this.cpu_update.CheckedChanged += new System.EventHandler(this.cpu_update_CheckedChanged);
            // 
            // algorithm_list
            // 
            this.algorithm_list.FormattingEnabled = true;
            this.algorithm_list.Items.AddRange(new object[] {
            "Round Robin",
            "FCFS"});
            this.algorithm_list.Location = new System.Drawing.Point(178, 16);
            this.algorithm_list.Name = "algorithm_list";
            this.algorithm_list.Size = new System.Drawing.Size(93, 21);
            this.algorithm_list.TabIndex = 35;
            this.algorithm_list.SelectedIndexChanged += new System.EventHandler(this.algorithm_list_SelectedIndexChanged);
            // 
            // average_cpu
            // 
            this.average_cpu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.average_cpu.Location = new System.Drawing.Point(178, 62);
            this.average_cpu.Multiline = true;
            this.average_cpu.Name = "average_cpu";
            this.average_cpu.Size = new System.Drawing.Size(36, 20);
            this.average_cpu.TabIndex = 37;
            this.average_cpu.TextChanged += new System.EventHandler(this.average_cpu_TextChanged);
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pause.BackgroundImage = global::os_sim.Properties.Resources.storm_pause;
            this.pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pause.Location = new System.Drawing.Point(72, 19);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(25, 25);
            this.pause.TabIndex = 36;
            this.pause.UseVisualStyleBackColor = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.play.BackgroundImage = global::os_sim.Properties.Resources.storm_play;
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.play.Location = new System.Drawing.Point(42, 19);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(25, 25);
            this.play.TabIndex = 35;
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.stop.BackgroundImage = global::os_sim.Properties.Resources.storm_stop;
            this.stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stop.ForeColor = System.Drawing.SystemColors.Control;
            this.stop.Location = new System.Drawing.Point(12, 19);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(25, 25);
            this.stop.TabIndex = 34;
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // setttings_chance
            // 
            this.setttings_chance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.setttings_chance.Location = new System.Drawing.Point(178, 40);
            this.setttings_chance.Multiline = true;
            this.setttings_chance.Name = "setttings_chance";
            this.setttings_chance.Size = new System.Drawing.Size(36, 20);
            this.setttings_chance.TabIndex = 32;
            this.setttings_chance.TextChanged += new System.EventHandler(this.setttings_chance_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Chance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Algorithm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Delay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Slow   Normal   Fast";
            // 
            // delay_bar
            // 
            this.delay_bar.BackColor = System.Drawing.SystemColors.Control;
            this.delay_bar.LargeChange = 1;
            this.delay_bar.Location = new System.Drawing.Point(272, 25);
            this.delay_bar.Maximum = 2;
            this.delay_bar.Name = "delay_bar";
            this.delay_bar.Size = new System.Drawing.Size(104, 42);
            this.delay_bar.TabIndex = 0;
            this.delay_bar.Scroll += new System.EventHandler(this.delay_bar_Scroll);
            // 
            // settings_waiting
            // 
            this.settings_waiting.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.settings_waiting.Location = new System.Drawing.Point(446, 147);
            this.settings_waiting.Multiline = true;
            this.settings_waiting.Name = "settings_waiting";
            this.settings_waiting.Size = new System.Drawing.Size(36, 20);
            this.settings_waiting.TabIndex = 26;
            // 
            // settings_ready
            // 
            this.settings_ready.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.settings_ready.Location = new System.Drawing.Point(214, 147);
            this.settings_ready.Multiline = true;
            this.settings_ready.Name = "settings_ready";
            this.settings_ready.Size = new System.Drawing.Size(36, 20);
            this.settings_ready.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(12, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 78);
            this.label8.TabIndex = 32;
            this.label8.Text = "S\r\nT\r\nA\r\nT\r\nE\r\nS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(12, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 39);
            this.label9.TabIndex = 33;
            this.label9.Text = "P\r\nC\r\nB";
            // 
            // message_display
            // 
            this.message_display.BackColor = System.Drawing.SystemColors.Control;
            this.message_display.Location = new System.Drawing.Point(57, 107);
            this.message_display.Multiline = true;
            this.message_display.Name = "message_display";
            this.message_display.ReadOnly = true;
            this.message_display.Size = new System.Drawing.Size(537, 20);
            this.message_display.TabIndex = 34;
            // 
            // cycle_display
            // 
            this.cycle_display.AutoSize = true;
            this.cycle_display.Location = new System.Drawing.Point(317, 154);
            this.cycle_display.Name = "cycle_display";
            this.cycle_display.Size = new System.Drawing.Size(36, 13);
            this.cycle_display.TabIndex = 36;
            this.cycle_display.Text = "Cycle:";
            // 
            // run_cycle
            // 
            this.run_cycle.AutoSize = true;
            this.run_cycle.Location = new System.Drawing.Point(348, 154);
            this.run_cycle.Name = "run_cycle";
            this.run_cycle.Size = new System.Drawing.Size(13, 13);
            this.run_cycle.TabIndex = 37;
            this.run_cycle.Text = "0";
            // 
            // io1_cycle
            // 
            this.io1_cycle.AutoSize = true;
            this.io1_cycle.Location = new System.Drawing.Point(348, 248);
            this.io1_cycle.Name = "io1_cycle";
            this.io1_cycle.Size = new System.Drawing.Size(13, 13);
            this.io1_cycle.TabIndex = 39;
            this.io1_cycle.Text = "0";
            // 
            // io1_display
            // 
            this.io1_display.AutoSize = true;
            this.io1_display.Location = new System.Drawing.Point(317, 248);
            this.io1_display.Name = "io1_display";
            this.io1_display.Size = new System.Drawing.Size(36, 13);
            this.io1_display.TabIndex = 38;
            this.io1_display.Text = "Cycle:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(463, 577);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Storm OS by Luis Orozco. ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // finishing_cycle
            // 
            this.finishing_cycle.AutoSize = true;
            this.finishing_cycle.BackColor = System.Drawing.SystemColors.Control;
            this.finishing_cycle.Location = new System.Drawing.Point(357, 298);
            this.finishing_cycle.Name = "finishing_cycle";
            this.finishing_cycle.Size = new System.Drawing.Size(48, 26);
            this.finishing_cycle.TabIndex = 41;
            this.finishing_cycle.Text = "Finishing\r\nCycle";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.SystemColors.Control;
            this.status.Location = new System.Drawing.Point(511, 311);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(37, 13);
            this.status.TabIndex = 42;
            this.status.Text = "Status";
            // 
            // cpu_used
            // 
            this.cpu_used.AutoSize = true;
            this.cpu_used.BackColor = System.Drawing.SystemColors.Control;
            this.cpu_used.Location = new System.Drawing.Point(154, 298);
            this.cpu_used.Name = "cpu_used";
            this.cpu_used.Size = new System.Drawing.Size(32, 26);
            this.cpu_used.TabIndex = 43;
            this.cpu_used.Text = "CPU\r\nUsed";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::os_sim.Properties.Resources.storm_logo;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(494, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // settings_new
            // 
            this.settings_new.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.settings_new.Location = new System.Drawing.Point(102, 147);
            this.settings_new.Multiline = true;
            this.settings_new.Name = "settings_new";
            this.settings_new.Size = new System.Drawing.Size(36, 20);
            this.settings_new.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Size";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // help_button
            // 
            this.help_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.help_button.Cursor = System.Windows.Forms.Cursors.Help;
            this.help_button.Image = global::os_sim.Properties.Resources.storm_help;
            this.help_button.Location = new System.Drawing.Point(32, 107);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(19, 20);
            this.help_button.TabIndex = 45;
            this.help_button.UseVisualStyleBackColor = true;
            this.help_button.Click += new System.EventHandler(this.help_button_Click);
            // 
            // update_warning
            // 
            this.update_warning.AutoSize = true;
            this.update_warning.Location = new System.Drawing.Point(31, 577);
            this.update_warning.Name = "update_warning";
            this.update_warning.Size = new System.Drawing.Size(0, 13);
            this.update_warning.TabIndex = 46;
            // 
            // mainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 595);
            this.Controls.Add(this.update_warning);
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cpu_used);
            this.Controls.Add(this.status);
            this.Controls.Add(this.finishing_cycle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.io1_cycle);
            this.Controls.Add(this.io1_display);
            this.Controls.Add(this.run_cycle);
            this.Controls.Add(this.cycle_display);
            this.Controls.Add(this.message_display);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settings_waiting);
            this.Controls.Add(this.settings_ready);
            this.Controls.Add(this.settings_new);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.idle_time);
            this.Controls.Add(this.io_used);
            this.Controls.Add(this.total_io);
            this.Controls.Add(this.pcb_list);
            this.Controls.Add(this.time_in_system);
            this.Controls.Add(this.pcb_elapsed);
            this.Controls.Add(this.total_cpu);
            this.Controls.Add(this.pcb_arrival);
            this.Controls.Add(this.pcb_id);
            this.Controls.Add(this.io1_list);
            this.Controls.Add(this.io1_queue);
            this.Controls.Add(this.waiting_queue);
            this.Controls.Add(this.waiting_list);
            this.Controls.Add(this.finished_list);
            this.Controls.Add(this.quantum_display);
            this.Controls.Add(this.clock_display);
            this.Controls.Add(this.running_list);
            this.Controls.Add(this.ready_list);
            this.Controls.Add(this.new_list);
            this.Controls.Add(this.finished_queue);
            this.Controls.Add(this.running_queue);
            this.Controls.Add(this.ready_queue);
            this.Controls.Add(this.new_queue);
            this.Controls.Add(this.quantum);
            this.Controls.Add(this.clock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storm OS";
            this.Load += new System.EventHandler(this.mainView_Load);
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delay_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Label quantum;
        private System.Windows.Forms.Label new_queue;
        private System.Windows.Forms.Label ready_queue;
        private System.Windows.Forms.Label running_queue;
        private System.Windows.Forms.Label finished_queue;
        private System.Windows.Forms.TextBox new_list;
        private System.Windows.Forms.TextBox ready_list;
        private System.Windows.Forms.TextBox running_list;
        private System.Windows.Forms.TextBox clock_display;
        private System.Windows.Forms.TextBox quantum_display;
        private System.Windows.Forms.TextBox finished_list;
        private System.Windows.Forms.TextBox waiting_list;
        private System.Windows.Forms.Label waiting_queue;
        private System.Windows.Forms.Label io1_queue;
        private System.Windows.Forms.TextBox io1_list;
        private System.Windows.Forms.TextBox pcb_list;
        private System.Windows.Forms.Label pcb_id;
        private System.Windows.Forms.Label pcb_arrival;
        private System.Windows.Forms.Label total_cpu;
        private System.Windows.Forms.Label pcb_elapsed;
        private System.Windows.Forms.Label time_in_system;
        private System.Windows.Forms.Label total_io;
        private System.Windows.Forms.Label io_used;
        private System.Windows.Forms.Label idle_time;
        private System.Windows.Forms.GroupBox settings;
        private System.Windows.Forms.TextBox settings_waiting;
        private System.Windows.Forms.TextBox settings_ready;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar delay_bar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox setttings_chance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox average_cpu;
        private System.Windows.Forms.TextBox message_display;
        private System.Windows.Forms.ComboBox algorithm_list;
        private System.Windows.Forms.Label cycle_display;
        private System.Windows.Forms.Label run_cycle;
        private System.Windows.Forms.Label io1_cycle;
        private System.Windows.Forms.Label io1_display;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label finishing_cycle;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label cpu_used;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cpu_update;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox settings_new;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button help_button;
        private System.Windows.Forms.Label update_warning;
    }
}

