using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Car_rental.Models
{
    public partial class Car_Rental_DBContext : DbContext
    {
        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<Rent> Rent { get; set; }
        public virtual DbSet<Users> Users { get; set; }


        public Car_Rental_DBContext(DbContextOptions<Car_Rental_DBContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cars>(entity =>
            {
                entity.HasKey(e => e.IdCar);

                entity.Property(e => e.IdCar).HasColumnName("Id_car");

                entity.Property(e => e.Category)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mark)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rent>(entity =>
            {
                entity.HasKey(e => e.IdRent);

                entity.Property(e => e.IdRent).HasColumnName("Id_rent");

                entity.Property(e => e.IdCar).HasColumnName("Id_car");

                entity.Property(e => e.IdUser).HasColumnName("Id_user");

                entity.HasOne(d => d.IdCarNavigation)
                    .WithMany(p => p.Rent)
                    .HasForeignKey(d => d.IdCar)
                    .HasConstraintName("FK__Rent__Id_car__5AEE82B9");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Rent)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Rent__Id_user__5BE2A6F2");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.Property(e => e.IdUser).HasColumnName("Id_user");

                entity.Property(e => e.Mail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber).HasColumnName("Phone_number");

                entity.Property(e => e.Surname)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserLogin)
                    .HasColumnName("User_login")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .HasColumnName("User_password")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
        }
    }
}
