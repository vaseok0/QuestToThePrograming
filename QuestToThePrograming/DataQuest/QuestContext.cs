using Microsoft.EntityFrameworkCore;
using QuestToThePrograming.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestToThePrograming.DataQuest
{
    public class QuestContext : DbContext 
    {
        public QuestContext(DbContextOptions<QuestContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Quest> Quests { get; set; }
    }
}
