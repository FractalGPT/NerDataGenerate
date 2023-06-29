using RuNerDataGenerate.Logic;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace RuNerDataGenerate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ChIndexQList();
            context.BackColor = Color.White;
        }

        int _startMark = 0, _lenMark = 0, _qIndex = 0;
        string _answerText = "", _questionText;


        // Обработка клавиш при нажатии на текстовое поле
        private void Context_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;

            // Выделение
            if (e.KeyCode == Keys.Space && context.SelectedText.Length > 0 && _questionText.Length > 0)
            {
                _answerText = context.SelectedText;
                _startMark = context.SelectionStart;
                _lenMark = _answerText.Length;

                MainWindowGUITool.SelectText(context, _startMark, _lenMark);

                RuNerDataElement element = new RuNerDataElement()
                {
                    Context = context.Text,
                    Answer = _answerText,
                    IndexStartAnswer = _startMark,
                    Question = _questionText
                };


                listQA.Items.Add(element);
            }
            #region Вопросы
            //Предыдущий вопрос
            if (e.KeyCode == Keys.W)
            {
                _qIndex--;
                ChIndexQList();
            }

            //Следующий вопрос
            if (e.KeyCode == Keys.S)
            {
                _qIndex++;
                ChIndexQList();
            }

            // Удалить вопрос
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.D) DelQ();

            //Создать вопрос
            if (e.Modifiers == Keys.Shift && e.KeyCode == Keys.C) MainWindowGUITool.AddQ(qs);
            #endregion

            //Вставить текст
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V) context.Text = Clipboard.GetText();

            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S) MainWindowGUITool.SaveAs(listQA);
        }

        // Создание датасета
        private void CreateDatasetBtn_Click(object sender, EventArgs e)
        {
            MainWindowGUITool.SaveAs(listQA);
        }

        private void Autofill_Click(object sender, EventArgs e)
        {

        }

        private void AutoLabeling_Click(object sender, EventArgs e)
        {

        }

        #region Вопросы
        //Выбор вопроса
        private void Qs_SelectedIndexChanged(object sender, EventArgs e)
        {
            _qIndex = qs.SelectedIndex;
            ChIndexQList();
        }

        private void AddQ_Click(object sender, EventArgs e)
        {
            MainWindowGUITool.AddQ(qs);
        }

        /// <summary>
        /// Сохранить датасет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save_dataset_btn_Click(object sender, EventArgs e)
        {
            MainWindowGUITool.SaveAs(listQA);
        }

        

        private void DelQ_Click(object sender, EventArgs e)
        {
            DelQ();
        }

        #endregion

        //Удаление вопроса
        void DelQ()
        {
            if (qs.Items.Count > 0)
            {
                qs.Items.RemoveAt(_qIndex);
                ChIndexQList();
            }
        }

        private void ChIndexQList()
        {
            var outp = MainWindowGUITool.ChIndexQList(qs, _qIndex);
            _qIndex = outp.Item1;
            _questionText = outp.Item2;
            ner_name_lbl.Text = _questionText;
        }

        /// <summary>
        /// Показать ReadMe RuNer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RunRuNers_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/FractalGPT/RuNer/blob/main/README.md");
        }
    }
}
