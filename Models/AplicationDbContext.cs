﻿
using Microsoft.EntityFrameworkCore;

namespace BE_Veterinaria.Models
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {


        }

        public DbSet<Mascota> Mascotas { get; set; }
    }
}
