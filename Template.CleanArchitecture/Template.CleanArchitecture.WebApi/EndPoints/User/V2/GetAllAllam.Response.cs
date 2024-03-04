

using Template.CleanArchitecture.Core.Messages;

namespace Template.CleanArchitecture.WebApi.EndPoints.User.V2
{
    public class GetAllAllamEndPointResponse : BaseResponse
    {
        public GetAllAllamEndPointResponse() { }
        public GetAllAllamEndPointResponse(Guid correlationId) : base(correlationId) { }

    }
}
