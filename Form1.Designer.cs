namespace CSharp_Clock
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            btnStart = new Button();
            btnReset = new Button();
            btnStop = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("DS-Digital", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 30);
            label1.Name = "label1";
            label1.Size = new Size(495, 95);
            label1.TabIndex = 0;
            label1.Text = "00:00:00:00";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("DS-Digital", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 125);
            label2.Name = "label2";
            label2.Size = new Size(495, 95);
            label2.TabIndex = 0;
            label2.Text = "00:00:00:00";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(33, 223);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(113, 38);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(415, 223);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(113, 38);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(221, 223);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(113, 38);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(555, 377);
            Controls.Add(btnStop);
            Controls.Add(btnReset);
            Controls.Add(btnStart);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Red;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Button btnStart;
        private Button btnReset;
        private Button btnStop;
    }
}
