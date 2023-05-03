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
            label1 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            listView1 = new ListView();
            학번 = new ColumnHeader();
            과목코드 = new ColumnHeader();
            과목명 = new ColumnHeader();
            학점 = new ColumnHeader();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 32);
            label1.TabIndex = 1;
            label1.Text = "수강신청";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(513, 84);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 1;
            label3.Text = "학번";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "sw-001 데이터베이스개론 ", "sw-002 응용소프트웨어설계 ", "sw-003 프로그래밍언어1 ", "sw-004 프로그래밍언어2 " });
            comboBox1.Location = new Point(567, 139);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(245, 23);
            comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(567, 84);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 23);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(568, 245);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(244, 50);
            button1.TabIndex = 4;
            button1.Text = "입력";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { 학번, 과목코드, 과목명, 학점 });
            listView1.Location = new Point(20, 60);
            listView1.Margin = new Padding(2, 2, 2, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(474, 270);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // 학번
            // 
            학번.Text = "학번";
            학번.Width = 130;
            // 
            // 과목코드
            // 
            과목코드.Text = "과목코드";
            과목코드.TextAlign = HorizontalAlignment.Center;
            과목코드.Width = 120;
            // 
            // 과목명
            // 
            과목명.Text = "과목명";
            과목명.TextAlign = HorizontalAlignment.Center;
            과목명.Width = 170;
            // 
            // 학점
            // 
            학점.Text = "학점";
            학점.TextAlign = HorizontalAlignment.Center;
            학점.Width = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(513, 139);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 1;
            label4.Text = "과목";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 338);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
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