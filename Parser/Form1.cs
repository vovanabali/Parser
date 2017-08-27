using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Parser.main;
using System.IO;
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

        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Interval = (int)time.Value * 1000;
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled) start.Text = "Остановить";
            else
                start.Text = "Начать";
        }
        int i = 0;
        private async void startPars()
        {
            List<Bot> tempBot = new List<Bot>(bots.Keys);
            i++;
            this.Text += i;
            timer1.Enabled = false;
            foreach (Bot bot in tempBot)
            {
                bots[bot] = await new Parse().getItems(await new Parse().getJson(bot));
                try
                {
                    foreach (Item item in bots[bot])
                    {
                        writeInDataGrid(bot, item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPars();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            
            try
            {
                proxi = new loadAndSave().loadProxi();
                if (proxi.Count == 0) MessageBox.Show("Отсутствуют прокси сервера");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не удалось загрузить прокси сервера. Причина ошибки:\n"+ex.Message);
            }

            foreach(FileInfo file in new DirectoryInfo("Files/Bots/").GetFiles())
            {
                botsBox.Items.Add(file.Name.Split('.')[0]);
            }
            if(botsBox.Items.Count>0) botsBox.SelectedIndex = 0;

            try
            {
                FileInfo[] files = new DirectoryInfo("Files/SerchItems/").GetFiles();
                foreach(FileInfo fileName in files)
                {
                        comboBox1.Items.Add(fileName.Name.Split('.')[0]);
                }
                comboBox1.SelectedIndex = 0;
            }
            catch
            {

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

            if (viewAll.Checked)
            {
                dataGridView1.Rows.Add(name, itemName, exeption, type, site);
            }
            else
            //Если кол-во сортировок по виду оружия(Винтовки, ножи и.т.д.)
            if (check.Count == 0)
            {
                if (checkItemInSerchItems(itemName) && serchItems.Count != 0)
                    dataGridView1.Rows.Add(name, itemName, exeption, type, site);
                else
                {
                    if (serchItems.Count == 0) dataGridView1.Rows.Add(name, itemName, exeption, type, site);
                }
            }
            else
            {
                if (check.Contains(type) && checkItemInSerchItems(itemName) && serchItems.Count != 0)
                    dataGridView1.Rows.Add(name, itemName, exeption, type, site);
                else
                    if (serchItems.Count == 0) dataGridView1.Rows.Add(name, itemName, exeption, type, site);
            }
        }

        private bool checkItemInSerchItems(string itemName)
        {
            bool result = false;
            foreach (string item in serchItems)
            {
                if (item.IndexOf(itemName, StringComparison.InvariantCultureIgnoreCase) > 0) result = true;
            }
            return result;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Стандартные") serchItems = new loadAndSave().loadSerchItems("Default");
            else
                serchItems = new loadAndSave().loadSerchItems(comboBox1.Text);
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (bots != null)
            {
                foreach(Bot bot in bots.Keys)
                {
                    foreach(Item item in bots[bot])
                    {
                        writeInDataGrid(bot,item);
                    }
                }
            }
        }

        private void спискиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewItems().ShowDialog();
            try
            {
                FileInfo[] files = new DirectoryInfo("Files/SerchItems/").GetFiles();
                foreach (FileInfo fileName in files)
                {
                    comboBox1.Items.Add(fileName.Name.Split('.')[0]);
                }
                if(comboBox1.Items.Count>0) comboBox1.SelectedIndex = 0;
            }
            catch
            {

            }
        }

        private void спискиБотовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewBots().ShowDialog();
            foreach (FileInfo file in new DirectoryInfo("Files/Bots/").GetFiles())
            {
                botsBox.Items.Add(file.Name.Split('.')[0]);
            }
            if (botsBox.Items.Count > 0) botsBox.SelectedIndex = 0;
        }

        private void botsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (Bot bot in new loadAndSave().loadBotFromFile(botsBox.SelectedItem.ToString()))
                {
                    bots.Add(bot, new List<Item>());
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Не удалось загрузить список ботов");
            }
        }
    }
}
