using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Qu.Words.Services;

namespace Qu.Words.Application
{
    public static class FindWords
    {
        public class Request : IRequest<IEnumerable<string>>
        {
            public IEnumerable<string> Matrix { get; }
            public IEnumerable<string> WordStream { get; }

            public Request(IEnumerable<string> matrix, IEnumerable<string> wordStream)
            {
                Matrix = matrix;
                WordStream = wordStream;
            }
        }

        public class Handler : IRequestHandler<Request, IEnumerable<string>>
        {
            public Handler()
            {
            }

            public async Task<IEnumerable<string>> Handle(Request request, CancellationToken cancellationToken)
            {
                var finder = new WordFinder(request.Matrix);
                return finder.Find(request.WordStream);
            }
        }
    }
}