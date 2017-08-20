using System;
using System.Windows.Forms;
using System.Net;
using xNet;
using System.Collections.Generic;
using Parser.main;
using System.IO;
using Newtonsoft.Json;
using Parser.main.BotClasses;
using System.Media;

namespace Parser
{
    public partial class mainForm : Form
    {
        Dictionary<Bot, List<Item>> bots = new Dictionary<Bot, List<Item>>();

        public static List<string> proxi = new List<string>();

        List<string> check = new List<string>();
        public static List<string> serchItems = new List<string>();

        public mainForm()
        {
            InitializeComponent();
        }

        private void изменитьСписокБотовToolStripMenuItem_Click(object sender, EventArgs e)
        {
                lostWork botsForm = new lostWork();
                if (botsForm.ShowDialog() == DialogResult.OK)
                {
                    bots = botsForm.getInfo();
                }
        }

        private async void start_Click(object sender, EventArgs e)
        {
            if (proxi.Count == 0) MessageBox.Show("Отсутствуют прокси сервера");
            List<Bot> tempBot = new List<Bot>(bots.Keys);
            foreach (Bot bot in tempBot)
            {
                bots[bot] = await new Parse().getItems(await new Parse().getJson(bot));
                //label2.Text = bots[bot].Count.ToString();
                try
                {
                    foreach (Item item in bots[bot])
                    {
                        writeInDataGrid(bot,item);                   
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (Bot bot in new loadAndSave().loadfromSerFile())
                {
                    bots.Add(bot, new List<Item>());
                }
                proxi = new loadAndSave().loadProxi();
            }
            catch(System.NullReferenceException)
            {
                MessageBox.Show("Не удалось загрузить список ботов");
            }
        }

        private void проксиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProxiForm().ShowDialog();
        }

        private void списокБотовToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void splitter1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (panel1.Width == 0) panel1.Width = 300;
            else panel1.Width = 0;
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitter1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void неПоказыватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new View().ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (viewNameBot.Checked)
            {
                dataGridView1.Columns["nameBot"].Visible = true;
            }
            else
            {
                dataGridView1.Columns["nameBot"].Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (viewExteriorItem.Checked)
            {
                dataGridView1.Columns["exterior"].Visible = true;
            }
            else
            {
                dataGridView1.Columns["exterior"].Visible = false;
            }
        }

        private void viewTypeItem_CheckedChanged(object sender, EventArgs e)
        {
            if (viewTypeItem.Checked)
            {
                dataGridView1.Columns["typeItem"].Visible = true;
            }
            else
            {
                dataGridView1.Columns["typeItem"].Visible = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (viewSite.Checked)
            {
                dataGridView1.Columns["site"].Visible = true;
            }
            else
            {
                dataGridView1.Columns["site"].Visible = false;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            check.Clear(); dataGridView1.Rows.Clear();
            foreach (string item in checkedListBox1.CheckedItems)
            {
                check.Add(EngName(item));
            }
            check.Add(checkedListBox1.SelectedItem.ToString());

            foreach (Bot bot in bots.Keys)
            {
                try
                {
                    foreach (Item item in bots[bot])
                    {
                        writeInDataGrid(bot,item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        static string EngName(string ru)
        {
            string en = "";
            switch (ru)
            {
                case "Оружее": en = "Rifle"; break;
                case "Ключи": en = "Key"; break;
                case "Ножи": en = "Knife"; break;
                case "Перчатки": en = "Gloves"; break;
                case "Кейсы": en = "Container"; break;
                case "Медали": en = "Collectible"; break;
            }
            return en;
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }

        private void checkedListBox1_Click(object sender, EventArgs e)
        {

        }

        public void writeInDataGrid(Bot bot,Item item)
        {
            string name = bot.name;
            string itemName = item.name;
            string exeption = item.exterior;
            string type = item.type;
            string site = bot.siteName;
            if (check.Count == 0)
            {
                if (serchItems.Contains(itemName) && serchItems.Count != 0) dataGridView1.Rows.Add(name, itemName, exeption, type, site);
                else
                {
                    if (serchItems.Count == 0) dataGridView1.Rows.Add(name, itemName, exeption, type, site);
                }
            }
            else
            {
                if (check.Contains(type) && serchItems.Contains(itemName) && serchItems.Count != 0)
                    dataGridView1.Rows.Add(name, itemName, exeption, type, site);
                else
                    if (serchItems.Count == 0) dataGridView1.Rows.Add(name, itemName, exeption, type, site);
            }
        }
        SoundPlayer sound = new SoundPlayer(Properties.Settings.Default.soundName);
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (audioView.Checked)
            {
                sound.Load();
                sound.Play();
            }
            if (checkBox2.Checked)
            {
                this.TopMost = true;
                this.TopMost = false;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked) this.TopMost = true;
            else this.TopMost = false;
        }
    }
}
