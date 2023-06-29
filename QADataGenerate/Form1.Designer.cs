
namespace RuNerDataGenerate
{
    partial class Form1
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
            this.context = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.qs = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delQ = new System.Windows.Forms.Button();
            this.addQ = new System.Windows.Forms.Button();
            this.listQA = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьТекстыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьСущностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save_dataset_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьДатасетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RunRuNers = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.NER_lbl_ = new System.Windows.Forms.ToolStripStatusLabel();
            this.ner_name_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // context
            // 
            this.context.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.context.Location = new System.Drawing.Point(5, 67);
            this.context.Name = "context";
            this.context.ReadOnly = true;
            this.context.Size = new System.Drawing.Size(554, 226);
            this.context.TabIndex = 0;
            this.context.Text = "В Великом Новгороде прошел чемпионат по настольному теннису";
            this.context.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Context_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Текст:";
            // 
            // qs
            // 
            this.qs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qs.FormattingEnabled = true;
            this.qs.ItemHeight = 20;
            this.qs.Items.AddRange(new object[] {
            "формула",
            "город",
            "спорт",
            "человек"});
            this.qs.Location = new System.Drawing.Point(6, 25);
            this.qs.Name = "qs";
            this.qs.Size = new System.Drawing.Size(268, 384);
            this.qs.TabIndex = 4;
            this.qs.SelectedIndexChanged += new System.EventHandler(this.Qs_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delQ);
            this.groupBox1.Controls.Add(this.addQ);
            this.groupBox1.Controls.Add(this.qs);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(575, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 485);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сущности";
            // 
            // delQ
            // 
            this.delQ.Location = new System.Drawing.Point(174, 425);
            this.delQ.Name = "delQ";
            this.delQ.Size = new System.Drawing.Size(94, 54);
            this.delQ.TabIndex = 5;
            this.delQ.Text = "Удалить сущность";
            this.delQ.UseVisualStyleBackColor = true;
            this.delQ.Click += new System.EventHandler(this.DelQ_Click);
            // 
            // addQ
            // 
            this.addQ.Location = new System.Drawing.Point(6, 425);
            this.addQ.Name = "addQ";
            this.addQ.Size = new System.Drawing.Size(113, 54);
            this.addQ.TabIndex = 5;
            this.addQ.Text = "Добавить сущность";
            this.addQ.UseVisualStyleBackColor = true;
            this.addQ.Click += new System.EventHandler(this.AddQ_Click);
            // 
            // listQA
            // 
            this.listQA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listQA.FormattingEnabled = true;
            this.listQA.ItemHeight = 20;
            this.listQA.Location = new System.Drawing.Point(5, 336);
            this.listQA.Name = "listQA";
            this.listQA.Size = new System.Drawing.Size(560, 184);
            this.listQA.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Вопрос-ответ:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьТекстыToolStripMenuItem,
            this.загрузитьСущностиToolStripMenuItem,
            this.save_dataset_btn,
            this.загрузитьДатасетToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьТекстыToolStripMenuItem
            // 
            this.открытьТекстыToolStripMenuItem.Name = "открытьТекстыToolStripMenuItem";
            this.открытьТекстыToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.открытьТекстыToolStripMenuItem.Text = "Открыть тексты";
            // 
            // загрузитьСущностиToolStripMenuItem
            // 
            this.загрузитьСущностиToolStripMenuItem.Name = "загрузитьСущностиToolStripMenuItem";
            this.загрузитьСущностиToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.загрузитьСущностиToolStripMenuItem.Text = "Загрузить сущности";
            // 
            // save_dataset_btn
            // 
            this.save_dataset_btn.Name = "save_dataset_btn";
            this.save_dataset_btn.Size = new System.Drawing.Size(232, 24);
            this.save_dataset_btn.Text = "Сохранить датасет";
            this.save_dataset_btn.Click += new System.EventHandler(this.save_dataset_btn_Click);
            // 
            // загрузитьДатасетToolStripMenuItem
            // 
            this.загрузитьДатасетToolStripMenuItem.Name = "загрузитьДатасетToolStripMenuItem";
            this.загрузитьДатасетToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.загрузитьДатасетToolStripMenuItem.Text = "Загрузить датасет";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.RunRuNers});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // RunRuNers
            // 
            this.RunRuNers.Name = "RunRuNers";
            this.RunRuNers.Size = new System.Drawing.Size(198, 24);
            this.RunRuNers.Text = "Примеры RuNer";
            this.RunRuNers.Click += new System.EventHandler(this.RunRuNers_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NER_lbl_,
            this.ner_name_lbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(873, 25);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // NER_lbl_
            // 
            this.NER_lbl_.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.NER_lbl_.Name = "NER_lbl_";
            this.NER_lbl_.Size = new System.Drawing.Size(37, 20);
            this.NER_lbl_.Text = "NER";
            // 
            // ner_name_lbl
            // 
            this.ner_name_lbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic);
            this.ner_name_lbl.ForeColor = System.Drawing.Color.Blue;
            this.ner_name_lbl.Name = "ner_name_lbl";
            this.ner_name_lbl.Size = new System.Drawing.Size(0, 20);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(873, 552);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listQA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.context);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "RuNer Dataset Generator";
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox context;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox qs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delQ;
        private System.Windows.Forms.Button addQ;
        private System.Windows.Forms.ListBox listQA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьТекстыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьСущностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem save_dataset_btn;
        private System.Windows.Forms.ToolStripMenuItem загрузитьДатасетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RunRuNers;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel NER_lbl_;
        private System.Windows.Forms.ToolStripStatusLabel ner_name_lbl;
    }
}

