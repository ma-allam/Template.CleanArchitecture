﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Template.CleanArchitecture.Domain.Entities;

namespace Template.CleanArchitecture.Application.Contracts
{

    public interface IDataBaseService
    {
        int DBSaveChanges();
        Task<int> DBSaveChangesAsync(CancellationToken cancellationToken = default);
        DbSet<User> Users { get; set; }
        DbSet<PhoneNumber> PhoneNumbers { get; set; }
        DbSet<PhoneNumberType> PhoneNumberTypes { get; set; }
    }

}
