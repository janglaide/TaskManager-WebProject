using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class TaskManagerContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskState> TaskStates { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserTask> UserTasks { get; set; }
        public TaskManagerContext(DbContextOptions<TaskManagerContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Task>().HasKey(k => k.Id);
            modelBuilder.Entity<TaskState>().HasKey(k => k.Id);
            modelBuilder.Entity<User>().HasKey(k => k.Id);
            modelBuilder.Entity<UserTask>().HasKey(k => k.Id);

            modelBuilder.Entity<Task>()
                .HasOne(t => t.TaskState)
                .WithMany(s => s.Tasks)
                .HasForeignKey(f => f.TaskStateId);
            modelBuilder.Entity<UserTask>()
                .HasOne(u => u.User)
                .WithMany(t => t.UserTasks)
                .HasForeignKey(f => f.UserId);
            modelBuilder.Entity<UserTask>()
                .HasOne(u => u.Task)
                .WithMany(t => t.UserTasks)
                .HasForeignKey(f => f.TaskId);
            modelBuilder.Entity<Task>()
                .HasOne(m => m.Manager)
                .WithMany(t => t.GivenTasks)
                .HasForeignKey(f => f.ManagerId);

            modelBuilder.Entity<TaskState>().HasData(new TaskState[]
            {
                new TaskState{Id = 1, State = "Opened"},
                new TaskState{Id = 2, State = "In work"},
                new TaskState{Id = 3, State = "Done"},
                new TaskState{Id = 4, State = "Closed"}
            });
            modelBuilder.Entity<User>().HasData(new User[] {
                new User{Id = 1, Name = "Alisa", Surname = "Proshchenko", Email = "ajanglaide@gmail.com"},
                new User{Id = 2, Name = "Ivan", Surname = "Petrov", Email = "ivanpetrov@gmail.com"}
            });
            modelBuilder.Entity<Task>().HasData(new Task[] {
                new Task{Id = 1, Description = "Upload new logo", TaskStateId = 2, LastUpdate = Convert.ToDateTime("2020-05-05"),
                    CreationDatetime = Convert.ToDateTime("2020-05-01"), Deadline = Convert.ToDateTime("2020-05-25"), ManagerId = 1}
            });
            modelBuilder.Entity<UserTask>().HasData(new UserTask[] {
                new UserTask{Id = 1, TaskId = 1, UserId = 2}
            });
        }
    }
}
