using MediatR;
using Template.CleanArchitecture.Core.Messages;

namespace Template.CleanArchitecture.Application.Business.User.Query.V2
{
    public class GetAllAllamHandlerInput : BaseRequest, IRequest<GetAllAllamHandlerOutput>
    {
        public GetAllAllamHandlerInput() { }
        public GetAllAllamHandlerInput(Guid correlationId) : base(correlationId) { }
    }
}
