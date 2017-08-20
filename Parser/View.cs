using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parser
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                mainForm.serchItems.Add(dataGridView1[0, i].Value.ToString());
            }
        }

        private void View_Load(object sender, EventArgs e)
        {
            foreach(string s in mainForm.serchItems)
            {
                dataGridView1.Rows.Add(s);
            }
        }
    }
}
