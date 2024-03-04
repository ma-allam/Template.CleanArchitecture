using Microsoft.AspNetCore.Mvc;
using Template.CleanArchitecture.Core.Messages;

namespace Template.CleanArchitecture.WebApi.EndPoints.User.V2
{
    public class GetAllAllamEndPointRequest : BaseRequest
    {
        public const string Route = "/api/user/v{version:apiVersion}/GetAll";


    }
}
