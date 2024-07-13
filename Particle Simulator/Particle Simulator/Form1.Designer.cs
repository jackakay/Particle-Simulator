namespace Particle_Simulator
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
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            trackBar1 = new TrackBar();
            label7 = new Label();
            trackBar2 = new TrackBar();
            label8 = new Label();
            trackBar4 = new TrackBar();
            label9 = new Label();
            label10 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 21);
            label1.TabIndex = 0;
            label1.Text = "Particle Simulator";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(39, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 760);
            panel1.TabIndex = 1;
            panel1.Resize += panel1_Resize;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(994, 130);
            label3.Name = "label3";
            label3.Size = new Size(120, 21);
            label3.TabIndex = 3;
            label3.Text = "Temperature (K)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(994, 260);
            label4.Name = "label4";
            label4.Size = new Size(224, 21);
            label4.TabIndex = 4;
            label4.Text = "Breaking stress of material (Pa)";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1128, 202);
            label6.Name = "label6";
            label6.Size = new Size(43, 17);
            label6.TabIndex = 10;
            label6.Text = "label6";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(1008, 191);
            trackBar1.Maximum = 1000;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(104, 45);
            trackBar1.TabIndex = 9;
            trackBar1.Value = 10;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1128, 310);
            label7.Name = "label7";
            label7.Size = new Size(43, 17);
            label7.TabIndex = 12;
            label7.Text = "label7";
            label7.Click += label7_Click;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(1008, 299);
            trackBar2.Maximum = 1000;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(104, 45);
            trackBar2.TabIndex = 11;
            trackBar2.Scroll += trackBar2_Scroll;
            trackBar2.ValueChanged += trackBar2_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1118, 78);
            label8.Name = "label8";
            label8.Size = new Size(43, 17);
            label8.TabIndex = 15;
            label8.Text = "label8";
            label8.Click += label8_Click;
            // 
            // trackBar4
            // 
            trackBar4.LargeChange = 0;
            trackBar4.Location = new Point(998, 67);
            trackBar4.Maximum = 760;
            trackBar4.Minimum = 100;
            trackBar4.Name = "trackBar4";
            trackBar4.Size = new Size(104, 45);
            trackBar4.TabIndex = 14;
            trackBar4.Value = 100;
            trackBar4.Scroll += trackBar4_Scroll;
            trackBar4.ValueChanged += trackBar4_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(998, 26);
            label9.Name = "label9";
            label9.Size = new Size(116, 21);
            label9.TabIndex = 13;
            label9.Text = "Side length (m)";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(492, 26);
            label10.Name = "label10";
            label10.Size = new Size(192, 21);
            label10.TabIndex = 16;
            label10.Text = "Average speed of particle: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1016, 365);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 17;
            label2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 830);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(trackBar4);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(trackBar2);
            Controls.Add(label6);
            Controls.Add(trackBar1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Particle simulator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label6;
        private TrackBar trackBar1;
        private Label label7;
        private TrackBar trackBar2;
        private Label label8;
        private TrackBar trackBar4;
        private Label label9;
        private Label label10;
        private Label label2;
    }
}