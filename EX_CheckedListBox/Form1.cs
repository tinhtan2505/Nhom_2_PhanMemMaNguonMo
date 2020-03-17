using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_CheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            checkedListBox1.Items.Add("Công nghệ thông tin");
            checkedListBox1.Items.Add("Đại Học Vinh");
            checkedListBox1.Items.Add("Việt Nam");
            checkedListBox1.Items.Add("World");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            for (int i=0; i< checkedListBox1.Items.Count; i++)
                if (checkedListBox1.GetItemChecked(i) == true)
                    checkedListBox2.Items.Add(checkedListBox1.Items[i]);
            for (int i = checkedListBox1.Items.Count - 1; i >= 0; i--)
                if (checkedListBox1.GetItemChecked(i) == true)
                    checkedListBox1.Items.RemoveAt(i);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
                if (checkedListBox2.GetItemChecked(i) == true)
                    checkedListBox1.Items.Add(checkedListBox1.Items[i]);
            for (int i = checkedListBox2.Items.Count - 1; i >= 0; i--)
                if (checkedListBox2.GetItemChecked(i) == true)
                    checkedListBox2.Items.RemoveAt(i);
        }
    }

}
