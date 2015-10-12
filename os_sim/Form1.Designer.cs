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
            this.pcb_totaltime = new System.Windows.Forms.Label();
            this.pcb_timeleft = new System.Windows.Forms.Label();
            this.pcb_cpu = new System.Windows.Forms.Label();
            this.pcb_io = new System.Windows.Forms.Label();
            this.pcb_ioleft = new System.Windows.Forms.Label();
            this.pcb_cpuleft = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cpu_update = new System.Windows.Forms.CheckBox();
            this.algorithm_list = new System.Windows.Forms.ComboBox();
            this.average_cpu = new System.Windows.Forms.TextBox();
            this.setttings_chance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.delay_bar = new System.Windows.Forms.TrackBar();
            this.settings_waiting = new System.Windows.Forms.TextBox();
            this.settings_ready = new System.Windows.Forms.TextBox();
            this.settings_new = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.finish_label = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pause = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delay_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Location = new System.Drawing.Point(33, 12);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(34, 13);
            this.clock.TabIndex = 0;
            this.clock.Text = "Clock";
            // 
            // quantum
            // 
            this.quantum.AutoSize = true;
            this.quantum.Location = new System.Drawing.Point(33, 58);
            this.quantum.Name = "quantum";
            this.quantum.Size = new System.Drawing.Size(50, 13);
            this.quantum.TabIndex = 1;
            this.quantum.Text = "Quantum";
            // 
            // new_queue
            // 
            this.new_queue.AutoSize = true;
            this.new_queue.BackColor = System.Drawing.SystemColors.Control;
            this.new_queue.Location = new System.Drawing.Point(31, 171);
            this.new_queue.Name = "new_queue";
            this.new_queue.Size = new System.Drawing.Size(29, 13);
            this.new_queue.TabIndex = 2;
            this.new_queue.Text = "Hold";
            // 
            // ready_queue
            // 
            this.ready_queue.AutoSize = true;
            this.ready_queue.BackColor = System.Drawing.SystemColors.Control;
            this.ready_queue.Location = new System.Drawing.Point(141, 171);
            this.ready_queue.Name = "ready_queue";
            this.ready_queue.Size = new System.Drawing.Size(38, 13);
            this.ready_queue.TabIndex = 3;
            this.ready_queue.Text = "Ready";
            // 
            // running_queue
            // 
            this.running_queue.AutoSize = true;
            this.running_queue.BackColor = System.Drawing.SystemColors.Control;
            this.running_queue.Location = new System.Drawing.Point(259, 175);
            this.running_queue.Name = "running_queue";
            this.running_queue.Size = new System.Drawing.Size(47, 13);
            this.running_queue.TabIndex = 4;
            this.running_queue.Text = "Running";
            // 
            // finished_queue
            // 
            this.finished_queue.AutoSize = true;
            this.finished_queue.BackColor = System.Drawing.SystemColors.Control;
            this.finished_queue.Location = new System.Drawing.Point(485, 175);
            this.finished_queue.Name = "finished_queue";
            this.finished_queue.Size = new System.Drawing.Size(46, 13);
            this.finished_queue.TabIndex = 5;
            this.finished_queue.Text = "Finished";
            // 
            // new_list
            // 
            this.new_list.BackColor = System.Drawing.SystemColors.ControlLight;
            this.new_list.Location = new System.Drawing.Point(32, 191);
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
            this.ready_list.Location = new System.Drawing.Point(144, 191);
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
            this.running_list.Location = new System.Drawing.Point(262, 191);
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
            this.clock_display.Location = new System.Drawing.Point(36, 28);
            this.clock_display.Multiline = true;
            this.clock_display.Name = "clock_display";
            this.clock_display.ReadOnly = true;
            this.clock_display.Size = new System.Drawing.Size(60, 20);
            this.clock_display.TabIndex = 9;
            // 
            // quantum_display
            // 
            this.quantum_display.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.quantum_display.Location = new System.Drawing.Point(36, 74);
            this.quantum_display.Multiline = true;
            this.quantum_display.Name = "quantum_display";
            this.quantum_display.Size = new System.Drawing.Size(60, 20);
            this.quantum_display.TabIndex = 10;
            // 
            // finished_list
            // 
            this.finished_list.BackColor = System.Drawing.SystemColors.ControlLight;
            this.finished_list.Location = new System.Drawing.Point(488, 191);
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
            this.waiting_list.Location = new System.Drawing.Point(376, 191);
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
            this.waiting_queue.Location = new System.Drawing.Point(373, 171);
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
            this.io1_queue.Location = new System.Drawing.Point(259, 269);
            this.io1_queue.Name = "io1_queue";
            this.io1_queue.Size = new System.Drawing.Size(37, 13);
            this.io1_queue.TabIndex = 14;
            this.io1_queue.Text = "Printer";
            // 
            // io1_list
            // 
            this.io1_list.BackColor = System.Drawing.SystemColors.ControlLight;
            this.io1_list.Location = new System.Drawing.Point(262, 285);
            this.io1_list.Multiline = true;
            this.io1_list.Name = "io1_list";
            this.io1_list.ReadOnly = true;
            this.io1_list.Size = new System.Drawing.Size(106, 20);
            this.io1_list.TabIndex = 15;
            // 
            // pcb_list
            // 
            this.pcb_list.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pcb_list.Location = new System.Drawing.Point(32, 348);
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
            this.pcb_id.Location = new System.Drawing.Point(31, 332);
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
            this.pcb_arrival.Location = new System.Drawing.Point(75, 332);
            this.pcb_arrival.Name = "pcb_arrival";
            this.pcb_arrival.Size = new System.Drawing.Size(36, 13);
            this.pcb_arrival.TabIndex = 18;
            this.pcb_arrival.Text = "Arrival";
            // 
            // pcb_totaltime
            // 
            this.pcb_totaltime.AutoSize = true;
            this.pcb_totaltime.BackColor = System.Drawing.SystemColors.Control;
            this.pcb_totaltime.Location = new System.Drawing.Point(117, 319);
            this.pcb_totaltime.Name = "pcb_totaltime";
            this.pcb_totaltime.Size = new System.Drawing.Size(31, 26);
            this.pcb_totaltime.TabIndex = 19;
            this.pcb_totaltime.Text = "Total\r\nCPU";
            // 
            // pcb_timeleft
            // 
            this.pcb_timeleft.AutoSize = true;
            this.pcb_timeleft.BackColor = System.Drawing.SystemColors.Control;
            this.pcb_timeleft.Location = new System.Drawing.Point(196, 332);
            this.pcb_timeleft.Name = "pcb_timeleft";
            this.pcb_timeleft.Size = new System.Drawing.Size(45, 13);
            this.pcb_timeleft.TabIndex = 20;
            this.pcb_timeleft.Text = "Elapsed";
            // 
            // pcb_cpu
            // 
            this.pcb_cpu.AutoSize = true;
            this.pcb_cpu.BackColor = System.Drawing.SystemColors.Control;
            this.pcb_cpu.Location = new System.Drawing.Point(408, 319);
            this.pcb_cpu.Name = "pcb_cpu";
            this.pcb_cpu.Size = new System.Drawing.Size(41, 26);
            this.pcb_cpu.TabIndex = 21;
            this.pcb_cpu.Text = "Time in\r\nSystem";
            // 
            // pcb_io
            // 
            this.pcb_io.AutoSize = true;
            this.pcb_io.BackColor = System.Drawing.SystemColors.Control;
            this.pcb_io.Location = new System.Drawing.Point(246, 332);
            this.pcb_io.Name = "pcb_io";
            this.pcb_io.Size = new System.Drawing.Size(50, 13);
            this.pcb_io.TabIndex = 22;
            this.pcb_io.Text = "Total I/O";
            // 
            // pcb_ioleft
            // 
            this.pcb_ioleft.AutoSize = true;
            this.pcb_ioleft.BackColor = System.Drawing.SystemColors.Control;
            this.pcb_ioleft.Location = new System.Drawing.Point(302, 332);
            this.pcb_ioleft.Name = "pcb_ioleft";
            this.pcb_ioleft.Size = new System.Drawing.Size(51, 13);
            this.pcb_ioleft.TabIndex = 23;
            this.pcb_ioleft.Text = "I/O Used";
            // 
            // pcb_cpuleft
            // 
            this.pcb_cpuleft.AutoSize = true;
            this.pcb_cpuleft.BackColor = System.Drawing.SystemColors.Control;
            this.pcb_cpuleft.Location = new System.Drawing.Point(455, 332);
            this.pcb_cpuleft.Name = "pcb_cpuleft";
            this.pcb_cpuleft.Size = new System.Drawing.Size(50, 13);
            this.pcb_cpuleft.TabIndex = 24;
            this.pcb_cpuleft.Text = "Idle Time";
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
            this.delay_bar.Size = new System.Drawing.Size(104, 45);
            this.delay_bar.TabIndex = 0;
            this.delay_bar.Scroll += new System.EventHandler(this.delay_bar_Scroll);
            // 
            // settings_waiting
            // 
            this.settings_waiting.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.settings_waiting.Location = new System.Drawing.Point(446, 168);
            this.settings_waiting.Multiline = true;
            this.settings_waiting.Name = "settings_waiting";
            this.settings_waiting.Size = new System.Drawing.Size(36, 20);
            this.settings_waiting.TabIndex = 26;
            // 
            // settings_ready
            // 
            this.settings_ready.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.settings_ready.Location = new System.Drawing.Point(214, 168);
            this.settings_ready.Multiline = true;
            this.settings_ready.Name = "settings_ready";
            this.settings_ready.Size = new System.Drawing.Size(36, 20);
            this.settings_ready.TabIndex = 27;
            // 
            // settings_new
            // 
            this.settings_new.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.settings_new.Location = new System.Drawing.Point(102, 168);
            this.settings_new.Multiline = true;
            this.settings_new.Name = "settings_new";
            this.settings_new.Size = new System.Drawing.Size(36, 20);
            this.settings_new.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Size";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(12, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 78);
            this.label8.TabIndex = 32;
            this.label8.Text = "S\r\nT\r\nA\r\nT\r\nE\r\nS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(12, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 39);
            this.label9.TabIndex = 33;
            this.label9.Text = "P\r\nC\r\nB";
            // 
            // message_display
            // 
            this.message_display.BackColor = System.Drawing.SystemColors.Control;
            this.message_display.Location = new System.Drawing.Point(32, 118);
            this.message_display.Multiline = true;
            this.message_display.Name = "message_display";
            this.message_display.ReadOnly = true;
            this.message_display.Size = new System.Drawing.Size(562, 20);
            this.message_display.TabIndex = 34;
            // 
            // cycle_display
            // 
            this.cycle_display.AutoSize = true;
            this.cycle_display.Location = new System.Drawing.Point(317, 175);
            this.cycle_display.Name = "cycle_display";
            this.cycle_display.Size = new System.Drawing.Size(36, 13);
            this.cycle_display.TabIndex = 36;
            this.cycle_display.Text = "Cycle:";
            // 
            // run_cycle
            // 
            this.run_cycle.AutoSize = true;
            this.run_cycle.Location = new System.Drawing.Point(348, 175);
            this.run_cycle.Name = "run_cycle";
            this.run_cycle.Size = new System.Drawing.Size(13, 13);
            this.run_cycle.TabIndex = 37;
            this.run_cycle.Text = "0";
            // 
            // io1_cycle
            // 
            this.io1_cycle.AutoSize = true;
            this.io1_cycle.Location = new System.Drawing.Point(348, 269);
            this.io1_cycle.Name = "io1_cycle";
            this.io1_cycle.Size = new System.Drawing.Size(13, 13);
            this.io1_cycle.TabIndex = 39;
            this.io1_cycle.Text = "0";
            // 
            // io1_display
            // 
            this.io1_display.AutoSize = true;
            this.io1_display.Location = new System.Drawing.Point(317, 269);
            this.io1_display.Name = "io1_display";
            this.io1_display.Size = new System.Drawing.Size(36, 13);
            this.io1_display.TabIndex = 38;
            this.io1_display.Text = "Cycle:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(463, 599);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Storm OS by Luis Orozco. ";
            // 
            // finish_label
            // 
            this.finish_label.AutoSize = true;
            this.finish_label.BackColor = System.Drawing.SystemColors.Control;
            this.finish_label.Location = new System.Drawing.Point(357, 319);
            this.finish_label.Name = "finish_label";
            this.finish_label.Size = new System.Drawing.Size(48, 26);
            this.finish_label.TabIndex = 41;
            this.finish_label.Text = "Finishing\r\nCycle";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.SystemColors.Control;
            this.status.Location = new System.Drawing.Point(511, 332);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(37, 13);
            this.status.TabIndex = 42;
            this.status.Text = "Status";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(154, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 26);
            this.label12.TabIndex = 43;
            this.label12.Text = "CPU\r\nUsed";
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
            // mainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 621);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.status);
            this.Controls.Add(this.finish_label);
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
            this.Controls.Add(this.pcb_cpuleft);
            this.Controls.Add(this.pcb_ioleft);
            this.Controls.Add(this.pcb_io);
            this.Controls.Add(this.pcb_list);
            this.Controls.Add(this.pcb_cpu);
            this.Controls.Add(this.pcb_timeleft);
            this.Controls.Add(this.pcb_totaltime);
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
        private System.Windows.Forms.Label pcb_totaltime;
        private System.Windows.Forms.Label pcb_timeleft;
        private System.Windows.Forms.Label pcb_cpu;
        private System.Windows.Forms.Label pcb_io;
        private System.Windows.Forms.Label pcb_ioleft;
        private System.Windows.Forms.Label pcb_cpuleft;
        private System.Windows.Forms.GroupBox settings;
        private System.Windows.Forms.TextBox settings_waiting;
        private System.Windows.Forms.TextBox settings_ready;
        private System.Windows.Forms.TextBox settings_new;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label finish_label;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cpu_update;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

