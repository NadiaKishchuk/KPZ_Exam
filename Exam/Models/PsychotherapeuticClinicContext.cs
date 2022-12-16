using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class PsychotherapeuticClinicContext:DbContext
    {
        public DbSet<Doctor> Doctors { get; private set; }
        public DbSet<Record> Records { get; private set; }
        public DbSet<Room> Rooms { get; private set; }

        public PsychotherapeuticClinicContext() : base() { }
        public PsychotherapeuticClinicContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Doctor>()
                 .HasMany(d => d.Records)
                 .WithOne(r => r.Doctor)
                 .HasForeignKey(r => r.DoctorId)
                 ;

            modelBuilder.Entity<Doctor>()
                .HasOne(d => d.Room)
                .WithMany(r => r.Doctors)
                .HasForeignKey(r => r.RoomId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-I7Q35NQ\SQLEXPRESS;Database=PsychoterapevticClinic;Trusted_Connection=True;Encrypt=False; Integrated Security=True ");
        }


    }
}
