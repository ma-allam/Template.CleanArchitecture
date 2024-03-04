﻿namespace Template.CleanArchitecture.Core.Messages
{
    public abstract class BaseMessage
    {

        protected Guid _correlationId = Guid.NewGuid();
        public Guid CorrelationId() => _correlationId;
    }
}
