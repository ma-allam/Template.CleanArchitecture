using Ardalis.ApiEndpoints;
using AutoMapper;

using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using Template.CleanArchitecture.Application.Business.User.Query.V2;

namespace Template.CleanArchitecture.WebApi.EndPoints.User.V2
{
    public class GetAllAllamEndPoint : EndpointBaseAsync
    .WithRequest<GetAllAllamEndPointRequest>
    .WithActionResult<GetAllAllamEndPointResponse>
    {
        private readonly ILogger<GetAllAllamEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public GetAllAllamEndPoint(ILogger<GetAllAllamEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [ApiVersion("2.0")]
        [HttpGet(GetAllAllamEndPointRequest.Route)]
        [SwaggerOperation(Summary = "GetAllAllam", Description = "GetAllAllam ", OperationId = "Template.CleanArchitecture.WebApi.EndPoints.User.V2.GetAllAllam", Tags = new[] { "Template.CleanArchitecture.WebApi.EndPoints.User.V2" })]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GetAllAllamEndPointResponse))]
        //[SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(ExceptionOutput))]
        public override async Task<ActionResult<GetAllAllamEndPointResponse>> HandleAsync(GetAllAllamEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting GetAllAllam handling");
            var Appinput = _mapper.Map<GetAllAllamHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<GetAllAllamEndPointResponse>(result));
        }
    }
}
