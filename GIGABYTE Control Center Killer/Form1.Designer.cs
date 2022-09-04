namespace GIGABYTE_Control_Center_Killer
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
            this.components = new System.ComponentModel.Container();
            this.detectingStr = new System.Windows.Forms.Label();
            this.findStr = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.killBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // detectingStr
            // 
            this.detectingStr.AutoSize = true;
            this.detectingStr.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.detectingStr.Location = new System.Drawing.Point(24, 24);
            this.detectingStr.Margin = new System.Windows.Forms.Padding(15);
            this.detectingStr.Name = "detectingStr";
            this.detectingStr.Size = new System.Drawing.Size(176, 16);
            this.detectingStr.TabIndex = 0;
            this.detectingStr.Text = "Detecting Process...";
            // 
            // findStr
            // 
            this.findStr.AutoSize = true;
            this.findStr.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.findStr.ForeColor = System.Drawing.Color.Red;
            this.findStr.Location = new System.Drawing.Point(24, 51);
            this.findStr.Margin = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.findStr.Name = "findStr";
            this.findStr.Size = new System.Drawing.Size(72, 12);
            this.findStr.TabIndex = 1;
            this.findStr.Text = "Not Found";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(27, 94);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(80, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // killBtn
            // 
            this.killBtn.Enabled = false;
            this.killBtn.Location = new System.Drawing.Point(218, 24);
            this.killBtn.Name = "killBtn";
            this.killBtn.Size = new System.Drawing.Size(80, 93);
            this.killBtn.TabIndex = 4;
            this.killBtn.Text = "Kill";
            this.killBtn.UseVisualStyleBackColor = true;
            this.killBtn.Click += new System.EventHandler(this.killBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 139);
            this.Controls.Add(this.killBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.findStr);
            this.Controls.Add(this.detectingStr);
            this.Name = "Form1";
            this.Text = "Control Center Killer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label detectingStr;
        private System.Windows.Forms.Label findStr;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button killBtn;
        private System.Windows.Forms.Timer timer1;
    }
}

