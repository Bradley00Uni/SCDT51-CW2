using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ITS_Support.Models;

namespace ITS_Support.Data
{
    public class ApplicationDbContext : IdentityDbContext<UserModel>
    {
        public DbSet<CampusModel> Campuses { get; set; }
        public DbSet<RoomModel> Rooms { get; set; }
        public DbSet<AssetModel> Assets { get; set; }
        public DbSet<TypeModel> Types { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ITS_Support.Models.AssetModel> AssetModel { get; set; }
        public DbSet<ITS_Support.Models.TypeModel> TypeModel { get; set; }
    }
}
