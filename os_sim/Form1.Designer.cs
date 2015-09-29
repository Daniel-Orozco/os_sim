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
            this.SuspendLayout();
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Location = new System.Drawing.Point(38, 36);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(34, 13);
            this.clock.TabIndex = 0;
            this.clock.Text = "Clock";
            // 
            // quantum
            // 
            this.quantum.AutoSize = true;
            this.quantum.Location = new System.Drawing.Point(116, 36);
            this.quantum.Name = "quantum";
            this.quantum.Size = new System.Drawing.Size(50, 13);
            this.quantum.TabIndex = 1;
            this.quantum.Text = "Quantum";
            // 
            // new_queue
            // 
            this.new_queue.AutoSize = true;
            this.new_queue.BackColor = System.Drawing.SystemColors.Control;
            this.new_queue.Location = new System.Drawing.Point(38, 75);
            this.new_queue.Name = "new_queue";
            this.new_queue.Size = new System.Drawing.Size(29, 13);
            this.new_queue.TabIndex = 2;
            this.new_queue.Text = "New";
            // 
            // ready_queue
            // 
            this.ready_queue.AutoSize = true;
            this.ready_queue.BackColor = System.Drawing.SystemColors.Control;
            this.ready_queue.Location = new System.Drawing.Point(89, 75);
            this.ready_queue.Name = "ready_queue";
            this.ready_queue.Size = new System.Drawing.Size(38, 13);
            this.ready_queue.TabIndex = 3;
            this.ready_queue.Text = "Ready";
            // 
            // running_queue
            // 
            this.running_queue.AutoSize = true;
            this.running_queue.BackColor = System.Drawing.SystemColors.Control;
            this.running_queue.Location = new System.Drawing.Point(146, 75);
            this.running_queue.Name = "running_queue";
            this.running_queue.Size = new System.Drawing.Size(47, 13);
            this.running_queue.TabIndex = 4;
            this.running_queue.Text = "Running";
            // 
            // finished_queue
            // 
            this.finished_queue.AutoSize = true;
            this.finished_queue.BackColor = System.Drawing.SystemColors.Control;
            this.finished_queue.Location = new System.Drawing.Point(209, 75);
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
            this.running_list.Size = new System.Drawing.Size(106, 114);
            this.running_list.TabIndex = 8;
            this.running_list.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 693);
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
    }
}

