using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;

namespace WPF_quiz.Models
{
    public class Context : DbContext
    {
        public DbSet<Kerdes> kerdesek { get; set; }
        public DbSet<Valaszok> valaszok {get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string s = "server=localhost;userid=root;password=;database = wpf_quiz";
            optionsBuilder.UseMySql(s, ServerVersion.AutoDetect(s));
        }
    }
}
