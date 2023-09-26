using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace dotnetmicroserviceone.Models;

public class FreelancerDbContext : DbContext
{
    public FreelancerDbContext()
    {
    }

    public FreelancerDbContext(DbContextOptions<FreelancerDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Freelancer> Freelancers { get; set; }

}
