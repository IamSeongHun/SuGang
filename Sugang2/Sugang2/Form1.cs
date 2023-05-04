using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

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
            if(textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0 )
                {
                    MessageBox.Show("빈칸을 채워주세요.");

                    return;
                }
            ListViewItem item_temp = new ListViewItem();
            item_temp.Text = textBox1.Text;

            item_temp.SubItems.Add(textBox2.Text);
            item_temp.SubItems.Add(textBox3.Text);
            item_temp.SubItems.Add(textBox4.Text);
            int sum = int.Parse(textBox3.Text) + int.Parse(textBox4.Text);
            item_temp.SubItems.Add(sum.ToString());
            //item_temp.SubItems.Add(textBox6.Text);




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

            //listView1.SelectedItems[0].SubItems[5].Text = textBox6.Text;



            textBox1.Clear();

            textBox2.Clear();

            textBox3.Clear();

            textBox4.Clear();

           // textBox6.Clear();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
               // textBox6.Text = listView1.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Removes the first item in the list.
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            for (int i = 0; i < 1000; i++)
            {
                ListViewItem item_temp = new ListViewItem();

                int a = rand.Next(1000);//0~4


                item_temp.Text = a.ToString();

                item_temp.SubItems.Add(a.ToString());
                item_temp.SubItems.Add(a.ToString());
                item_temp.SubItems.Add(a.ToString());
                int sum = a + a;
                item_temp.SubItems.Add(sum.ToString());
               // item_temp.SubItems.Add(a.ToString());

                listView1.Items.Add(item_temp);


            }




        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (listView1.Sorting == SortOrder.Ascending)
            {
                listView1.Sorting = SortOrder.Descending;
            }
            else
            {
                listView1.Sorting = SortOrder.Ascending;
            }

            listView1.ListViewItemSorter = new Sorter();      // * 1
            Sorter s = (Sorter)listView1.ListViewItemSorter;
            s.Order = listView1.Sorting;
            s.Column = e.Column;
            listView1.Sort();
        }
        class Sorter : System.Collections.IComparer
        {
            public int Column = 0;
            public System.Windows.Forms.SortOrder Order = SortOrder.Ascending;
            public int Compare(object x, object y) // IComparer Member
            {
                if (!(x is ListViewItem))
                    return (0);
                if (!(y is ListViewItem))
                    return (0);

                ListViewItem l1 = (ListViewItem)x;
                ListViewItem l2 = (ListViewItem)y;

                if (l1.ListView.Columns[Column].Tag == null)
                {
                    l1.ListView.Columns[Column].Tag = "Text";
                }

                if (l1.ListView.Columns[Column].Tag.ToString() == "Numeric")
                {

                    string str1 = l1.SubItems[Column].Text;
                    string str2 = l2.SubItems[Column].Text;

                    if (str1 == "")
                    {
                        str1 = "99999";
                    }
                    if (str2 == "")
                    {
                        str2 = "99999";
                    }

                    float fl1 = float.Parse(str1);
                    float fl2 = float.Parse(str2);

                    if (Order == SortOrder.Ascending)
                    {
                        return fl1.CompareTo(fl2);
                    }
                    else
                    {
                        return fl2.CompareTo(fl1);
                    }
                }
                else
                {
                    string str1 = l1.SubItems[Column].Text;
                    string str2 = l2.SubItems[Column].Text;

                    if (str1 == "")
                    {
                        str1 = "99999";
                    }
                    if (str2 == "")
                    {
                        str2 = "99999";
                    }

                    float fl1 = float.Parse(str1);
                    float fl2 = float.Parse(str2);

                    if (Order == SortOrder.Ascending)
                    {
                        return fl1.CompareTo(fl2);
                    }
                    else
                    {
                        return fl2.CompareTo(fl1);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.Sorting == SortOrder.Ascending)
            {
                listView1.Sorting = SortOrder.Descending;
            }
            else
            {
                listView1.Sorting = SortOrder.Descending;
            }

            listView1.ListViewItemSorter = new Sorter();      // * 1
            Sorter s = (Sorter)listView1.ListViewItemSorter;
            s.Order = listView1.Sorting;
            s.Column = 4;
            listView1.Sort();

            // ListViewItem item_temp = new ListViewItem();

            int count = listView1.Items.Count;
            //int number = 0;
            for(int i =0;i<count;i++)
            {
               // number++;
                listView1.Items[i].SubItems.Add((i+1).ToString());

            }





            //  listView1.Items.Add(item_temp);

            //MessageBox.Show(listView1.Items[0].SubItems[4].Text);

        }
    
    }
}