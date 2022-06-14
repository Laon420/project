namespace Project1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label_birth = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.radioButtonSex1 = new System.Windows.Forms.RadioButton();
            this.radioButtonSex2 = new System.Windows.Forms.RadioButton();
            this.buttonNext = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSex2);
            this.groupBox1.Controls.Add(this.radioButtonSex1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label_birth);
            this.groupBox1.Controls.Add(this.label_name);
            this.groupBox1.Location = new System.Drawing.Point(98, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "개인정보";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(245, 119);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(245, 58);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 21);
            this.textBoxName.TabIndex = 2;
            // 
            // label_birth
            // 
            this.label_birth.AutoSize = true;
            this.label_birth.Location = new System.Drawing.Point(139, 125);
            this.label_birth.Name = "label_birth";
            this.label_birth.Size = new System.Drawing.Size(53, 12);
            this.label_birth.TabIndex = 1;
            this.label_birth.Text = "생년월일";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(148, 61);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(29, 12);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "이름";
            // 
            // radioButtonSex1
            // 
            this.radioButtonSex1.AutoSize = true;
            this.radioButtonSex1.Location = new System.Drawing.Point(197, 171);
            this.radioButtonSex1.Name = "radioButtonSex1";
            this.radioButtonSex1.Size = new System.Drawing.Size(35, 16);
            this.radioButtonSex1.TabIndex = 4;
            this.radioButtonSex1.TabStop = true;
            this.radioButtonSex1.Text = "남";
            this.radioButtonSex1.UseVisualStyleBackColor = true;
            // 
            // radioButtonSex2
            // 
            this.radioButtonSex2.AutoSize = true;
            this.radioButtonSex2.Location = new System.Drawing.Point(374, 171);
            this.radioButtonSex2.Name = "radioButtonSex2";
            this.radioButtonSex2.Size = new System.Drawing.Size(35, 16);
            this.radioButtonSex2.TabIndex = 5;
            this.radioButtonSex2.TabStop = true;
            this.radioButtonSex2.Text = "여";
            this.radioButtonSex2.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(343, 358);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(104, 23);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "시작";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "설문조사";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label_birth;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.RadioButton radioButtonSex2;
        private System.Windows.Forms.RadioButton radioButtonSex1;
        private System.Windows.Forms.Button buttonNext;
    }
}

