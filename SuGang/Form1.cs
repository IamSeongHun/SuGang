namespace SuGang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            string[] str = selectedValue.Split(' ');

            ListViewItem item_temp = new ListViewItem();
            item_temp.Text = textBox1.Text;

            item_temp.SubItems.Add(str[0]);
            item_temp.SubItems.Add(str[1]);
            item_temp.SubItems.Add("3");



            listView1.Items.Add(item_temp);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}