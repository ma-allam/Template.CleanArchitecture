using MediatR;
using System;
using System.Collections.Generic;
using Template.CleanArchitecture.Core.Messages;

namespace Template.CleanArchitecture.Application.Business.User.Query.V2
{
    public class AllamMediatRHandler1HandlerOutput : BaseResponse
    {
        public AllamMediatRHandler1HandlerOutput() { }
        public AllamMediatRHandler1HandlerOutput(Guid correlationId) : base(correlationId) { }
        public Guid id { get; set; }
        public string username { get; set; }
    }
}
