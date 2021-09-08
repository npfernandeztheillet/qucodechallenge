using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using qu.words.domain;

namespace qu.words.application
{
    public static class FindWords
    {
        public class Request : IRequest<IEnumerable<string>>
        {
            private readonly IEnumerable<string> Rows;

            public Request(IEnumerable<string> rows)
            {
                Rows = rows;
            }
        }

        public class Handler : IRequestHandler<Request, IEnumerable<string>>
        {
            public Handler()
            {
            }

            public async Task<IEnumerable<string>> Handle(Request request, CancellationToken cancellationToken)
            {

                return new List<string>();
            }
        }
    }
}