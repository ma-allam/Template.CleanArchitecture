
using Template.CleanArchitecture.Core.Messages;

namespace Template.CleanArchitecture.Application.Business.User.Query.V2
{
    public class GetAllAllamHandlerOutput : BaseResponse
    {
        public GetAllAllamHandlerOutput() { }
        public GetAllAllamHandlerOutput(Guid correlationId) : base(correlationId) { }

    }
}
