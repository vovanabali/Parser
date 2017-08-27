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
    public partial class ViewItems : Form
    {
        public static string nameTemp;
        string dir = "Files/SerchItems/";
        bool listRevork = false;
        string nameList;
        List<string> listItems;
        public ViewItems()
        {
            InitializeComponent();
        }

        private void ViewItems_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (FileInfo file in new DirectoryInfo(dir).GetFiles())
            {
                listBox1.Items.Add(file.Name.Split('.')[0]);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (new nameListForm("list").ShowDialog() == DialogResult.OK)
            {
                //File.Create("Files/Bots/" + nameTemp + ".dat");
                listBox1.Items.Add(nameTemp);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
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
                    case DialogResult.Yes: saveButton.PerformClick(); temp = true; break;
                    case DialogResult.No:
                        {
                            temp = true;
                            if (dataGridView1.RowCount == 1)
                            {
                                listBox1.Items.Remove(textBox1.Text);
                                File.Delete(dir + textBox1.Text);
                            }
                        }
                        break;
                    case DialogResult.Cancel: listBox1.SelectedItem = nameList; temp = false; break;
                }
            }
            return temp;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            listRevork = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            File.Delete(dir + textBox1.Text + ".dat");
            listBox1.Items.Remove(textBox1.Text);
            if (listBox1.Items.Count > 1) listBox1.SelectedIndex = 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            List<string> tempItems = new List<string>();
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                string name = dataGridView1[0, i].Value.ToString();
                tempItems.Add(name);
            }
            new loadAndSave().saveSerchItems(tempItems,textBox1.Text);
            listRevork = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkReWrite())
            {
                try
                {
                    if (dataGridView1.RowCount == 1)
                    {
                        deleteButton.PerformClick();
                    }
                    listItems = new loadAndSave().loadSerchItems(listBox1.SelectedItem.ToString());
                    loadItems();
                    nameList = listBox1.SelectedItem.ToString();
                }
                catch (NullReferenceException)
                {

                }
            }
        }

        private void loadItems()
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
            dataGridView1.Rows.Clear();
            if(listItems!=null)
            foreach(string item in listItems)
            {
                dataGridView1.Rows.Add(item);
            }
        }

        private void ViewItems_Shown(object sender, EventArgs e)
        {
            listRevork = false;
            if (listBox1.Items.Count > 0) listBox1.SelectedIndex = 0;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string oldName = listBox1.SelectedItem.ToString();
            File.Move(dir + oldName + ".dat", dir + textBox1.Text + ".dat");

            listBox1.Items.Remove(oldName);
            listBox1.Items.Add(textBox1.Text);
            listBox1.SelectedItem = textBox1.Text;
        }
    }
}
