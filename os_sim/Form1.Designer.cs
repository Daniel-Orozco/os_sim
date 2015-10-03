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
            this.average_cpu = new System.Windows.Forms.TextBox();
            this.pause = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.setttings_chance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.algorithm_list = new System.Windows.Forms.ListBox();
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
            this.settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delay_bar)).BeginInit();
            this.SuspendLayout();
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Location = new System.Drawing.Point(37, 22);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(34, 13);
            this.clock.TabIndex = 0;
            this.clock.Text = "Clock";
            // 
            // quantum
            // 
            this.quantum.AutoSize = true;
            this.quantum.Location = new System.Drawing.Point(115, 22);
            this.quantum.Name = "quantum";
            this.quantum.Size = new System.Drawing.Size(50, 13);
            this.quantum.TabIndex = 1;
            this.quantum.Text = "Quantum";
            // 
            // new_queue
            // 
            this.new_queue.AutoSize = true;
            this.new_queue.BackColor = System.Drawing.SystemColors.Control;
            this.new_queue.Location = new System.Drawing.Point(39, 161);
            this.new_queue.Name = "new_queue";
            this.new_queue.Size = new System.Drawing.Size(29, 13);
            this.new_queue.TabIndex = 2;
            this.new_queue.Text = "New";
            // 
            // ready_queue
            // 
            this.ready_queue.AutoSize = true;
            this.ready_queue.BackColor = System.Drawing.SystemColors.Control;
            this.ready_queue.Location = new System.Drawing.Point(149, 161);
            this.ready_queue.Name = "ready_queue";
            this.ready_queue.Size = new System.Drawing.Size(38, 13);
            this.ready_queue.TabIndex = 3;
            this.ready_queue.Text = "Ready";
            // 
            // running_queue
            // 
            this.running_queue.AutoSize = true;
            this.running_queue.BackColor = System.Drawing.SystemColors.Control;
            this.running_queue.Location = new System.Drawing.Point(261, 165);
            this.running_queue.Name = "running_queue";
            this.running_queue.Size = new System.Drawing.Size(47, 13);
            this.running_queue.TabIndex = 4;
            this.running_queue.Text = "Running";
            // 
            // finished_queue
            // 
            this.finished_queue.AutoSize = true;
            this.finished_queue.BackColor = System.Drawing.SystemColors.Control;
            this.finished_queue.Location = new System.Drawing.Point(485, 165);
            this.finished_queue.Name = "finished_queue";
            this.finished_queue.Size = new System.Drawing.Size(46, 13);
            this.finished_queue.TabIndex = 5;
            this.finished_queue.Text = "Finished";
            // 
            // new_list
            // 
            this.new_list.BackColor = System.Drawing.SystemColors.ControlLight;
            this.new_list.Location = new System.Drawing.Point(40, 181);
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
            this.ready_list.Location = new System.Drawing.Point(152, 181);
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
            this.running_list.Location = new System.Drawing.Point(264, 181);
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
            this.clock_display.Location = new System.Drawing.Point(40, 38);
            this.clock_display.Multiline = true;
            this.clock_display.Name = "clock_display";
            this.clock_display.ReadOnly = true;
            this.clock_display.Size = new System.Drawing.Size(60, 20);
            this.clock_display.TabIndex = 9;
            // 
            // quantum_display
            // 
            this.quantum_display.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.quantum_display.Location = new System.Drawing.Point(118, 38);
            this.quantum_display.Multiline = true;
            this.quantum_display.Name = "quantum_display";
            this.quantum_display.Size = new System.Drawing.Size(60, 20);
            this.quantum_display.TabIndex = 10;
            // 
            // finished_list
            // 
            this.finished_list.BackColor = System.Drawing.SystemColors.ControlLight;
            this.finished_list.Location = new System.Drawing.Point(488, 181);
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
            this.waiting_list.Location = new System.Drawing.Point(376, 181);
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
            this.waiting_queue.Location = new System.Drawing.Point(373, 161);
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
            this.io1_queue.Location = new System.Drawing.Point(264, 259);
            this.io1_queue.Name = "io1_queue";
            this.io1_queue.Size = new System.Drawing.Size(53, 13);
            this.io1_queue.TabIndex = 14;
            this.io1_queue.Text = "Using I/O";
            // 
            // io1_list
            // 
            this.io1_list.BackColor = System.Drawing.SystemColors.ControlLight;
            this.io1_list.Location = new System.Drawing.Point(264, 275);
            this.io1_list.Multiline = true;
            this.io1_list.Name = "io1_list";
            this.io1_list.ReadOnly = true;
            this.io1_list.Size = new System.Drawing.Size(106, 20);
            this.io1_list.TabIndex = 15;
            // 
            // pcb_list
            // 
            this.pcb_list.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pcb_list.Location = new System.Drawing.Point(40, 319);
            this.pcb_list.Multiline = true;
            this.pcb_list.Name = "pcb_list";
            this.pcb_list.ReadOnly = true;
            this.pcb_list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pcb_list.Size = new System.Drawing.Size(554, 247);
            this.pcb_list.TabIndex = 16;
            // 
            // pcb_id
            // 
            this.pcb_id.AutoSize = true;
            this.pcb_id.BackColor = System.Drawing.SystemColors.Control;
            this.pcb_id.Location = new System.Drawing.Point(39, 303);
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
            this.pcb_arrival.Location = new System.Drawing.Point(84, 303);
            this.pcb_arrival.Name = "pcb_arrival";
            this.pcb_arrival.Size = new System.Drawing.Size(36, 13);
            this.pcb_arrival.TabIndex = 18;
            this.pcb_arrival.Text = "Arrival";
            // 
            // pcb_totaltime
            // 
            this.pcb_totaltime.AutoSize = true;
            this.pcb_totaltime.BackColor = System.Drawing.SystemColors.Control;
            this.pcb_totaltime.Location = new System.Drawing.Point(132, 303);
            this.pcb_totaltime.Name = "pcb_totaltime";
            this.pcb_totaltime.Size = new System.Drawing.Size(27, 13);
            this.pcb_totaltime.TabIndex = 19;
            this.pcb_totaltime.Text = "Size";
            // 
            // pcb_timeleft
            // 
            this.pcb_timeleft.AutoSize = true;
            this.pcb_timeleft.BackColor = System.Drawing.SystemColors.Control;
            this.pcb_timeleft.Location = new System.Drawing.Point(165, 303);
            this.pcb_timeleft.Name = "pcb_timeleft";
            this.pcb_timeleft.Size = new System.Drawing.Size(57, 13);
            this.pcb_timeleft.TabIndex = 20;
            this.pcb_timeleft.Text = "Remaining";
            // 
            // pcb_cpu
            // 
            this.pcb_cpu.AutoSize = true;
            this.pcb_cpu.BackColor = System.Drawing.SystemColors.Control;
            this.pcb_cpu.Location = new System.Drawing.Point(228, 303);
            this.pcb_cpu.Name = "pcb_cpu";
            this.pcb_cpu.Size = new System.Drawing.Size(51, 13);
            this.pcb_cpu.TabIndex = 21;
            this.pcb_cpu.Text = "CPU Use";
            // 
            // pcb_io
            // 
            this.pcb_io.AutoSize = true;
            this.pcb_io.BackColor = System.Drawing.SystemColors.Control;
            this.pcb_io.Location = new System.Drawing.Point(341, 303);
            this.pcb_io.Name = "pcb_io";
            this.pcb_io.Size = new System.Drawing.Size(45, 13);
            this.pcb_io.TabIndex = 22;
            this.pcb_io.Text = "I/O Use";
            // 
            // pcb_ioleft
            // 
            this.pcb_ioleft.AutoSize = true;
            this.pcb_ioleft.BackColor = System.Drawing.SystemColors.Control;
            this.pcb_ioleft.Location = new System.Drawing.Point(392, 303);
            this.pcb_ioleft.Name = "pcb_ioleft";
            this.pcb_ioleft.Size = new System.Drawing.Size(44, 13);
            this.pcb_ioleft.TabIndex = 23;
            this.pcb_ioleft.Text = "I/O Left";
            // 
            // pcb_cpuleft
            // 
            this.pcb_cpuleft.AutoSize = true;
            this.pcb_cpuleft.BackColor = System.Drawing.SystemColors.Control;
            this.pcb_cpuleft.Location = new System.Drawing.Point(285, 303);
            this.pcb_cpuleft.Name = "pcb_cpuleft";
            this.pcb_cpuleft.Size = new System.Drawing.Size(50, 13);
            this.pcb_cpuleft.TabIndex = 24;
            this.pcb_cpuleft.Text = "CPU Left";
            // 
            // settings
            // 
            this.settings.Controls.Add(this.label10);
            this.settings.Controls.Add(this.average_cpu);
            this.settings.Controls.Add(this.pause);
            this.settings.Controls.Add(this.play);
            this.settings.Controls.Add(this.stop);
            this.settings.Controls.Add(this.setttings_chance);
            this.settings.Controls.Add(this.label7);
            this.settings.Controls.Add(this.label6);
            this.settings.Controls.Add(this.algorithm_list);
            this.settings.Controls.Add(this.label5);
            this.settings.Controls.Add(this.label4);
            this.settings.Controls.Add(this.delay_bar);
            this.settings.Location = new System.Drawing.Point(205, 12);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(389, 91);
            this.settings.TabIndex = 25;
            this.settings.TabStop = false;
            this.settings.Text = "Settings";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(94, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Average CPU";
            // 
            // average_cpu
            // 
            this.average_cpu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.average_cpu.Location = new System.Drawing.Point(176, 59);
            this.average_cpu.Multiline = true;
            this.average_cpu.Name = "average_cpu";
            this.average_cpu.Size = new System.Drawing.Size(36, 20);
            this.average_cpu.TabIndex = 37;
            this.average_cpu.TextChanged += new System.EventHandler(this.average_cpu_TextChanged);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(75, 29);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(24, 23);
            this.pause.TabIndex = 36;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(45, 29);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(24, 23);
            this.play.TabIndex = 35;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(15, 29);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(24, 23);
            this.stop.TabIndex = 34;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // setttings_chance
            // 
            this.setttings_chance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.setttings_chance.Location = new System.Drawing.Point(176, 36);
            this.setttings_chance.Multiline = true;
            this.setttings_chance.Name = "setttings_chance";
            this.setttings_chance.Size = new System.Drawing.Size(36, 20);
            this.setttings_chance.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Chance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Algorithm";
            // 
            // algorithm_list
            // 
            this.algorithm_list.FormattingEnabled = true;
            this.algorithm_list.Items.AddRange(new object[] {
            "Round Robin",
            "FCFS"});
            this.algorithm_list.Location = new System.Drawing.Point(176, 15);
            this.algorithm_list.Name = "algorithm_list";
            this.algorithm_list.Size = new System.Drawing.Size(95, 17);
            this.algorithm_list.TabIndex = 33;
            this.algorithm_list.SelectedIndexChanged += new System.EventHandler(this.algorithm_list_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Delay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Slow   Normal   Fast";
            // 
            // delay_bar
            // 
            this.delay_bar.BackColor = System.Drawing.SystemColors.Control;
            this.delay_bar.LargeChange = 1;
            this.delay_bar.Location = new System.Drawing.Point(279, 23);
            this.delay_bar.Maximum = 2;
            this.delay_bar.Name = "delay_bar";
            this.delay_bar.Size = new System.Drawing.Size(104, 45);
            this.delay_bar.TabIndex = 0;
            // 
            // settings_waiting
            // 
            this.settings_waiting.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.settings_waiting.Location = new System.Drawing.Point(446, 158);
            this.settings_waiting.Multiline = true;
            this.settings_waiting.Name = "settings_waiting";
            this.settings_waiting.Size = new System.Drawing.Size(36, 20);
            this.settings_waiting.TabIndex = 26;
            // 
            // settings_ready
            // 
            this.settings_ready.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.settings_ready.Location = new System.Drawing.Point(222, 158);
            this.settings_ready.Multiline = true;
            this.settings_ready.Name = "settings_ready";
            this.settings_ready.Size = new System.Drawing.Size(36, 20);
            this.settings_ready.TabIndex = 27;
            // 
            // settings_new
            // 
            this.settings_new.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.settings_new.Location = new System.Drawing.Point(110, 158);
            this.settings_new.Multiline = true;
            this.settings_new.Name = "settings_new";
            this.settings_new.Size = new System.Drawing.Size(36, 20);
            this.settings_new.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Size";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(11, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 78);
            this.label8.TabIndex = 32;
            this.label8.Text = "S\r\nT\r\nA\r\nT\r\nE\r\nS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(11, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 39);
            this.label9.TabIndex = 33;
            this.label9.Text = "P\r\nC\r\nB";
            // 
            // message_display
            // 
            this.message_display.BackColor = System.Drawing.SystemColors.Control;
            this.message_display.Location = new System.Drawing.Point(42, 109);
            this.message_display.Multiline = true;
            this.message_display.Name = "message_display";
            this.message_display.ReadOnly = true;
            this.message_display.Size = new System.Drawing.Size(552, 20);
            this.message_display.TabIndex = 34;
            // 
            // mainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 693);
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
            this.Name = "mainView";
            this.Text = "os_sim";
            this.Load += new System.EventHandler(this.mainView_Load);
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delay_bar)).EndInit();
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
        private System.Windows.Forms.ListBox algorithm_list;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox setttings_chance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox average_cpu;
        private System.Windows.Forms.TextBox message_display;
    }
}

