namespace Лабораторная_работа__2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.разделыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСИзображениямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текстовыйРедакторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.построениеГрафиковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.разделыToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1104, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // разделыToolStripMenuItem
            // 
            this.разделыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСИзображениямиToolStripMenuItem,
            this.текстовыйРедакторToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.построениеГрафиковToolStripMenuItem});
            this.разделыToolStripMenuItem.Name = "разделыToolStripMenuItem";
            this.разделыToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.разделыToolStripMenuItem.Text = "Разделы";
            // 
            // работаСИзображениямиToolStripMenuItem
            // 
            this.работаСИзображениямиToolStripMenuItem.Name = "работаСИзображениямиToolStripMenuItem";
            this.работаСИзображениямиToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.работаСИзображениямиToolStripMenuItem.Text = "Работа с изображениями";
            this.работаСИзображениямиToolStripMenuItem.Click += new System.EventHandler(this.работаСИзображениямиToolStripMenuItem_Click);
            // 
            // текстовыйРедакторToolStripMenuItem
            // 
            this.текстовыйРедакторToolStripMenuItem.Name = "текстовыйРедакторToolStripMenuItem";
            this.текстовыйРедакторToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.текстовыйРедакторToolStripMenuItem.Text = "Текстовый редактор";
            this.текстовыйРедакторToolStripMenuItem.Click += new System.EventHandler(this.текстовыйРедакторToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // построениеГрафиковToolStripMenuItem
            // 
            this.построениеГрафиковToolStripMenuItem.Name = "построениеГрафиковToolStripMenuItem";
            this.построениеГрафиковToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.построениеГрафиковToolStripMenuItem.Text = "Построение графиков";
            this.построениеГрафиковToolStripMenuItem.Click += new System.EventHandler(this.построениеГрафиковToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 347);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "mainForm";
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem разделыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСИзображениямиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текстовыйРедакторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem построениеГрафиковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

