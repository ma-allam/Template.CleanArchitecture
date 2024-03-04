
using AutoMapper;
using Template.CleanArchitecture.Application.Business.User.Query.V2;

namespace Template.CleanArchitecture.WebApi.EndPoints.User.V2
{
    public class GetAllAllamMapper : Profile
    {
        public GetAllAllamMapper()
        {
            CreateMap<GetAllAllamEndPointRequest, GetAllAllamHandlerInput>()
                .ConstructUsing(src => new GetAllAllamHandlerInput(src.CorrelationId()));
            CreateMap<GetAllAllamHandlerOutput, GetAllAllamEndPointResponse>()
               .ConstructUsing(src => new GetAllAllamEndPointResponse(src.CorrelationId()));
        }

    }
}
