using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentManagment.Core;
using StudentManagment.Core.Entites;

namespace StudentManagment.Data
{
    public class StudentMGTDBContext : IdentityDbContext<ApplicationUser>
    {
        
        public StudentMGTDBContext(DbContextOptions<StudentMGTDBContext> options) : base(options)
        {
           

        }

        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Enrollments> Enrollment { get; set; } = null!;
        public virtual DbSet<Courses> Course { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = string.Empty;

            connectionString = "Data Source=MOHITSHARMA\\SQLEXPRESS2019;Initial Catalog=StudentManagment; Integrated Security=True; TrustServerCertificate=True";
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);

                base.OnConfiguring(optionsBuilder);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<AspNetUser>(entity => { entity.ToTable("AspNetUsers"); });
            //modelBuilder.Entity<AspNetRole>(entity => { entity.ToTable("AspNetRoles"); });

            //modelBuilder.Entity<IdentityUserRole<Guid>>(entity => { entity.ToTable("AspNetUserRoles"); });
            //modelBuilder.Entity<IdentityUserClaim<Guid>>(entity => { entity.ToTable("AspNetUserClaims"); });
            //modelBuilder.Entity<IdentityUserClaim<Guid>>(entity => { entity.ToTable("AspNetUserClaims"); });
            //modelBuilder.Entity<IdentityRoleClaim<Guid>>(entity => { entity.ToTable("AspNetRoleClaims"); });
            //modelBuilder.Entity<IdentityUserToken<Guid>>(entity => { entity.ToTable("AspNetUserTokens"); });
            //modelBuilder.Entity<IdentityUserLogin<Guid>>(entity => { entity.ToTable("AspNetUserLogins"); });

            //modelBuilder.Entity<IdentityUserLogin<Guid>>().HasKey(login => new { login.LoginProvider, login.ProviderKey });
            //modelBuilder.Entity<IdentityUserRole<Guid>>().HasKey(role => new { role.UserId, role.RoleId });
            //modelBuilder.Entity<IdentityUserToken<Guid>>().HasKey(token => new { token.UserId, token.LoginProvider, token.Name });



            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StudentMGTDBContext).Assembly);
            modelBuilder.Entity<Student>().HasKey(s => s.StudentID);
            modelBuilder.Entity<Enrollments>().HasKey(s => s.EnrollmentID);
            modelBuilder.Entity<Courses>().HasKey(s => s.CourseID);

            modelBuilder.Entity<Student>().HasIndex(s => s.StudentID);
            modelBuilder.Entity<Student>().HasIndex(s => new { s.FirstName, s.LastName });
            modelBuilder.Entity<Courses>().HasIndex(s => s.CourseID);
            modelBuilder.Entity<Enrollments>().HasIndex(s => s.EnrollmentID);
            base.OnModelCreating(modelBuilder);
        }
    }
}
