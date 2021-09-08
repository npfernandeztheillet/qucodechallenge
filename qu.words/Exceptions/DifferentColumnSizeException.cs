using System;

namespace Qu.Words.Exceptions
{
    public class DifferentColumnSizeException : Exception
    {
        public static readonly Guid Id = new Guid("8A3ACB0A-64F2-4D6A-9705-B283E21F0A45");

        public DifferentColumnSizeException()
            : base(Id + "Matrix has different size of columns")
        {
        }
    }
}