using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Template.CleanArchitecture.Application.Contracts;


namespace Template.CleanArchitecture.Application.Business.User.Query.V2
{
    public class AllamMediatRHandler1Handler : IRequestHandler<AllamMediatRHandler1HandlerInput, AllamMediatRHandler1HandlerOutput>
    {
        private readonly IDataBaseService _dataBaseService;
        public AllamMediatRHandler1Handler(IDataBaseService dataBaseService )
        {
            _dataBaseService = dataBaseService;
        }
        public async Task<AllamMediatRHandler1HandlerOutput> Handle(AllamMediatRHandler1HandlerInput request, CancellationToken cancellationToken)
        {
            AllamMediatRHandler1HandlerOutput output = new AllamMediatRHandler1HandlerOutput(request.CorrelationId());
            var v=await _dataBaseService.Users.Where(x => x.UserName==request.name).FirstOrDefaultAsync();
            output.username = "My name is "+request.name;
            
            return output;
        }
    }
}
