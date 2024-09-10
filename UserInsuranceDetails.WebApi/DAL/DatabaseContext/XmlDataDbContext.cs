using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using UserInsuranceDetails.WebApi.DAL.Entity;

namespace UserInsuranceDetails.WebApi.DAL.DatabaseContext;

public partial class XmlDataDbContext : DbContext
{
    public XmlDataDbContext()
    {
    }

    public XmlDataDbContext(DbContextOptions<XmlDataDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<XmlDataEntity> UserInsuranceDetails { get; set; }

}