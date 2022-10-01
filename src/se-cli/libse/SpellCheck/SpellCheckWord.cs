namespace seconv.libse.SpellCheck
{
    public class SpellCheckWord
    {
        public int Index { get; set; }
        public string Text { get; set; }
        public int Length => Text.Length;
    }
}
