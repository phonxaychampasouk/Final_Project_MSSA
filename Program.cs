using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace reef2.Model
{
    public class ReefSurvey : DbContext
    {
        public DbSet<Login> EmailAddress { get; set; }
        public DbSet<User> UserLogin { get; set; }
        public DbSet<Goals> UserLogin { get; set; }
        public DbSet<GoalContent> GoalID { get; set; }
        public DbSet<GoalDate> GoalId { get; set; }
        public DbSet<Tasks> UserLogin { get; set; }
        public DbSet<TasksDate> TaskId { get; set; }
        public DbSet<TasksContent> TaskId { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=HappbitDB;Integrated Security=true");
        }
    }

    // [Table ("Name of table")] - You may specify the name of the table if you don't want to use the default
    public class Login
    {
        [Key]
        public string EmailAddress { get; set; }
        public string UserLogin { get; set; }
        public string Password { get; set; }
    }

    public class User
    {

        public string UserLogin { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public double DOB { get; set; }
    }

    public class Goals
    {
        public int UserLogin { get; set; }
        public string GoalsID { get; set; }
        public string DateSubmission { get; set; }
    }

    public class GoalContent
    {
        public float GoalId { get; set; }
        public int DateSubmission { get; set; }
        public string PhotoSubmission { get; set; }
        public string TextSubmission { get; set; }
        public string VideoSubmission { get; set; }

    }

    public class GoalDate
    {
        public int GoalID { get; set; }
        public string DateSubmission { get; set; }

    }

    public class Tasks
    {
        public int UserLogin { get; set; }
        public int TaskID { get; set; }
        public string DateSubmission { get; set; }
       
    }
    public class TaskDate
    {
        public int TaskId { get; set; }
        public int DateSubmission { get; set; }
        
    }
    public class TaskContent
    {
        public int TaskID { get; set; }
        public int PhotoSubmission { get; set; }
        public string TextSubmission { get; set; }
        public string VideoSubmission { get; set; }
      
    }
    public class TaskDate
    {
        public int TaskId { get; set; }
        public int DateSubmission { get; set; }
     
    }
}