namespace MySystem
{
    partial class Research_Msg_Display
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.txtMag = new System.Windows.Forms.TextBox();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.txtCno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Search_select = new System.Windows.Forms.ComboBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.txtMag);
            this.groupBox4.Controls.Add(this.txtCname);
            this.groupBox4.Controls.Add(this.txtCno);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(54, 184);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(685, 306);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "教研室信息";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtInfo);
            this.groupBox6.Location = new System.Drawing.Point(344, 29);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(276, 250);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "研究方向";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(18, 30);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(240, 208);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.Text = "";
            // 
            // txtMag
            // 
            this.txtMag.Location = new System.Drawing.Point(164, 218);
            this.txtMag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMag.Name = "txtMag";
            this.txtMag.ReadOnly = true;
            this.txtMag.Size = new System.Drawing.Size(112, 28);
            this.txtMag.TabIndex = 19;
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(164, 144);
            this.txtCname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCname.Name = "txtCname";
            this.txtCname.ReadOnly = true;
            this.txtCname.Size = new System.Drawing.Size(112, 28);
            this.txtCname.TabIndex = 18;
            // 
            // txtCno
            // 
            this.txtCno.Location = new System.Drawing.Point(164, 76);
            this.txtCno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCno.Name = "txtCno";
            this.txtCno.ReadOnly = true;
            this.txtCno.Size = new System.Drawing.Size(112, 28);
            this.txtCno.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "教研室主任：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "编号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "教研室：";
            // 
            // Search_select
            // 
            this.Search_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Search_select.FormattingEnabled = true;
            this.Search_select.Location = new System.Drawing.Point(218, 92);
            this.Search_select.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Search_select.Name = "Search_select";
            this.Search_select.Size = new System.Drawing.Size(136, 26);
            this.Search_select.TabIndex = 21;
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Pink;
            this.btnDisplay.Location = new System.Drawing.Point(440, 92);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(84, 28);
            this.btnDisplay.TabIndex = 30;
            this.btnDisplay.Text = "查询";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // Research_Msg_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(804, 553);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.Search_select);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Research_Msg_Display";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教研室信息_教学资源";
            this.Load += new System.EventHandler(this.教研室信息_教学资源_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox txtInfo;
        private System.Windows.Forms.TextBox txtMag;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.TextBox txtCno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Search_select;
        private System.Windows.Forms.Button btnDisplay;
    }
}