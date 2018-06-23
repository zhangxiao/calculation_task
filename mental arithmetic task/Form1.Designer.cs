namespace mental_arithmetic_task
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_score = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer_total = new System.Windows.Forms.Timer(this.components);
            this.timer_1second = new System.Windows.Forms.Timer(this.components);
            this.button26 = new System.Windows.Forms.Button();
            this.timer_show_result = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.timer_rest = new System.Windows.Forms.Timer(this.components);
            this.timer_remind = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer_10min_rest = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Minuend = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label_subresult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_score.Location = new System.Drawing.Point(1152, 194);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(116, 43);
            this.label_score.TabIndex = 0;
            this.label_score.Text = "Score:";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_time.Location = new System.Drawing.Point(414, 194);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(174, 43);
            this.label_time.TabIndex = 1;
            this.label_time.Text = "Time Left:";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(642, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 58);
            this.label3.TabIndex = 4;
            // 
            // timer_total
            // 
            this.timer_total.Tick += new System.EventHandler(this.timer_total_Tick);
            // 
            // timer_1second
            // 
            this.timer_1second.Tick += new System.EventHandler(this.timer_1second_Tick);
            // 
            // button26
            // 
            this.button26.AutoSize = true;
            this.button26.BackColor = System.Drawing.SystemColors.Control;
            this.button26.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.button26.Image = ((System.Drawing.Image)(resources.GetObject("button26.Image")));
            this.button26.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button26.Location = new System.Drawing.Point(3, 36);
            this.button26.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(93, 100);
            this.button26.TabIndex = 61;
            this.button26.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // timer_show_result
            // 
            this.timer_show_result.Tick += new System.EventHandler(this.timer_show_result_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("幼圆", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(528, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(565, 57);
            this.label5.TabIndex = 67;
            this.label5.Text = "Fast and Accurate!";
            // 
            // timer_rest
            // 
            this.timer_rest.Tick += new System.EventHandler(this.timer_rest_Tick);
            // 
            // timer_remind
            // 
            this.timer_remind.Interval = 3000;
            this.timer_remind.Tick += new System.EventHandler(this.timer_remind_Tick);
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(642, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 58);
            this.label6.TabIndex = 70;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button13.Location = new System.Drawing.Point(180, 330);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(130, 42);
            this.button13.TabIndex = 72;
            this.button13.Text = "Easy";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button14.Location = new System.Drawing.Point(180, 532);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(130, 42);
            this.button14.TabIndex = 73;
            this.button14.Text = "Medium";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button15.Location = new System.Drawing.Point(180, 734);
            this.button15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(130, 42);
            this.button15.TabIndex = 74;
            this.button15.Text = "Hard";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button16.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button16.Location = new System.Drawing.Point(180, 431);
            this.button16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(130, 42);
            this.button16.TabIndex = 76;
            this.button16.Text = "Relax1";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button17.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button17.Location = new System.Drawing.Point(180, 633);
            this.button17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(130, 42);
            this.button17.TabIndex = 77;
            this.button17.Text = "Relax2";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(144, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 43);
            this.label9.TabIndex = 63;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(162, 230);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 39);
            this.textBox1.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 43);
            this.label1.TabIndex = 63;
            this.label1.Text = "Name:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(422, 241);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Maximum = 300;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(950, 49);
            this.progressBar1.TabIndex = 82;
            this.progressBar1.Value = 300;
            // 
            // timer_10min_rest
            // 
            this.timer_10min_rest.Tick += new System.EventHandler(this.timer_10min_rest_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(69, 30);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(172, 120);
            this.axWindowsMediaPlayer1.TabIndex = 75;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(783, 205);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(483, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 58);
            this.label4.TabIndex = 5;
            this.label4.Text = "=";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(289, 180);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(184, 132);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 27F);
            this.label7.Location = new System.Drawing.Point(7, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 97);
            this.label7.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(241, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 58);
            this.label2.TabIndex = 3;
            this.label2.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Minuend);
            this.groupBox1.Location = new System.Drawing.Point(26, 180);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(202, 128);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label_Minuend
            // 
            this.label_Minuend.AutoEllipsis = true;
            this.label_Minuend.Font = new System.Drawing.Font("微软雅黑", 27F);
            this.label_Minuend.Location = new System.Drawing.Point(7, 29);
            this.label_Minuend.MaximumSize = new System.Drawing.Size(900, 960);
            this.label_Minuend.Name = "label_Minuend";
            this.label_Minuend.Size = new System.Drawing.Size(189, 94);
            this.label_Minuend.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox5.Controls.Add(this.label_subresult);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Controls.Add(this.axWindowsMediaPlayer1);
            this.groupBox5.Location = new System.Drawing.Point(401, 386);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(930, 408);
            this.groupBox5.TabIndex = 69;
            this.groupBox5.TabStop = false;
            // 
            // label_subresult
            // 
            this.label_subresult.BackColor = System.Drawing.SystemColors.Control;
            this.label_subresult.Font = new System.Drawing.Font("微软雅黑", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_subresult.Location = new System.Drawing.Point(570, 209);
            this.label_subresult.Name = "label_subresult";
            this.label_subresult.Size = new System.Drawing.Size(180, 79);
            this.label_subresult.TabIndex = 81;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1456, 862);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Mental Arithmetic";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress_1);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer_total;
        private System.Windows.Forms.Timer timer_1second;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Timer timer_show_result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer_rest;
        private System.Windows.Forms.Timer timer_remind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer_10min_rest;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Minuend;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox label_subresult;
    }
}

