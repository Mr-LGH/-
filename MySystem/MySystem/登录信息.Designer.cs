namespace MySystem
{
    partial class SLoginMag
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSno = new System.Windows.Forms.Label();
            this.lblSPwd = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "账  号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "密  码：";
            // 
            // btnReplace
            // 
            this.btnReplace.BackColor = System.Drawing.Color.Pink;
            this.btnReplace.Location = new System.Drawing.Point(24, 277);
            this.btnReplace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(136, 41);
            this.btnReplace.TabIndex = 3;
            this.btnReplace.Text = "修改密码";
            this.btnReplace.UseVisualStyleBackColor = false;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Pink;
            this.btnCancel.Location = new System.Drawing.Point(252, 277);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 41);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSno
            // 
            this.lblSno.AutoSize = true;
            this.lblSno.Location = new System.Drawing.Point(130, 58);
            this.lblSno.Name = "lblSno";
            this.lblSno.Size = new System.Drawing.Size(19, 19);
            this.lblSno.TabIndex = 5;
            this.lblSno.Text = " ";
            // 
            // lblSPwd
            // 
            this.lblSPwd.AutoSize = true;
            this.lblSPwd.Location = new System.Drawing.Point(130, 132);
            this.lblSPwd.Name = "lblSPwd";
            this.lblSPwd.Size = new System.Drawing.Size(19, 19);
            this.lblSPwd.TabIndex = 6;
            this.lblSPwd.Text = " ";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(32, 199);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(104, 19);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "注册时间：";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(130, 199);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(19, 19);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = " ";
            // 
            // SLoginMag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(395, 346);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblSPwd);
            this.Controls.Add(this.lblSno);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SLoginMag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录信息";
            this.Load += new System.EventHandler(this.SLoginMag_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSno;
        private System.Windows.Forms.Label lblSPwd;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblTime;
    }
}