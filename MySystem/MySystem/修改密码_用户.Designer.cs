namespace MySystem
{
    partial class Pwd_Update
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Pwd_new = new System.Windows.Forms.TextBox();
            this.Pwd_Re_new = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pwd_old = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认新密码：";
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.Pink;
            this.btnYes.Location = new System.Drawing.Point(69, 340);
            this.btnYes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(84, 28);
            this.btnYes.TabIndex = 3;
            this.btnYes.Text = "确认";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Pink;
            this.btnCancel.Location = new System.Drawing.Point(263, 338);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 28);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Pwd_new
            // 
            this.Pwd_new.Location = new System.Drawing.Point(184, 145);
            this.Pwd_new.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pwd_new.Name = "Pwd_new";
            this.Pwd_new.PasswordChar = '*';
            this.Pwd_new.Size = new System.Drawing.Size(112, 28);
            this.Pwd_new.TabIndex = 6;
            // 
            // Pwd_Re_new
            // 
            this.Pwd_Re_new.Location = new System.Drawing.Point(184, 210);
            this.Pwd_Re_new.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pwd_Re_new.Name = "Pwd_Re_new";
            this.Pwd_Re_new.PasswordChar = '*';
            this.Pwd_Re_new.Size = new System.Drawing.Size(112, 28);
            this.Pwd_Re_new.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "旧密码：";
            // 
            // Pwd_old
            // 
            this.Pwd_old.Location = new System.Drawing.Point(184, 78);
            this.Pwd_old.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pwd_old.Name = "Pwd_old";
            this.Pwd_old.PasswordChar = '*';
            this.Pwd_old.Size = new System.Drawing.Size(112, 28);
            this.Pwd_old.TabIndex = 9;
            // 
            // Pwd_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(476, 461);
            this.Controls.Add(this.Pwd_old);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pwd_Re_new);
            this.Controls.Add(this.Pwd_new);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Pwd_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码_用户";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox Pwd_new;
        private System.Windows.Forms.TextBox Pwd_Re_new;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pwd_old;
    }
}