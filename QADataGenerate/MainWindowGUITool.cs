using RuNerDataGenerate.Logic;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RuNerDataGenerate
{
    /// <summary>
    /// Инструменты GUI для основного окна (логика)
    /// </summary>
    [Serializable]
    public static class MainWindowGUITool
    {
        /// <summary>
        /// Принимает ыписок вопросов и индекс вопроса, возвращает индекс и текст вопроса
        /// </summary>
        /// <param name="qs"></param>
        /// <param name="questionLabel"></param>
        /// <param name="q_index"></param>
        /// <returns></returns>
        public static Tuple<int, string> ChIndexQList(ListBox qs, int q_index)
        {
            string questionText = string.Empty;

            int new_qIndex;
            if (qs.Items.Count == 0)
            {
                MessageBox.Show("Список вопросов пуст");
                new_qIndex = 0;
                questionText = string.Empty;
            }
            else
            {
                new_qIndex = (q_index < qs.Items.Count) ? q_index : q_index - 1;
                new_qIndex = (new_qIndex >= 0) ? new_qIndex : new_qIndex + 1;
                qs.SelectedItem = questionText = (string)qs.Items[new_qIndex];
            }

            return new Tuple<int, string>(new_qIndex, questionText);
        }

        /// <summary>
        /// Очистка после выделения
        /// </summary>
        /// <param name="context"></param>
        public static void ClearColor(RichTextBox context)
        {
            int len = context.Text.Length;
            context.Select(0, len);
            context.SelectionColor = Color.Black;
            context.SelectionBackColor = Color.White;
        }

        /// <summary>
        /// Выделение текста
        /// </summary>
        /// <param name="context"></param>
        /// <param name="start"></param>
        /// <param name="len"></param>
        public static void SelectText(RichTextBox context, int start, int len)
        {
            ClearColor(context);
            context.Select(start, len);
            context.SelectionBackColor = Color.Green;
            context.SelectionColor = Color.White;
            context.Select(0, 0);
        }

        /// <summary>
        /// Добавить вопрос
        /// </summary>
        /// <param name="qs"></param>
        public static void AddQ(ListBox qs)
        {
            NewQuestion newQuestion = new NewQuestion();
            if (newQuestion.ShowDialog() == DialogResult.OK)
            {
                if (newQuestion.IsListQ)
                    qs.Items.AddRange(newQuestion.QList);
                else
                    if (newQuestion.Question.Length > 1) qs.Items.Add(newQuestion.Question);
            }
        }

        /// <summary>
        /// Сохранить как
        /// </summary>
        /// <param name="listQA"></param>
        public static void SaveAs(ListBox listQA)
        {
            SaveFileDialog fileDialog = new SaveFileDialog() { Filter = "(csv файлы)|*.csv" };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                RuNerDataset dataset = new RuNerDataset(listQA.Items.Count); // Датасет

                foreach (var item in listQA.Items)
                    dataset.Add((RuNerDataElement)item);

                dataset.SaveAsCsvHappyTransformer(fileDialog.FileName);
            }
        }
    }
}
