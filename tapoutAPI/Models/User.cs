using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using tapoutAPI.Models;

namespace tapoutAPI.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<tapoutAPI.Models.Task> Task { get; set; }
    }

    public class User
    {
        [Key]
        public int Id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string eMail { get; set; }
        public List<Task> Tasks { get; set; } = new List<Task>();
    }

    public class Task
    {
        [Key]
        public int Id { get; set; }
        public string taskName { get; set; }
        public string taskDesc { get; set; }
        public bool isCompleted { get; set; } = false;
        public string taskUser { get; set; }
    }
}
