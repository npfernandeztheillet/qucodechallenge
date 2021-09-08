using System.Collections.Generic;

namespace Qu.Words.Contracts.Words
{
    public static class FindWords
    {
        public class Request
        {
            public IEnumerable<string> Matrix { get; set; }

            public IEnumerable<string> WordStream { get; set; }
        }
    }
}