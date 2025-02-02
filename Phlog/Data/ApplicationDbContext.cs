﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Phlog.Models;

namespace Phlog.Data
{
    public class ApplicationDbContext : IdentityDbContext<SiteOwner>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Phlog.Models.Category> Category { get; set; } = default!;
        public DbSet<Phlog.Models.Post> Post { get; set; } = default!;
        public DbSet<Phlog.Models.Tag> Tag { get; set; } = default!;
        public DbSet<Phlog.Models.SiteSettings> SiteSettings { get; set; } = default!;
	}
}