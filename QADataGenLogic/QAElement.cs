namespace RuNerDataGenerate.Logic
{
    public class RuNerDataElement
    {
        public string Context { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int IndexStartAnswer { get; set; }


        public override string ToString()
        {
            return $"q: \"{Question}\"\t ans: \"{Answer}\"\t start: \"{IndexStartAnswer}\"";
        }
    }
}
