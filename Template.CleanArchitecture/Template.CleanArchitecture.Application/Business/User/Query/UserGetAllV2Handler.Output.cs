﻿using Template.CleanArchitecture.Core.Messages;

namespace Template.CleanArchitecture.Application.Business.User.Query
{
    public class UserGetAllV2Output : BaseResponse
    {
        public UserGetAllV2Output() { }
        public UserGetAllV2Output(Guid correlationId) : base(correlationId) { }
        public List<SelectedUserDto> Result { get; set; }
    }

    public class SelectedUserDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}