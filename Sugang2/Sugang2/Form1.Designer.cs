namespace Sugang2
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 112);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 0;
            label1.Text = "번호";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(79, 141);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 141);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 2;
            label2.Text = "이름";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(79, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(189, 23);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 171);
            label3.Name = "label3";
            label3.Size = new Size(42, 21);
            label3.TabIndex = 4;
            label3.Text = "중간";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(79, 200);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(189, 23);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(19, 200);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 6;
            label4.Text = "기말";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(19, 231);
            label5.Name = "label5";
            label5.Size = new Size(42, 21);
            label5.TabIndex = 8;
            label5.Text = "합계";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(79, 258);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(189, 23);
            textBox6.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(19, 258);
            label6.Name = "label6";
            label6.Size = new Size(42, 21);
            label6.TabIndex = 10;
            label6.Text = "순위";
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(300, 112);
            button1.Name = "button1";
            button1.Size = new Size(97, 36);
            button1.TabIndex = 12;
            button1.Text = "자료입력";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(300, 154);
            button2.Name = "button2";
            button2.Size = new Size(97, 36);
            button2.TabIndex = 12;
            button2.Text = "자료수정";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(300, 196);
            button3.Name = "button3";
            button3.Size = new Size(97, 36);
            button3.TabIndex = 12;
            button3.Text = "자료삭제";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(300, 238);
            button4.Name = "button4";
            button4.Size = new Size(97, 36);
            button4.TabIndex = 12;
            button4.Text = "자료";
            button4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(414, 54);
            listView1.Name = "listView1";
            listView1.Size = new Size(493, 285);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "번호";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "이름";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "중간";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "기말";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "합계";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "순위";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("맑은 고딕", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(19, 9);
            label7.Name = "label7";
            label7.Size = new Size(183, 50);
            label7.TabIndex = 14;
            label7.Text = "성적 입력";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(109, 232);
            label8.Name = "label8";
            label8.Size = new Size(128, 21);
            label8.TabIndex = 8;
            label8.Text = "자동으로 입력됨";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 351);
            Controls.Add(label7);
            Controls.Add(listView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label7;
        private Label label8;
    }
}