using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using qu.words.domain;

namespace qu.words.application
{
    public static class FindWords
    {
        public class Request : IRequest<IEnumerable<Word>>
        {
            private readonly IEnumerable<string> Rows;

            public Request(IEnumerable<string> rows)
            {
                Rows = rows;
            }
        }

        public class Handler : IRequestHandler<Request, IEnumerable<Word>>
        {
            public Handler()
            {
            }

            public async Task<IEnumerable<Word>> Handle(Request request, CancellationToken cancellationToken)
            {

                return new List<Word>();
            }
        }
    }
}