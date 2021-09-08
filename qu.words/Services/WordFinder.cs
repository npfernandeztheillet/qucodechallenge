using System;
using System.Collections.Generic;
using System.Linq;
using Qu.Words.Exceptions;

namespace Qu.Words.Services
{
    public class WordFinder
    {
        private readonly IEnumerable<string> _matrix;

        private const int MaxNumberOfRows = 64;
        private const int MaxNumberOfColumns = 64;
        private const int MaxNumberOfElements = 10;
        public WordFinder(IEnumerable<string> matrix)
        {
            _matrix = matrix;
        }
        public IEnumerable<string> Find(IEnumerable<string> wordStream)
        {
            Dictionary<string, int> repeatedWordCount = new Dictionary<string, int>();

            Validate();
            foreach (var stream in wordStream)
            {
                CountFromRows(repeatedWordCount, stream);

                CountFromColumns(repeatedWordCount, stream);
            }

            return repeatedWordCount.OrderByDescending(o => o.Value).Take(MaxNumberOfElements).Select(s => s.Key);
        }

        #region private

        private void CountWord(Dictionary<string, int> repeatedWordCount, string key, int value)
        {
            if (value == 0)
                return;

            if (repeatedWordCount.ContainsKey(key)) // Check if word already exist in dictionary update the count  
                repeatedWordCount[key] += value;
            else
                repeatedWordCount.Add(key, value);  // if a string is repeated and not added in dictionary , here we are adding   
        }

        private int CountSubstring(string source, string value)
        {
            int count = 0, n = 0;
            while ((n = source.IndexOf(value, n, StringComparison.InvariantCulture)) != -1)
            {
                n += value.Length;
                ++count;
            }

            return count;
        }

        private void CountFromRows(Dictionary<string, int> repeatedWordCount, string stream)
        {
            foreach (var row in _matrix)
            {
                CountWord(repeatedWordCount, stream, CountSubstring(row, stream));
            }
        }

        private void CountFromColumns(Dictionary<string, int> repeatedWordCount, string stream)
        {
            var matrixToList = _matrix.ToList();
            var numberOfRows = _matrix.Count();
            var numberOfColumns = _matrix.First().Length;
            for (int i = 0; i < numberOfColumns; ++i)
            {
                string tempString = string.Empty;
                for (int j = 0; j < numberOfRows; ++j)
                {
                    char temp = matrixToList[j][i];
                    tempString = string.Concat(tempString, temp);
                }
                CountWord(repeatedWordCount, stream, CountSubstring(tempString, stream));
            }
        }

        private void Validate()
        {
            if (!_matrix.Any())
                return;

            var numberOfRows = _matrix.Count();
            var currentSize = _matrix.First().Length;
            var existsDifferentSize = false;
            //Max size and different size on columns
            foreach (var row in _matrix)
            {
                if (currentSize != row.Length)
                {
                    existsDifferentSize = true;
                    break;
                }
            }

            if (existsDifferentSize)
                throw new DifferentColumnSizeException();

            if (numberOfRows > MaxNumberOfRows || currentSize > MaxNumberOfColumns)
                throw new MaxSizeException();
        }

        #endregion
    }
}
