namespace Parser
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameBot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проксиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спискиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спискиБотовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.start = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.botsBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.viewAll = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.audioView = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.viewExteriorItem = new System.Windows.Forms.CheckBox();
            this.viewNameBot = new System.Windows.Forms.CheckBox();
            this.viewSite = new System.Windows.Forms.CheckBox();
            this.viewTypeItem = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.time)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameBot,
            this.item,
            this.exterior,
            this.typeItem,
            this.site});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(469, 465);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // nameBot
            // 
            this.nameBot.HeaderText = "Имя бота";
            this.nameBot.Name = "nameBot";
            this.nameBot.ReadOnly = true;
            // 
            // item
            // 
            this.item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.item.HeaderText = "Предмет";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            // 
            // exterior
            // 
            this.exterior.HeaderText = "Качество";
            this.exterior.Name = "exterior";
            this.exterior.ReadOnly = true;
            // 
            // typeItem
            // 
            this.typeItem.HeaderText = "Вид";
            this.typeItem.Name = "typeItem";
            this.typeItem.ReadOnly = true;
            // 
            // site
            // 
            this.site.HeaderText = "Сайт";
            this.site.Name = "site";
            this.site.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.проксиToolStripMenuItem,
            this.спискиToolStripMenuItem,
            this.спискиБотовToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(669, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // проксиToolStripMenuItem
            // 
            this.проксиToolStripMenuItem.Name = "проксиToolStripMenuItem";
            this.проксиToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.проксиToolStripMenuItem.Text = "Прокси";
            this.проксиToolStripMenuItem.Click += new System.EventHandler(this.проксиToolStripMenuItem_Click);
            // 
            // спискиToolStripMenuItem
            // 
            this.спискиToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.спискиToolStripMenuItem.Name = "спискиToolStripMenuItem";
            this.спискиToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.спискиToolStripMenuItem.Text = "Предметы";
            this.спискиToolStripMenuItem.Click += new System.EventHandler(this.спискиToolStripMenuItem_Click);
            // 
            // спискиБотовToolStripMenuItem
            // 
            this.спискиБотовToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.спискиБотовToolStripMenuItem.Name = "спискиБотовToolStripMenuItem";
            this.спискиБотовToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.спискиБотовToolStripMenuItem.Text = "Боты";
            this.спискиБотовToolStripMenuItem.Click += new System.EventHandler(this.спискиБотовToolStripMenuItem_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(117, 22);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 22);
            this.start.TabIndex = 2;
            this.start.Text = "Начать парсить";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(6, 25);
            this.time.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.time.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(105, 20);
            this.time.TabIndex = 3;
            this.time.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.botsBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.viewAll);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.time);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(474, 24);
            this.panel1.MaximumSize = new System.Drawing.Size(195, 1000);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 465);
            this.panel1.TabIndex = 4;
            // 
            // botsBox
            // 
            this.botsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.botsBox.FormattingEnabled = true;
            this.botsBox.Location = new System.Drawing.Point(6, 397);
            this.botsBox.Name = "botsBox";
            this.botsBox.Size = new System.Drawing.Size(185, 21);
            this.botsBox.TabIndex = 17;
            this.botsBox.SelectedIndexChanged += new System.EventHandler(this.botsBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Список ботов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Список предметов";
            // 
            // viewAll
            // 
            this.viewAll.AutoSize = true;
            this.viewAll.Location = new System.Drawing.Point(6, 423);
            this.viewAll.Name = "viewAll";
            this.viewAll.Size = new System.Drawing.Size(112, 30);
            this.viewAll.TabIndex = 14;
            this.viewAll.Text = "Отображать все \r\nпредметы ботов";
            this.viewAll.UseVisualStyleBackColor = true;
            this.viewAll.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 357);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ColumnWidth = 100;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Ключи",
            "Ножи",
            "Оружее",
            "Перчатки",
            "Кейсы",
            "Медали"});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 263);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(186, 75);
            this.checkedListBox1.TabIndex = 12;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.checkedListBox1.Click += new System.EventHandler(this.checkedListBox1_Click);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.audioView);
            this.groupBox2.Location = new System.Drawing.Point(6, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Включить";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 65);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(147, 30);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Отображать при новом \r\nпредмете";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(179, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Отображать поверх всех окон";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // audioView
            // 
            this.audioView.AutoSize = true;
            this.audioView.Location = new System.Drawing.Point(6, 19);
            this.audioView.Name = "audioView";
            this.audioView.Size = new System.Drawing.Size(126, 17);
            this.audioView.TabIndex = 0;
            this.audioView.Text = "Аудио уведомление";
            this.audioView.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viewExteriorItem);
            this.groupBox1.Controls.Add(this.viewNameBot);
            this.groupBox1.Controls.Add(this.viewSite);
            this.groupBox1.Controls.Add(this.viewTypeItem);
            this.groupBox1.Location = new System.Drawing.Point(6, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Показывать";
            // 
            // viewExteriorItem
            // 
            this.viewExteriorItem.AutoSize = true;
            this.viewExteriorItem.Checked = true;
            this.viewExteriorItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewExteriorItem.Location = new System.Drawing.Point(90, 19);
            this.viewExteriorItem.Name = "viewExteriorItem";
            this.viewExteriorItem.Size = new System.Drawing.Size(73, 17);
            this.viewExteriorItem.TabIndex = 6;
            this.viewExteriorItem.Text = "Качество";
            this.viewExteriorItem.UseVisualStyleBackColor = true;
            this.viewExteriorItem.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // viewNameBot
            // 
            this.viewNameBot.AutoSize = true;
            this.viewNameBot.Checked = true;
            this.viewNameBot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewNameBot.Location = new System.Drawing.Point(10, 19);
            this.viewNameBot.Name = "viewNameBot";
            this.viewNameBot.Size = new System.Drawing.Size(74, 17);
            this.viewNameBot.TabIndex = 5;
            this.viewNameBot.Text = "Имя бота";
            this.viewNameBot.UseVisualStyleBackColor = true;
            this.viewNameBot.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // viewSite
            // 
            this.viewSite.AutoSize = true;
            this.viewSite.Checked = true;
            this.viewSite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewSite.Location = new System.Drawing.Point(113, 51);
            this.viewSite.Name = "viewSite";
            this.viewSite.Size = new System.Drawing.Size(50, 17);
            this.viewSite.TabIndex = 8;
            this.viewSite.Text = "Сайт";
            this.viewSite.UseVisualStyleBackColor = true;
            this.viewSite.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // viewTypeItem
            // 
            this.viewTypeItem.AutoSize = true;
            this.viewTypeItem.Checked = true;
            this.viewTypeItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewTypeItem.Location = new System.Drawing.Point(10, 51);
            this.viewTypeItem.Name = "viewTypeItem";
            this.viewTypeItem.Size = new System.Drawing.Size(97, 17);
            this.viewTypeItem.TabIndex = 7;
            this.viewTypeItem.Text = "Вид предмета";
            this.viewTypeItem.UseVisualStyleBackColor = true;
            this.viewTypeItem.CheckedChanged += new System.EventHandler(this.viewTypeItem_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Обновлять раз в";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(469, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 465);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            this.splitter1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.splitter1_MouseDoubleClick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 489);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Parser";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.time)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.NumericUpDown time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem проксиToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox viewExteriorItem;
        private System.Windows.Forms.CheckBox viewNameBot;
        private System.Windows.Forms.CheckBox viewSite;
        private System.Windows.Forms.CheckBox viewTypeItem;
        private System.Windows.Forms.CheckBox audioView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameBot;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn exterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn site;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox viewAll;
        private System.Windows.Forms.ToolStripMenuItem спискиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спискиБотовToolStripMenuItem;
        private System.Windows.Forms.ComboBox botsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

