using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Template.CleanArchitecture.Domain.Entities;

public partial class PhoneNumberTypes
{
    [Key]
    public Guid Id { get; set; }

    public string Title { get; set; } = null!;

    [InverseProperty("PhoneNumberType")]
    public virtual ICollection<PhoneNumbers> PhoneNumbers { get; set; } = new List<PhoneNumbers>();
}
