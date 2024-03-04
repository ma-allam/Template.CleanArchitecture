using MediatR;
using Template.CleanArchitecture.Core.Messages;

namespace Template.CleanArchitecture.Application.Business.User.Query.V2
{
    public class AllamMediatRHandler1HandlerInput : BaseRequest, IRequest<AllamMediatRHandler1HandlerOutput>
    {
        public AllamMediatRHandler1HandlerInput() { }
        public AllamMediatRHandler1HandlerInput(Guid correlationId) : base(correlationId) { }
        public string name { get; set; }
    }
}
