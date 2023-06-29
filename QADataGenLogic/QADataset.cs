using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RuNerDataGenerate.Logic
{
    public class RuNerDataset : List<RuNerDataElement>
    {

        public RuNerDataset(int n) : base(n) { }

        /// <summary>
        /// Получить CSV
        /// </summary>
        /// <param name="delimiter">Разделитель</param>
        public string ToCSVHappyTransformers(char delimiter = ',')
        {
            StringBuilder stringBuilder = new StringBuilder();
            string header = $"context{delimiter}question{delimiter}answer_text{delimiter}answer_start\n";
            stringBuilder.Append(header);

            foreach (var item in this)
            {
                string context = PrepaireForCsv(item.Context, delimiter);
                string answer = PrepaireForCsv(item.Answer, delimiter);
                string question = PrepaireForCsv(item.Question, delimiter);

                string itemString = $"{context}{delimiter}{question}{delimiter}{answer}{delimiter}{item.IndexStartAnswer}\n";
                stringBuilder.Append(itemString);
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Записать в файл
        /// </summary>
        /// <param name="path">Путь</param>
        /// <param name="delimiter">Разделитель</param>
        public void SaveAsCsvHappyTransformer(string path, char delimiter = ',')
        {
            string csv = ToCSVHappyTransformers(delimiter);
            File.WriteAllText(path, csv);
        }


        // Пред. обработка строки
        private string PrepaireForCsv(string inp, char delimiter)
        {
            return (inp.Contains(delimiter) || inp.Contains('\n')) ?
                $"\"{inp.Replace('\"', '\'')}\"" :
                inp;
        }
    }
}
