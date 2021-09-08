using System;

namespace Qu.Words.Exceptions
{
    public class MaxSizeException : Exception
    {
        public static readonly Guid Id = new Guid("8A3ACB0A-64F2-4D6A-9705-B283E21F0A46");

        public MaxSizeException()
            : base(Id + "Matrix size is greater than the maximum supported")
        {
        }
    }
}