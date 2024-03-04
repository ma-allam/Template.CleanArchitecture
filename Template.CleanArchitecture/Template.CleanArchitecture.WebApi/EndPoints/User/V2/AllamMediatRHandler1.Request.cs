using Microsoft.AspNetCore.Mvc;
using Template.CleanArchitecture.Core.Messages;

namespace Template.CleanArchitecture.WebApi.EndPoints.User.V2
{
    public class AllamMediatRHandler1EndPointRequest : BaseRequest
    {
        public const string Route = "/API/AllamMediatRHandler1/";
        public string name { get; set; }

    }
}
