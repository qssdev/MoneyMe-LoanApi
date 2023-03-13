using LoanApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace LoanApplication.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlackList>().HasData(
                    new BlackList
                    {
                        Id=1,
                        Type = "Mobile",
                        Value = "09191111222",
                        CreatedDate = System.DateTime.Now,
                        UpdatedDate = System.DateTime.Now,
                    },
                    new BlackList
                    {
                        Id = 2,
                        Type = "Domain",
                        Value = "mail",
                        CreatedDate = System.DateTime.Now,
                        UpdatedDate = System.DateTime.Now
                    }
                );

            modelBuilder.Entity<AppData>().HasData(
                new AppData
                {
                    Id = 1,
                    Name = "Title",
                    DataType = "string",
                    Value = "Mr.",
                    CreatedDate = System.DateTime.Now,
                    UpdatedDate = System.DateTime.Now
                },
                new AppData
                {
                    Id = 2,
                    Name = "Title",
                    DataType = "string",
                    Value = "Ms.",
                    CreatedDate = System.DateTime.Now,
                    UpdatedDate = System.DateTime.Now
                },
                new AppData
                {
                    Id = 3,
                    Name = "Title",
                    DataType = "string",
                    Value = "Mrs.",
                    CreatedDate = System.DateTime.Now,
                    UpdatedDate = System.DateTime.Now
                },
                new AppData
                {
                    Id = 4,
                    Name = "EstablishmentFee",
                    DataType = "decimal",
                    Value = "300",
                    CreatedDate = System.DateTime.Now,
                    UpdatedDate = System.DateTime.Now
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product {
                    Id = 1,
                    Name = "Product A",
                    Description = "The loan is interest-free",
                    InterestRate = 0,
                    APRPeriod = 0,  //Annual Percentage Rate period
                    MinimumDuration = 0,
                    NoInterestFree = false,
                    CreatedDate = System.DateTime.Now,
                    UpdatedDate = System.DateTime.Now
                },
                new Product {
                    Id = 2,
                    Name = "ProductB",
                    Description = "The first 2 months is free",
                    InterestRate = 6,
                    APRPeriod = 2,  //Annual Percentage Rate period
                    MinimumDuration = 6,
                    NoInterestFree = false,
                    CreatedDate = System.DateTime.Now,
                    UpdatedDate = System.DateTime.Now
                },
                new Product {
                    Id = 3,
                    Name = "ProductC",
                    Description = "No Interest Free",
                    InterestRate = 6,
                    APRPeriod = 0,  //Annual Percentage Rate period
                    MinimumDuration = 0,
                    NoInterestFree = true,
                    CreatedDate = System.DateTime.Now,
                    UpdatedDate = System.DateTime.Now
                }
            );  
        }
    }
}
