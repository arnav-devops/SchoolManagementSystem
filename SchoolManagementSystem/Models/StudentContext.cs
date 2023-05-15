using Microsoft.EntityFrameworkCore;

namespace SchoolManagementSystem.Models
{
    public class StudentContext :DbContext
    {


        public StudentContext(DbContextOptions<StudentContext> options):base(options)  
        
        
        {
            
        }

        public DbSet<Student> student { get; set; }
        public DbSet<Teacher> Teachers { get; set; }


    }
}
