using Learner.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Learner.Context
{
    public static class AppDbContextSeed
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Employees.Any())
            {
                var employees = new[]
                {
                    new Employee(0, "Gavin", "Bazunu", "Goalkeeper", 50000),
                    new Employee(0, "Alex", "McCarthy", "Goalkeeper", 45000),
                    new Employee(0, "James", "Ward-Prowse", "Midfielder", 70000),
                    new Employee(0, "Kyle", "Walker-Peters", "Defender", 60000),
                    new Employee(0, "Mohammed", "Salisu", "Defender", 55000),
                    new Employee(0, "Romain", "Perraud", "Defender", 50000),
                    new Employee(0, "Lyanco", "Vojnovic", "Defender", 48000),
                    new Employee(0, "Armel", "Bella-Kotchap", "Defender", 52000),
                    new Employee(0, "Moussa", "Djenepo", "Midfielder", 47000),
                    new Employee(0, "Ibrahima", "Diallo", "Midfielder", 46000),
                    new Employee(0, "Stuart", "Armstrong", "Midfielder", 49000),
                    new Employee(0, "Joe", "Aribo", "Midfielder", 45000),
                    new Employee(0, "Che", "Adams", "Forward", 65000),
                    new Employee(0, "Adam", "Armstrong", "Forward", 62000),
                    new Employee(0, "Theo", "Walcott", "Forward", 60000),
                    new Employee(0, "Sekou", "Mara", "Forward", 58000),
                    new Employee(0, "Samuel", "Edozie", "Forward", 54000),
                    new Employee(0, "Ainsley", "Maitland-Niles", "Midfielder", 50000),
                    new Employee(0, "Duje", "Caleta-Car", "Defender", 53000),
                    new Employee(0, "Juan", "Larios", "Defender", 51000)
                };

                context.Employees.AddRange(employees);
                context.SaveChanges();
            }
        }
    }
}