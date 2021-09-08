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
            public IEnumerable<string> Results { get; set; }
        }
    }
}