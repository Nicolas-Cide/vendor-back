using MediatR;
using Microsoft.AspNetCore.Mvc;
using vendor.application.usecase.UseCases.Article.GetAll;
using vendor.application.usecase.UseCases.Vendor.GetAll;

namespace vendor.api.Controllers
{
    [ApiController]
    [Route("api/vendor")]
    public class VendorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VendorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("articles")]
        public async Task<IActionResult> GetAllArticles() 
        {
            var response = await _mediator.Send(new GetAllArticlesRequest());

            return Ok(response);
        }

        [HttpGet("vendors")]
        public async Task<IActionResult> GetAllVendors() 
        {
            var response = await _mediator.Send(new GetAllVendorsRequest());

            return Ok(response);
        }
    }
}
