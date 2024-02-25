using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Template.CleanArchitecture.Domain.Entities;

namespace Template.CleanArchitecture.Application.Contracts
{

    public interface IDatabaseService
    {
        int DBSaveChanges();
        Task<int> DBSaveChangesAsync(CancellationToken cancellationToken = default);
         DbSet<PhoneNumberTypes> PhoneNumberTypes { get; set; }

        DbSet<PhoneNumbers> PhoneNumbers { get; set; }

        DbSet<Users> Users { get; set; }
    }

}
