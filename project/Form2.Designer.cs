namespace Project1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonFirst4 = new System.Windows.Forms.RadioButton();
            this.radioButtonFirst3 = new System.Windows.Forms.RadioButton();
            this.radioButtonFirst2 = new System.Windows.Forms.RadioButton();
            this.radioButtonFirst1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonFirstChecked2 = new System.Windows.Forms.RadioButton();
            this.radioButtonFirstChecked1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNext2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonFirst4);
            this.groupBox1.Controls.Add(this.radioButtonFirst3);
            this.groupBox1.Controls.Add(this.radioButtonFirst2);
            this.groupBox1.Controls.Add(this.radioButtonFirst1);
            this.groupBox1.Location = new System.Drawing.Point(95, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. 평소에 운동을 얼마나 하십니까?";
            // 
            // radioButtonFirst4
            // 
            this.radioButtonFirst4.AutoSize = true;
            this.radioButtonFirst4.Location = new System.Drawing.Point(488, 53);
            this.radioButtonFirst4.Name = "radioButtonFirst4";
            this.radioButtonFirst4.Size = new System.Drawing.Size(87, 16);
            this.radioButtonFirst4.TabIndex = 4;
            this.radioButtonFirst4.TabStop = true;
            this.radioButtonFirst4.Text = "하지 않는다";
            this.radioButtonFirst4.UseVisualStyleBackColor = true;
            this.radioButtonFirst4.CheckedChanged += new System.EventHandler(this.radioButtonFirst4_CheckedChanged);
            this.radioButtonFirst4.Click += new System.EventHandler(this.radioButtonFirst4_Click);
            // 
            // radioButtonFirst3
            // 
            this.radioButtonFirst3.AutoSize = true;
            this.radioButtonFirst3.Location = new System.Drawing.Point(327, 53);
            this.radioButtonFirst3.Name = "radioButtonFirst3";
            this.radioButtonFirst3.Size = new System.Drawing.Size(135, 16);
            this.radioButtonFirst3.TabIndex = 3;
            this.radioButtonFirst3.TabStop = true;
            this.radioButtonFirst3.Text = "주 3회 이하 1회 이상";
            this.radioButtonFirst3.UseVisualStyleBackColor = true;
            // 
            // radioButtonFirst2
            // 
            this.radioButtonFirst2.AutoSize = true;
            this.radioButtonFirst2.Location = new System.Drawing.Point(157, 53);
            this.radioButtonFirst2.Name = "radioButtonFirst2";
            this.radioButtonFirst2.Size = new System.Drawing.Size(135, 16);
            this.radioButtonFirst2.TabIndex = 2;
            this.radioButtonFirst2.TabStop = true;
            this.radioButtonFirst2.Text = "주 5회 이하 3회 이상";
            this.radioButtonFirst2.UseVisualStyleBackColor = true;
            // 
            // radioButtonFirst1
            // 
            this.radioButtonFirst1.AutoSize = true;
            this.radioButtonFirst1.Location = new System.Drawing.Point(39, 53);
            this.radioButtonFirst1.Name = "radioButtonFirst1";
            this.radioButtonFirst1.Size = new System.Drawing.Size(85, 16);
            this.radioButtonFirst1.TabIndex = 1;
            this.radioButtonFirst1.TabStop = true;
            this.radioButtonFirst1.Text = "주 5회 이상";
            this.radioButtonFirst1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonFirstChecked2);
            this.groupBox2.Controls.Add(this.radioButtonFirstChecked1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(95, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 131);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1.1 앞으로 운동을 할 생각이 있습니까?";
            // 
            // radioButtonFirstChecked2
            // 
            this.radioButtonFirstChecked2.AutoSize = true;
            this.radioButtonFirstChecked2.Enabled = false;
            this.radioButtonFirstChecked2.Location = new System.Drawing.Point(353, 75);
            this.radioButtonFirstChecked2.Name = "radioButtonFirstChecked2";
            this.radioButtonFirstChecked2.Size = new System.Drawing.Size(59, 16);
            this.radioButtonFirstChecked2.TabIndex = 6;
            this.radioButtonFirstChecked2.Text = "아니요";
            this.radioButtonFirstChecked2.UseVisualStyleBackColor = true;
            // 
            // radioButtonFirstChecked1
            // 
            this.radioButtonFirstChecked1.AutoSize = true;
            this.radioButtonFirstChecked1.Enabled = false;
            this.radioButtonFirstChecked1.Location = new System.Drawing.Point(157, 75);
            this.radioButtonFirstChecked1.Name = "radioButtonFirstChecked1";
            this.radioButtonFirstChecked1.Size = new System.Drawing.Size(35, 16);
            this.radioButtonFirstChecked1.TabIndex = 5;
            this.radioButtonFirstChecked1.Text = "네";
            this.radioButtonFirstChecked1.UseVisualStyleBackColor = true;
            this.radioButtonFirstChecked1.CheckedChanged += new System.EventHandler(this.radioButtonFirstChecked1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "1번 항목에서 [하지 않는다]를 체크한 사람만 체크해 주세요";
            // 
            // buttonNext2
            // 
            this.buttonNext2.Location = new System.Drawing.Point(360, 374);
            this.buttonNext2.Name = "buttonNext2";
            this.buttonNext2.Size = new System.Drawing.Size(85, 28);
            this.buttonNext2.TabIndex = 0;
            this.buttonNext2.Text = "다음";
            this.buttonNext2.UseVisualStyleBackColor = true;
            this.buttonNext2.Click += new System.EventHandler(this.buttonNext2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNext2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "설문조사";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonFirst4;
        private System.Windows.Forms.RadioButton radioButtonFirst3;
        private System.Windows.Forms.RadioButton radioButtonFirst2;
        private System.Windows.Forms.RadioButton radioButtonFirst1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonFirstChecked2;
        private System.Windows.Forms.RadioButton radioButtonFirstChecked1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNext2;
    }
}