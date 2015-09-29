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
            this.SuspendLayout();
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Location = new System.Drawing.Point(38, 27);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(34, 13);
            this.clock.TabIndex = 0;
            this.clock.Text = "Clock";
            // 
            // quantum
            // 
            this.quantum.AutoSize = true;
            this.quantum.Location = new System.Drawing.Point(116, 27);
            this.quantum.Name = "quantum";
            this.quantum.Size = new System.Drawing.Size(50, 13);
            this.quantum.TabIndex = 1;
            this.quantum.Text = "Quantum";
            // 
            // new_queue
            // 
            this.new_queue.AutoSize = true;
            this.new_queue.BackColor = System.Drawing.SystemColors.Control;
            this.new_queue.Location = new System.Drawing.Point(38, 84);
            this.new_queue.Name = "new_queue";
            this.new_queue.Size = new System.Drawing.Size(29, 13);
            this.new_queue.TabIndex = 2;
            this.new_queue.Text = "New";
            // 
            // ready_queue
            // 
            this.ready_queue.AutoSize = true;
            this.ready_queue.BackColor = System.Drawing.SystemColors.Control;
            this.ready_queue.Location = new System.Drawing.Point(150, 84);
            this.ready_queue.Name = "ready_queue";
            this.ready_queue.Size = new System.Drawing.Size(38, 13);
            this.ready_queue.TabIndex = 3;
            this.ready_queue.Text = "Ready";
            // 
            // running_queue
            // 
            this.running_queue.AutoSize = true;
            this.running_queue.BackColor = System.Drawing.SystemColors.Control;
            this.running_queue.Location = new System.Drawing.Point(262, 84);
            this.running_queue.Name = "running_queue";
            this.running_queue.Size = new System.Drawing.Size(47, 13);
            this.running_queue.TabIndex = 4;
            this.running_queue.Text = "Running";
            // 
            // finished_queue
            // 
            this.finished_queue.AutoSize = true;
            this.finished_queue.BackColor = System.Drawing.SystemColors.Control;
            this.finished_queue.Location = new System.Drawing.Point(486, 84);
            this.finished_queue.Name = "finished_queue";
            this.finished_queue.Size = new System.Drawing.Size(46, 13);
            this.finished_queue.TabIndex = 5;
            this.finished_queue.Text = "Finished";
            // 
            // new_list
            // 
            this.new_list.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.new_list.Location = new System.Drawing.Point(41, 100);
            this.new_list.Multiline = true;
            this.new_list.Name = "new_list";
            this.new_list.ReadOnly = true;
            this.new_list.Size = new System.Drawing.Size(106, 114);
            this.new_list.TabIndex = 6;
            // 
            // ready_list
            // 
            this.ready_list.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ready_list.Location = new System.Drawing.Point(153, 100);
            this.ready_list.Multiline = true;
            this.ready_list.Name = "ready_list";
            this.ready_list.ReadOnly = true;
            this.ready_list.Size = new System.Drawing.Size(106, 114);
            this.ready_list.TabIndex = 7;
            // 
            // running_list
            // 
            this.running_list.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.running_list.Location = new System.Drawing.Point(265, 100);
            this.running_list.Multiline = true;
            this.running_list.Name = "running_list";
            this.running_list.ReadOnly = true;
            this.running_list.Size = new System.Drawing.Size(106, 20);
            this.running_list.TabIndex = 8;
            this.running_list.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clock_display
            // 
            this.clock_display.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.clock_display.Location = new System.Drawing.Point(41, 43);
            this.clock_display.Multiline = true;
            this.clock_display.Name = "clock_display";
            this.clock_display.ReadOnly = true;
            this.clock_display.Size = new System.Drawing.Size(60, 20);
            this.clock_display.TabIndex = 9;
            // 
            // quantum_display
            // 
            this.quantum_display.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.quantum_display.Location = new System.Drawing.Point(119, 43);
            this.quantum_display.Multiline = true;
            this.quantum_display.Name = "quantum_display";
            this.quantum_display.ReadOnly = true;
            this.quantum_display.Size = new System.Drawing.Size(60, 20);
            this.quantum_display.TabIndex = 10;
            // 
            // finished_list
            // 
            this.finished_list.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.finished_list.Location = new System.Drawing.Point(489, 100);
            this.finished_list.Multiline = true;
            this.finished_list.Name = "finished_list";
            this.finished_list.ReadOnly = true;
            this.finished_list.Size = new System.Drawing.Size(106, 114);
            this.finished_list.TabIndex = 11;
            // 
            // waiting_list
            // 
            this.waiting_list.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.waiting_list.Location = new System.Drawing.Point(377, 100);
            this.waiting_list.Multiline = true;
            this.waiting_list.Name = "waiting_list";
            this.waiting_list.ReadOnly = true;
            this.waiting_list.Size = new System.Drawing.Size(106, 114);
            this.waiting_list.TabIndex = 12;
            this.waiting_list.TextChanged += new System.EventHandler(this.waiting_list_TextChanged);
            // 
            // waiting_queue
            // 
            this.waiting_queue.AutoSize = true;
            this.waiting_queue.BackColor = System.Drawing.SystemColors.Control;
            this.waiting_queue.Location = new System.Drawing.Point(374, 84);
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
            this.io1_queue.Location = new System.Drawing.Point(265, 122);
            this.io1_queue.Name = "io1_queue";
            this.io1_queue.Size = new System.Drawing.Size(53, 13);
            this.io1_queue.TabIndex = 14;
            this.io1_queue.Text = "Using I/O";
            // 
            // io1_list
            // 
            this.io1_list.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.io1_list.Location = new System.Drawing.Point(265, 138);
            this.io1_list.Multiline = true;
            this.io1_list.Name = "io1_list";
            this.io1_list.ReadOnly = true;
            this.io1_list.Size = new System.Drawing.Size(106, 20);
            this.io1_list.TabIndex = 15;
            // 
            // pcb_list
            // 
            this.pcb_list.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pcb_list.Location = new System.Drawing.Point(41, 248);
            this.pcb_list.Multiline = true;
            this.pcb_list.Name = "pcb_list";
            this.pcb_list.ReadOnly = true;
            this.pcb_list.Size = new System.Drawing.Size(554, 388);
            this.pcb_list.TabIndex = 16;
            // 
            // pcb_id
            // 
            this.pcb_id.AutoSize = true;
            this.pcb_id.BackColor = System.Drawing.SystemColors.Control;
            this.pcb_id.Location = new System.Drawing.Point(43, 232);
            this.pcb_id.Name = "pcb_id";
            this.pcb_id.Size = new System.Drawing.Size(29, 13);
            this.pcb_id.TabIndex = 17;
            this.pcb_id.Text = "New";
            this.pcb_id.Click += new System.EventHandler(this.label1_Click);
            // 
            // mainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 693);
            this.Controls.Add(this.pcb_id);
            this.Controls.Add(this.pcb_list);
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
    }
}

