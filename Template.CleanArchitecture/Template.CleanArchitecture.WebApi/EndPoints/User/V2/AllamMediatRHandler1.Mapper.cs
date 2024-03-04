
using AutoMapper;
using Template.CleanArchitecture.Application.Business.User.Query.V2;

namespace Template.CleanArchitecture.WebApi.EndPoints.User.V2
{
    public class AllamMediatRHandler1Mapper : Profile
    {
        public AllamMediatRHandler1Mapper()
        {
            CreateMap<AllamMediatRHandler1EndPointRequest, AllamMediatRHandler1HandlerInput>()
                .ConstructUsing(src => new AllamMediatRHandler1HandlerInput(src.CorrelationId()));
            CreateMap<AllamMediatRHandler1HandlerOutput, AllamMediatRHandler1EndPointResponse>()
               .ConstructUsing(src => new AllamMediatRHandler1EndPointResponse(src.CorrelationId()));
        }

    }
}
