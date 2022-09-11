namespace AlbionApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.создатьЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаПредметовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаКрафтовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.крафтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.крафтToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.историяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.счётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьЭлементToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // создатьЭлементToolStripMenuItem
            // 
            this.создатьЭлементToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.создатьЭлементToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.предметToolStripMenuItem,
            this.крафтToolStripMenuItem,
            this.историяToolStripMenuItem,
            this.счётToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.создатьЭлементToolStripMenuItem.Name = "создатьЭлементToolStripMenuItem";
            this.создатьЭлементToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.создатьЭлементToolStripMenuItem.Text = "Файл";
            // 
            // предметToolStripMenuItem
            // 
            this.предметToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицаПредметовToolStripMenuItem,
            this.таблицаКрафтовToolStripMenuItem});
            this.предметToolStripMenuItem.Name = "предметToolStripMenuItem";
            this.предметToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.предметToolStripMenuItem.Text = "Открыть";
            // 
            // таблицаПредметовToolStripMenuItem
            // 
            this.таблицаПредметовToolStripMenuItem.Name = "таблицаПредметовToolStripMenuItem";
            this.таблицаПредметовToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.таблицаПредметовToolStripMenuItem.Text = "Таблица предметов";
            this.таблицаПредметовToolStripMenuItem.Click += new System.EventHandler(this.таблицаПредметовToolStripMenuItem_Click);
            // 
            // таблицаКрафтовToolStripMenuItem
            // 
            this.таблицаКрафтовToolStripMenuItem.Name = "таблицаКрафтовToolStripMenuItem";
            this.таблицаКрафтовToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.таблицаКрафтовToolStripMenuItem.Text = "Таблица крафтов";
            this.таблицаКрафтовToolStripMenuItem.Click += new System.EventHandler(this.таблицаКрафтовToolStripMenuItem_Click);
            // 
            // крафтToolStripMenuItem
            // 
            this.крафтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.предметToolStripMenuItem1,
            this.крафтToolStripMenuItem1});
            this.крафтToolStripMenuItem.Name = "крафтToolStripMenuItem";
            this.крафтToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.крафтToolStripMenuItem.Text = "Добавить";
            // 
            // предметToolStripMenuItem1
            // 
            this.предметToolStripMenuItem1.Name = "предметToolStripMenuItem1";
            this.предметToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.предметToolStripMenuItem1.Text = "Предмет";
            this.предметToolStripMenuItem1.Click += new System.EventHandler(this.предметToolStripMenuItem1_Click);
            // 
            // крафтToolStripMenuItem1
            // 
            this.крафтToolStripMenuItem1.Name = "крафтToolStripMenuItem1";
            this.крафтToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.крафтToolStripMenuItem1.Text = "Крафт";
            this.крафтToolStripMenuItem1.Click += new System.EventHandler(this.крафтToolStripMenuItem1_Click);
            // 
            // историяToolStripMenuItem
            // 
            this.историяToolStripMenuItem.Name = "историяToolStripMenuItem";
            this.историяToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.историяToolStripMenuItem.Text = "История";
            this.историяToolStripMenuItem.Click += new System.EventHandler(this.историяToolStripMenuItem_Click);
            // 
            // счётToolStripMenuItem
            // 
            this.счётToolStripMenuItem.Name = "счётToolStripMenuItem";
            this.счётToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.счётToolStripMenuItem.Text = "Счёт";
            this.счётToolStripMenuItem.Click += new System.EventHandler(this.счётToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(484, 307);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 48);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 331);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "For Cen9I";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьЭлементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem крафтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem предметToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem крафтToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem таблицаПредметовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаКрафтовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem счётToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяToolStripMenuItem;
    }
}

