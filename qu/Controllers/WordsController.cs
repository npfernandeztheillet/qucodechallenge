using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Qu.Words.Contracts.Words;

namespace Qu.API.Controllers
{
    public class WordsController : BaseController<WordsController>
    {
        public WordsController(IMediator mediator, ILogger<WordsController> logger) : base(mediator, logger)
        {
        }

        [HttpPost]
        public async Task<ActionResult<string>> FindWords(FindWords.Request request)
        {
            IEnumerable<string> words = await _mediator.Send(new Words.Application.FindWords.Request(request.Matrix, request.WordStream));

            return Ok(words);
        }
    }
}
