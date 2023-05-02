namespace SuGang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.학번 = new System.Windows.Forms.ColumnHeader();
            this.과목코드 = new System.Windows.Forms.ColumnHeader();
            this.과목명 = new System.Windows.Forms.ColumnHeader();
            this.학점 = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "수강신청";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(595, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "학번";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "sw-001 데이터베이스개론 ",
            "sw-002 응용소프트웨어설계 ",
            "sw-003 프로그래밍언어1 ",
            "sw-004 프로그래밍언어2 "});
            this.comboBox1.Location = new System.Drawing.Point(660, 192);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(314, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(660, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 27);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 67);
            this.button1.TabIndex = 4;
            this.button1.Text = "입력";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.학번,
            this.과목코드,
            this.과목명,
            this.학점});
            this.listView1.Location = new System.Drawing.Point(26, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(514, 358);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // 학번
            // 
            this.학번.Text = "학번";
            this.학번.Width = 130;
            // 
            // 과목코드
            // 
            this.과목코드.Text = "과목코드";
            this.과목코드.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.과목코드.Width = 120;
            // 
            // 과목명
            // 
            this.과목명.Text = "과목명";
            this.과목명.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.과목명.Width = 170;
            // 
            // 학점
            // 
            this.학점.Text = "학점";
            this.학점.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.학점.Width = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(595, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "과목";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button1;
        private ListView listView1;
        private ColumnHeader 학번;
        private ColumnHeader 과목코드;
        private ColumnHeader 과목명;
        private ColumnHeader 학점;
        private Label label4;
    }
}