using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace dotnetmicroservicetwo.Models;

public class ProjectDbContext : DbContext
{

    public ProjectDbContext(DbContextOptions<ProjectDbContext> options)
        : base(options)
    {
    }
    public virtual DbSet<Project> Projects { get; set; }
}
