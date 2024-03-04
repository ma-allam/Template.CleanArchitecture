

using Template.CleanArchitecture.Core.Messages;

namespace Template.CleanArchitecture.WebApi.EndPoints.User.V2
{
    public class AllamMediatRHandler1EndPointResponse : BaseResponse
    {
        public AllamMediatRHandler1EndPointResponse() { }
        public AllamMediatRHandler1EndPointResponse(Guid correlationId) : base(correlationId) { }
        public Guid id { get; set; }
        public string username { get; set; }
    }
}
