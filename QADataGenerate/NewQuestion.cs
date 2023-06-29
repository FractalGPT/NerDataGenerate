using System;
using System.Windows.Forms;

namespace RuNerDataGenerate
{
    public partial class NewQuestion : Form
    {
        public NewQuestion()
        {
            InitializeComponent();
            QList = new string[0];
        }

        public bool IsListQ { get; set; } = false;
        public string[] QList { get; set; }
        public string Question { get; set; } = "";

        private void IsAddTexQuestion_CheckedChanged(object sender, EventArgs e)
        {
            IsListQ = false;
            infoLbl.Text = "Введите текст вопроса:";
        }

        private void isAddListQuestion_CheckedChanged(object sender, EventArgs e)
        {
            infoLbl.Text = "Введите имя столбца с вопросами:";
            IsListQ = true;
        }


        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (!IsListQ) Question = qText.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
