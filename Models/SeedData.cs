using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SDEVTest.Data;
using System;
using System.Linq;

namespace SDEVTest.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SDEVTestContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SDEVTestContext>>()))
            {
                // Look for any movies.
                if (context.Stock.Any())
                {
                    return;   // DB has been seeded
                }

                context.Stock.AddRange(
                    new Stock
                    {
                        Make = "Volkswagen",
                        Model ="T-Cross",
                        Price = 0.0M,
                        StockLeft = int.Parse("2")
                    },

                   new Stock
                   {
                       Make = "Volkswagen",
                       Model = "Tiguan Allspace",
                       Price = 552500M,
                       StockLeft = int.Parse("3")
                   },

                   new Stock
                   {
                       Make = "Volkswagen",
                       Model = "Polo Sedan",
                       Price = 253700M,
                       StockLeft = int.Parse("1")
                   },

                    new Stock
                    {
                        Make = "Volkswagen",
                        Model = "Polo",
                        Price = 293800M,
                        StockLeft = int.Parse("1")
                    },
                    new Stock
                    {
                        Make = "Volkswagen",
                        Model = "Amarok",
                        Price = 726100M,
                        StockLeft = int.Parse("3")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
