using Parser.main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parser
{
    public partial class ViewBots : Form
    {
        public static string nameTemp;
        List<Bot> listBots;
        bool listRevork = false;
        string nameList;
        string dir = "Files/Bots/";

        public ViewBots()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (new nameListForm("bot").ShowDialog() == DialogResult.OK)
            {
                //File.Create("Files/Bots/" + nameTemp + ".dat");
                listBox1.Items.Add(nameTemp);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkReWrite())
            {
                try
                {
                    if (dataGridView1.RowCount == 1)
                    {
                        listBox1.Items.Remove(textBox1.Text);
                        File.Delete(dir + textBox1.Text);
                    }
                    listBots = new loadAndSave().loadBotFromFile(listBox1.SelectedItem.ToString());
                    loadBots();
                    nameList = listBox1.SelectedItem.ToString();
                }
                catch (NullReferenceException)
                {

                }
            }
        }

        private bool checkReWrite()
        {
            bool temp = true;
            if (listRevork)
            {
                DialogResult dialRes = MessageBox.Show("Сохранить изменения?", "Предупреждение", MessageBoxButtons.YesNoCancel);
                switch (dialRes)
                {
                    case DialogResult.Yes: save.PerformClick(); temp = true; break;
                    case DialogResult.No:
                        { 
                        temp = true;
                        if (dataGridView1.RowCount == 1)
                        {
                            listBox1.Items.Remove(textBox1.Text);
                            File.Delete(dir + textBox1.Text);
                        } } break;
                    case DialogResult.Cancel: listBox1.SelectedItem = nameList; temp = false; break;
                }
            }
            return temp;
        }

        private void loadBots()
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
            dataGridView1.Rows.Clear();
            if(listBots!=null)
            foreach(Bot bot in listBots)
            {
                dataGridView1.Rows.Add(bot.name,bot.url,bot.siteName);
                    MessageBox.Show(bot.parsURL);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Bot> tempBotsList = new List<Bot>();
            for(int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                string name = dataGridView1[0, i].Value.ToString();
                string url = dataGridView1[1, i].Value.ToString();
                string siteName = dataGridView1[2, i].Value.ToString();
                tempBotsList.Add(new Bot(name, url, siteName));
            }
            new loadAndSave().saveBots(tempBotsList,textBox1.Text);
            listRevork = false; 
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            listRevork = true;
        }

        private void ViewBots_Load(object sender, EventArgs e)
        {
            foreach (FileInfo file in new DirectoryInfo(dir).GetFiles())
            {
                listBox1.Items.Add(file.Name.Split('.')[0]);
            }
        }

        private void ViewBots_Shown(object sender, EventArgs e)
        {
            listRevork = false;
            if(listBox1.Items.Count>0) listBox1.SelectedIndex = 0;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            File.Delete(dir+textBox1.Text+".dat");
            listBox1.Items.Remove(textBox1.Text);
            if (listBox1.Items.Count > 1) listBox1.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string oldName = listBox1.SelectedItem.ToString();
            File.Move(dir+oldName+".dat",dir+textBox1.Text+".dat");

            listBox1.Items.Remove(oldName);
            listBox1.Items.Add(textBox1.Text);
            listBox1.SelectedItem = textBox1.Text;
        }
    }
}
