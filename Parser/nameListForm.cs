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
    public partial class nameListForm : Form
    {
        string nameForm;
        public nameListForm(string nameForm)
        {
            InitializeComponent();
            this.nameForm = nameForm;
        }

        bool except; char[] fileNameException = { '\'', '/', ':', '*', '?', '"', '<', '>', '|' };
        private void button1_Click(object sender, EventArgs e)
        {
            switch (nameForm)
            {
                case "list": viewListsItems(); break;
                case "bot": viewListBots(); break;
            }
        }

        private void nameListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (except) { e.Cancel = true; except = false; }
        }

        private void viewListsItems()
        {
            except = false;
            string exception = "Имя не может содержать : ";
            foreach (char c in fileNameException)
            {
                if (textBox1.Text.Contains(c))
                {
                    except = true;
                    if (exception.Length > 25) exception += ", ";
                    exception += c;
                }
            }
            exception += " ;";
            string exFileName = "";

            if (new DirectoryInfo("Files/SerchItems/").GetFiles().Contains(new FileInfo(label1.Text + ".dat")))
            {
                except = true;
                exFileName = "Такой список уже существует";
            }
            if (except) MessageBox.Show(exception + " " + exFileName);
            else
                ViewItems.nameTemp = textBox1.Text;
        }

        private void viewListBots()
        {
            except = false;
            string exception = "Имя не может содержать : ";
            foreach (char c in fileNameException)
            {
                if (textBox1.Text.Contains(c))
                {
                    except = true;
                    if (exception.Length > 25) exception += ", ";
                    exception += c;
                }
            }
            exception += " ;";
            string exFileName = "";

            if (new DirectoryInfo("Files/Bots/").GetFiles().Contains(new FileInfo(label1.Text + ".dat")))
            {
                except = true;
                exFileName = "Такой список уже существует";
            }
            if (except) MessageBox.Show(exception + " " + exFileName);
            else
                ViewBots.nameTemp = textBox1.Text;
        }
    }
}
