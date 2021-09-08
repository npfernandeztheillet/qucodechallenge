using System;
using System.Collections.Generic;
using FluentAssertions;
using Qu.Words.Exceptions;
using Qu.Words.Services;
using Xunit;

namespace Qu.Unit.Test
{
    public class WordFinderTests
    {
        [Fact]
        public void GivenAnInvalidMatrixAndWordStream_WhenFindWords_ThenThrowDifferentSizeException()
        {
            List<string> matrix = new List<string> { "abcdcefghijk","diffsize"};

            List<string> wordStream = new List<string> { "cold" };

            var finder = new WordFinder(matrix);

            Action act = () => _ = finder.Find(wordStream);

            act.Should().ThrowExactly<DifferentColumnSizeException>();
        }

        [Fact]
        public void GivenAnInvalidColumnMaxSizeMatrixAndWordStream_WhenFindWords_ThenThrowMaxSizeException()
        {
            List<string> matrix = new List<string> { "abcdcefghijkabcdcefghijkabcdcefghijkabcdcefghijkabcdcefghijk" +
                                                     "abcdcefghijkabcdcefghijkabcdcefghijkabcdcefghijkabcdcefghijk"};

            List<string> wordStream = new List<string> { "cold" };

            var finder = new WordFinder(matrix);

            Action act = () => _ = finder.Find(wordStream);

            act.Should().ThrowExactly<MaxSizeException>();
        }

        [Fact]
        public void GivenAnInvalidRowMaxSizeMatrix_WhenFindWords_ThenThrowMaxSizeException()
        {
            List<string> matrix = new List<string>();
            for (int i = 0; i < 65; i++)
            {
                matrix.Add("col");
            }

            List<string> wordStream = new List<string> { "cold" };

            var finder = new WordFinder(matrix);

            Action act = () => _ = finder.Find(wordStream);

            act.Should().ThrowExactly<MaxSizeException>();
        }

        [Fact]
        public void GivenAValidMatrixAndWordStream_WhenFindWords_ThenGetCorrectTopWords()
        {
            List<string> matrix = new List<string> { "abcdc", 
                                                     "fgwio",
                                                     "chill",
                                                     "pqnsd",
                                                     "uvdxy" };

            List<string> wordStream = new List<string> { "cold",
                                                         "wind",
                                                         "snow",
                                                         "chill" };
            IEnumerable<string> assertResults = new List<string> { "cold",
                                                            "wind",
                                                            "chill" };

            var finder = new WordFinder(matrix);
            var results=finder.Find(wordStream);

            assertResults.Should().Equal(results);
        }
    }
}