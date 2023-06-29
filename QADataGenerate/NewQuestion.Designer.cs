
namespace RuNerDataGenerate
{
    partial class NewQuestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.isAddTexQuestion = new System.Windows.Forms.RadioButton();
            this.isAddListQuestion = new System.Windows.Forms.RadioButton();
            this.qText = new System.Windows.Forms.TextBox();
            this.infoLbl = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // isAddTexQuestion
            // 
            this.isAddTexQuestion.AutoSize = true;
            this.isAddTexQuestion.Checked = true;
            this.isAddTexQuestion.Location = new System.Drawing.Point(13, 13);
            this.isAddTexQuestion.Name = "isAddTexQuestion";
            this.isAddTexQuestion.Size = new System.Drawing.Size(151, 17);
            this.isAddTexQuestion.TabIndex = 0;
            this.isAddTexQuestion.TabStop = true;
            this.isAddTexQuestion.Text = "Добавить текст вопроса";
            this.isAddTexQuestion.UseVisualStyleBackColor = true;
            this.isAddTexQuestion.CheckedChanged += new System.EventHandler(this.IsAddTexQuestion_CheckedChanged);
            // 
            // isAddListQuestion
            // 
            this.isAddListQuestion.AutoSize = true;
            this.isAddListQuestion.Location = new System.Drawing.Point(13, 37);
            this.isAddListQuestion.Name = "isAddListQuestion";
            this.isAddListQuestion.Size = new System.Drawing.Size(165, 17);
            this.isAddListQuestion.TabIndex = 1;
            this.isAddListQuestion.Text = "Добавить список вопросов";
            this.isAddListQuestion.UseVisualStyleBackColor = true;
            this.isAddListQuestion.CheckedChanged += new System.EventHandler(this.isAddListQuestion_CheckedChanged);
            // 
            // qText
            // 
            this.qText.Location = new System.Drawing.Point(13, 96);
            this.qText.Multiline = true;
            this.qText.Name = "qText";
            this.qText.Size = new System.Drawing.Size(231, 75);
            this.qText.TabIndex = 2;
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Location = new System.Drawing.Point(13, 77);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(128, 13);
            this.infoLbl.TabIndex = 3;
            this.infoLbl.Text = "Введите текст вопроса:";
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(188, 178);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(55, 23);
            this.OkBtn.TabIndex = 4;
            this.OkBtn.Text = "ОК";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // NewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 216);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.qText);
            this.Controls.Add(this.isAddListQuestion);
            this.Controls.Add(this.isAddTexQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewQuestion";
            this.Text = "Добавление вопроса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton isAddTexQuestion;
        private System.Windows.Forms.RadioButton isAddListQuestion;
        private System.Windows.Forms.TextBox qText;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.Button OkBtn;
    }
}