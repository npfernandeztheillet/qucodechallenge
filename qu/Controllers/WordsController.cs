using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using qu.words.contracts.words;
using qu.words.domain;

namespace qu.Controllers
{
    public class WordsController : BaseController<WordsController>
    {
        public WordsController(IMediator mediator, ILogger<WordsController> logger) : base(mediator, logger)
        {
        }

        [HttpPost]
        public async Task<ActionResult<FindWords.Response>> FindWords(FindWords.Request request)
        {
            IEnumerable<Word> words = await _mediator.Send(new words.application.FindWords.Request(request.Rows));

            return Ok(ToContract(words));
        }

        private static IEnumerable<FindWords.Response> ToContract(IEnumerable<Word> records)
        {
            return new List<FindWords.Response>();
        }
    }
}
