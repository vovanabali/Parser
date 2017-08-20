using Parser.main;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Parser
{
    partial class lostWork : Form
    {
        List<Bot> bots = new List<Bot>();

        int i;
        bool errors = false;

        public lostWork()
        {
            InitializeComponent();
        }

        private void WorkList_Load(object sender, EventArgs e)
        {
            i = 0;
            //dataGridView1.Columns[1].Width = this.Width - dataGridView1.Columns[1].Width - 20 - dataGridView1.Columns[2].Width;

            List<Bot> bots = new loadAndSave().loadfromSerFile();
            if (bots == null)
            {
                MessageBox.Show("Не удалось загрузить список ботов");
            }
            else
                foreach (Bot bot in bots)
                {
                    i++;
                    string name;
                    if (bot.name == null)
                    {
                        name = "Бот " + i;
                    }
                    else name = bot.name;
                    string url = bot.url;
                    string siteName;
                    if (bot.siteName == null)
                    {
                        siteName = "Имя сайта не узказано";
                    }
                    else siteName = bot.siteName;
                    dataGridView1.Rows.Add(name, url, siteName);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount - 1 < 1)
            {
                errors = true;
                MessageBox.Show("Нельзя добавить \"0\" строк");
            }
            for (int k = 0; k < dataGridView1.RowCount - 1; k++)
            {
                i++;
                string name;
                if (dataGridView1[0, k].Value == null)
                {
                    name = "Бот " + i;
                }
                else name = dataGridView1[0, k].Value.ToString();

                string url;
                if (dataGridView1[1, k].Value == null)
                {
                    MessageBox.Show("Поле \"Ссылка на бот\" не может быть пустой!", "Ошибка");
                    errors = true;
                    break;
                }
                else url = dataGridView1[1, k].Value.ToString();

                string siteName;
                if (dataGridView1[2, k].Value == null)
                {
                    siteName = "Имя сайта не узказано";
                }
                else siteName = dataGridView1[2, k].Value.ToString();

                Bot bot = new Bot(name, url, siteName);
                //MessageBox.Show(dataGridView1[2, k].Value.ToString());
                bots.Add(bot);
            }
            if (!errors)
            {
                new loadAndSave().saveBots(bots);
            }
        }

        public Dictionary<Bot, List<Item>> getInfo()
        {
            Dictionary<Bot, List<Item>> botsTemp = new Dictionary<Bot, List<Item>>();
            foreach(Bot bot in bots)
            {
                botsTemp.Add(bot, null);
            }
            return botsTemp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                i = 0;
                textBox1.Text = openFileDialog1.FileName;
                var bots = new loadAndSave().loadBotsFromFile(openFileDialog1.FileName);
                dataGridView1.Rows.Clear();
                foreach (var bot in bots)
                {
                    i++;
                    string name;
                    if (bot.name == null)
                    {
                        name = "Бот " + i;
                    }
                    else name = bot.name;
                    string url = bot.url;
                    string siteName;
                    if (bot.siteName == null)
                    {
                        siteName = "Имя сайта не узказано";
                    }
                    else siteName = bot.siteName;
                    dataGridView1.Rows.Add(name, url, siteName);
                }
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
        }

        private void lostWork_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (errors) e.Cancel = true;
            errors = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i = 0;
            textBox1.Text = openFileDialog1.FileName;
            var bots = new loadAndSave().loadfromSerFile();
            dataGridView1.Rows.Clear();
            foreach (var bot in bots)
            {
                i++;
                string name;
                if (bot.name == null)
                {
                    name = "Бот " + i;
                }
                else name = bot.name;
                string url = bot.url;
                string siteName;
                if (bot.siteName == null)
                {
                    siteName = "Имя сайта не узказано";
                }
                else siteName = bot.siteName;
                dataGridView1.Rows.Add(name, url, siteName);
            }
        }
    }
}
