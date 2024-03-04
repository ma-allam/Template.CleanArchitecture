using MediatR;


namespace Template.CleanArchitecture.Application.Business.User.Query.V2
{
    public class GetAllAllamHandler : IRequestHandler<GetAllAllamHandlerInput, GetAllAllamHandlerOutput>
    {
        public GetAllAllamHandler()
        {

        }
        public async Task<GetAllAllamHandlerOutput> Handle(GetAllAllamHandlerInput request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            GetAllAllamHandlerOutput output = new GetAllAllamHandlerOutput(request.CorrelationId());
            return output;
        }
    }
}
