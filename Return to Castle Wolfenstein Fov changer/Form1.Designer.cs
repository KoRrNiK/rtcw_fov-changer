
namespace Return_to_Castle_Wolfenstein_Fov_changer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tittleProgram = new System.Windows.Forms.Label();
            this.up_bar_button1 = new System.Windows.Forms.Button();
            this.up_bar_button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.processID = new System.Windows.Forms.Label();
            this.processOpenLabel = new System.Windows.Forms.Label();
            this.valueFov = new System.Windows.Forms.Label();
            this.fov_bar = new System.Windows.Forms.TrackBar();
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fov_bar)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // timer7
            // 
            this.timer7.Interval = 10;
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tittleProgram);
            this.panel1.Controls.Add(this.up_bar_button1);
            this.panel1.Controls.Add(this.up_bar_button2);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 35);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 10);
            this.label2.TabIndex = 2;
            this.label2.Text = "by KoRrNiK";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.panel3.Location = new System.Drawing.Point(4, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 1);
            this.panel3.TabIndex = 2;
            // 
            // tittleProgram
            // 
            this.tittleProgram.AutoSize = true;
            this.tittleProgram.Location = new System.Drawing.Point(4, 5);
            this.tittleProgram.Name = "tittleProgram";
            this.tittleProgram.Size = new System.Drawing.Size(118, 15);
            this.tittleProgram.TabIndex = 2;
            this.tittleProgram.Text = "RtCW - FOV Changer";
            // 
            // up_bar_button1
            // 
            this.up_bar_button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.up_bar_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up_bar_button1.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.up_bar_button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.up_bar_button1.Location = new System.Drawing.Point(382, 7);
            this.up_bar_button1.Name = "up_bar_button1";
            this.up_bar_button1.Size = new System.Drawing.Size(20, 20);
            this.up_bar_button1.TabIndex = 1;
            this.up_bar_button1.Text = "─";
            this.up_bar_button1.UseVisualStyleBackColor = true;
            this.up_bar_button1.Click += new System.EventHandler(this.up_bar_button1_Click);
            // 
            // up_bar_button2
            // 
            this.up_bar_button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.up_bar_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up_bar_button2.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.up_bar_button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.up_bar_button2.Location = new System.Drawing.Point(408, 7);
            this.up_bar_button2.Name = "up_bar_button2";
            this.up_bar_button2.Size = new System.Drawing.Size(20, 20);
            this.up_bar_button2.TabIndex = 0;
            this.up_bar_button2.Text = "╳";
            this.up_bar_button2.UseVisualStyleBackColor = true;
            this.up_bar_button2.Click += new System.EventHandler(this.up_bar_button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel2.Location = new System.Drawing.Point(-2, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 16);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(5, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "WolfSP Process ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(5, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Process Open:";
            // 
            // processID
            // 
            this.processID.AutoSize = true;
            this.processID.ForeColor = System.Drawing.Color.Maroon;
            this.processID.Location = new System.Drawing.Point(105, 99);
            this.processID.Name = "processID";
            this.processID.Size = new System.Drawing.Size(29, 15);
            this.processID.TabIndex = 4;
            this.processID.Text = "N/A";
            // 
            // processOpenLabel
            // 
            this.processOpenLabel.AutoSize = true;
            this.processOpenLabel.ForeColor = System.Drawing.Color.Maroon;
            this.processOpenLabel.Location = new System.Drawing.Point(81, 114);
            this.processOpenLabel.Name = "processOpenLabel";
            this.processOpenLabel.Size = new System.Drawing.Size(29, 15);
            this.processOpenLabel.TabIndex = 5;
            this.processOpenLabel.Text = "N/A";
            // 
            // valueFov
            // 
            this.valueFov.AutoSize = true;
            this.valueFov.Location = new System.Drawing.Point(353, 57);
            this.valueFov.Name = "valueFov";
            this.valueFov.Size = new System.Drawing.Size(65, 15);
            this.valueFov.TabIndex = 10;
            this.valueFov.Text = "FOV(Value)";
            // 
            // fov_bar
            // 
            this.fov_bar.AutoSize = false;
            this.fov_bar.LargeChange = 0;
            this.fov_bar.Location = new System.Drawing.Point(103, 54);
            this.fov_bar.Maximum = 130;
            this.fov_bar.Minimum = 60;
            this.fov_bar.Name = "fov_bar";
            this.fov_bar.Size = new System.Drawing.Size(248, 31);
            this.fov_bar.SmallChange = 0;
            this.fov_bar.TabIndex = 7;
            this.fov_bar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.fov_bar.Value = 60;
            this.fov_bar.Scroll += new System.EventHandler(this.fov_bar_Scroll);
            // 
            // timer8
            // 
            this.timer8.Interval = 1000;
            this.timer8.Tick += new System.EventHandler(this.timer8_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(358, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 11);
            this.label1.TabIndex = 11;
            this.label1.Text = "Version Program: 1.0.1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(358, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 11);
            this.label5.TabIndex = 12;
            this.label5.Text = "Version Game: 1.42d";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(443, 155);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fov_bar);
            this.Controls.Add(this.valueFov);
            this.Controls.Add(this.processOpenLabel);
            this.Controls.Add(this.processID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fov_bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tittleProgram;
        private System.Windows.Forms.Button up_bar_button1;
        private System.Windows.Forms.Button up_bar_button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label processID;
        private System.Windows.Forms.Label processOpenLabel;
        private System.Windows.Forms.Label valueFov;
        private System.Windows.Forms.TrackBar fov_bar;
        private System.Windows.Forms.Timer timer8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}

