namespace qu.words.domain
{
    public class Word
    {
        public string Value { get; }
        public int Count { get; }

        private Word(string value, int count)
        {
            Value = value;
            Count = count;
        }

        public static Word Create(string value, int count)
        {
            return new Word(value, count);
        }
    }
}
