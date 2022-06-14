namespace Project1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonThird3 = new System.Windows.Forms.RadioButton();
            this.radioButtonThird2 = new System.Windows.Forms.RadioButton();
            this.radioButtonThird1 = new System.Windows.Forms.RadioButton();
            this.radioButtonseconddislike = new System.Windows.Forms.RadioButton();
            this.radioButtonSecondlike = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonNext2 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonThird3);
            this.groupBox2.Controls.Add(this.radioButtonThird2);
            this.groupBox2.Controls.Add(this.radioButtonThird1);
            this.groupBox2.Location = new System.Drawing.Point(86, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "3. 운동을 어디서 하십니까?";
            // 
            // radioButtonThird3
            // 
            this.radioButtonThird3.AutoSize = true;
            this.radioButtonThird3.Location = new System.Drawing.Point(388, 60);
            this.radioButtonThird3.Name = "radioButtonThird3";
            this.radioButtonThird3.Size = new System.Drawing.Size(161, 16);
            this.radioButtonThird3.TabIndex = 3;
            this.radioButtonThird3.TabStop = true;
            this.radioButtonThird3.Text = "전문 운동시설(헬스장 등)";
            this.radioButtonThird3.UseVisualStyleBackColor = true;
            // 
            // radioButtonThird2
            // 
            this.radioButtonThird2.AutoSize = true;
            this.radioButtonThird2.Location = new System.Drawing.Point(256, 60);
            this.radioButtonThird2.Name = "radioButtonThird2";
            this.radioButtonThird2.Size = new System.Drawing.Size(51, 16);
            this.radioButtonThird2.TabIndex = 2;
            this.radioButtonThird2.TabStop = true;
            this.radioButtonThird2.Text = "집 안";
            this.radioButtonThird2.UseVisualStyleBackColor = true;
            // 
            // radioButtonThird1
            // 
            this.radioButtonThird1.AutoSize = true;
            this.radioButtonThird1.Location = new System.Drawing.Point(80, 60);
            this.radioButtonThird1.Name = "radioButtonThird1";
            this.radioButtonThird1.Size = new System.Drawing.Size(101, 16);
            this.radioButtonThird1.TabIndex = 1;
            this.radioButtonThird1.TabStop = true;
            this.radioButtonThird1.Text = "야외(산, 공원)";
            this.radioButtonThird1.UseVisualStyleBackColor = true;
            // 
            // radioButtonseconddislike
            // 
            this.radioButtonseconddislike.AutoSize = true;
            this.radioButtonseconddislike.Location = new System.Drawing.Point(361, 58);
            this.radioButtonseconddislike.Name = "radioButtonseconddislike";
            this.radioButtonseconddislike.Size = new System.Drawing.Size(87, 16);
            this.radioButtonseconddislike.TabIndex = 6;
            this.radioButtonseconddislike.Text = "안 좋아한다";
            this.radioButtonseconddislike.UseVisualStyleBackColor = true;
            // 
            // radioButtonSecondlike
            // 
            this.radioButtonSecondlike.AutoSize = true;
            this.radioButtonSecondlike.Location = new System.Drawing.Point(151, 58);
            this.radioButtonSecondlike.Name = "radioButtonSecondlike";
            this.radioButtonSecondlike.Size = new System.Drawing.Size(71, 16);
            this.radioButtonSecondlike.TabIndex = 5;
            this.radioButtonSecondlike.Text = "좋아한다";
            this.radioButtonSecondlike.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSecondlike);
            this.groupBox1.Controls.Add(this.radioButtonseconddislike);
            this.groupBox1.Location = new System.Drawing.Point(86, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 131);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2. 운동을 좋아합니까?";
            // 
            // buttonNext2
            // 
            this.buttonNext2.Location = new System.Drawing.Point(342, 382);
            this.buttonNext2.Name = "buttonNext2";
            this.buttonNext2.Size = new System.Drawing.Size(85, 28);
            this.buttonNext2.TabIndex = 4;
            this.buttonNext2.Text = "다음";
            this.buttonNext2.UseVisualStyleBackColor = true;
            this.buttonNext2.Click += new System.EventHandler(this.buttonNext2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNext2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "설문조사";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonThird3;
        private System.Windows.Forms.RadioButton radioButtonThird2;
        private System.Windows.Forms.RadioButton radioButtonThird1;
        private System.Windows.Forms.RadioButton radioButtonseconddislike;
        private System.Windows.Forms.RadioButton radioButtonSecondlike;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonNext2;
    }
}