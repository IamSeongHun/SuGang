namespace Sugang2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //   string selectedValue = comboBox1.SelectedItem.ToString();
            // string[] str = selectedValue.Split(' ');

            ListViewItem item_temp = new ListViewItem();
            item_temp.Text = textBox1.Text;

            item_temp.SubItems.Add(textBox2.Text);
            item_temp.SubItems.Add(textBox3.Text);
            item_temp.SubItems.Add(textBox4.Text);
            int sum = int.Parse(textBox3.Text) + int.Parse(textBox4.Text);
            item_temp.SubItems.Add(sum.ToString());
            item_temp.SubItems.Add(textBox6.Text);




            listView1.Items.Add(item_temp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0)

            {

                MessageBox.Show("수정할 위치를 선택해 주세요");

                return;

            }

            // 1개만 선택하기 때문에 SelectedItems[0] 항상 [0] 이다.

            listView1.SelectedItems[0].SubItems[0].Text = textBox1.Text;

            listView1.SelectedItems[0].SubItems[1].Text = textBox2.Text;

            listView1.SelectedItems[0].SubItems[2].Text = textBox3.Text;

            listView1.SelectedItems[0].SubItems[3].Text = textBox4.Text;

            int sum = int.Parse(textBox3.Text) + int.Parse(textBox4.Text);

            listView1.SelectedItems[0].SubItems[4].Text = sum.ToString();

            listView1.SelectedItems[0].SubItems[5].Text = textBox6.Text;



            textBox1.Clear();

            textBox2.Clear();

            textBox3.Clear();

            textBox4.Clear();

            textBox6.Clear();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
                textBox6.Text = listView1.SelectedItems[0].SubItems[5].Text;
            }
        }
    }
}