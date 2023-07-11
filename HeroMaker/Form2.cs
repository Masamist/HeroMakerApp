using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroMaker
{
    public partial class Form2 : Form
    {
        BindingSource bs = new BindingSource();
        public Form2()
        {
            InitializeComponent();
            bs.DataSource = HeroList.hallOfFame;
            listBox1.DataSource = bs;
            listBox1.DisplayMember = "Name";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
            } catch { }
            
        }

        private void btn_sort_AZ_Click(object sender, EventArgs e)
        {
            HeroList.hallOfFame.Sort();
            bs.ResetBindings(false);
        }

        private void btn_sort_ZA_Click(object sender, EventArgs e)
        {
            HeroList.hallOfFame.Sort();
            HeroList.hallOfFame.Reverse();
            bs.ResetBindings(false);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            HeroList.hallOfFame.Remove((Hero)listBox1.SelectedItem);
            bs.ResetBindings(false);
        }
    }
}
