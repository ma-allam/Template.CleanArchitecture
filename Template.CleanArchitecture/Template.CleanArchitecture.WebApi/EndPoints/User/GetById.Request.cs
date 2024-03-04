﻿namespace Template.CleanArchitecture.WebApi.EndPoints.User
{
    public class GetByIdRequest
    {
        public const string Route = "/api/user/GetById";
        public Guid Id { get; set; }
    }
}
