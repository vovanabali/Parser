using Parser.main;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Parser
{
    public partial class ProxiForm : Form
    {
        private bool valueCheng = false;
        public ProxiForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 2)
            {
                MessageBox.Show("Если не добавить прокси то запросы будут блокироваться");
            }
            List<string> proxi = new List<string>();
            for(int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                proxi.Add(dataGridView1[0, i].Value.ToString());
            }
            mainForm.proxi = proxi;
            new loadAndSave().saveProxi(proxi);
        }

        private void ProxiForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Width = dataGridView1.Width - 43;
            var proxiList = new loadAndSave().loadProxi();
            if(proxiList!=null)
            foreach(string item in proxiList)
            {
                dataGridView1.Rows.Add(item);
            }
        }

        private void ProxiForm_Resize(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Width = dataGridView1.Width - 43;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                var proxiList = new loadAndSave().loadProxi(openFileDialog1.FileName);
                dataGridView1.Rows.Clear();
                if (proxiList != null)
                    foreach (string item in proxiList)
                    {
                        dataGridView1.Rows.Add(item);
                    }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach(string proxi in mainForm.proxi)
            {
                dataGridView1.Rows.Add(proxi);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            valueCheng = true;
        }

        private void ProxiForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (valueCheng)
            {
                DialogResult result =  MessageBox.Show("Вы хотите сохранить изменения?", "Предупреждение",MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes:
                        button2.PerformClick();
                        break;
                    case DialogResult.No: break;
                    case DialogResult.Cancel: e.Cancel = true; break;
                }
            }
        }

        private void ProxiForm_Shown(object sender, EventArgs e)
        {
            valueCheng = false;
        }
    }
}
