using System.Collections.Generic;

namespace qu.words.contracts.words
{
    public static class FindWords
    {
        public class Request
        {
            public IEnumerable<string> Rows { get; set; }
        }

        public class Response
        {
            public IEnumerable<WordsResults> Results { get; set; }
        }

        public class WordsResults
        {
            public int Count { get; set; }
            public string Word { get; set; }
        }
    }
}