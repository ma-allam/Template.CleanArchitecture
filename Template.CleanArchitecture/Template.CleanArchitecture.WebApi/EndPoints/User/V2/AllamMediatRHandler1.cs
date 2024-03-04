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
    public class AllamMediatRHandler1EndPoint : EndpointBaseAsync
    .WithRequest<AllamMediatRHandler1EndPointRequest>
    .WithActionResult<AllamMediatRHandler1EndPointResponse>
    {
        private readonly ILogger<AllamMediatRHandler1EndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public AllamMediatRHandler1EndPoint(ILogger<AllamMediatRHandler1EndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [ApiVersion("2.0")]
        [HttpGet(AllamMediatRHandler1EndPointRequest.Route)]
        [SwaggerOperation(Summary = "AllamMediatRHandler1", Description = "AllamMediatRHandler1 ", OperationId = "Template.CleanArchitecture.WebApi.EndPoints.User.V2.AllamMediatRHandler1", Tags = new[] { "Template.CleanArchitecture.WebApi.EndPoints.User.V2" })]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(AllamMediatRHandler1EndPointResponse))]
        public override async Task<ActionResult<AllamMediatRHandler1EndPointResponse>> HandleAsync([FromQuery]AllamMediatRHandler1EndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting AllamMediatRHandler1 handling");
            var Appinput = _mapper.Map<AllamMediatRHandler1HandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<AllamMediatRHandler1EndPointResponse>(result));
        }
    }
}
