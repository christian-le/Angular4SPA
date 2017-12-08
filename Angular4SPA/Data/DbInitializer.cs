using Angular4SPA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular4SPA.Data
{
    public static class DbInitializer
    {
        public static void Initialize(Angular4SPAContext context)
        {
            context.Database.EnsureCreated();

            // Look for any test data.
            if (context.TestData.Any())
            {
                return;   // DB has been seeded
            }

            var testData = new TestData
            {
                Username = "chaulehong",
                EmailAddress = "chaulehong@example.com",
                Password = "12345678",
                Currency = 321.45M
            };

            context.TestData.Add(testData);
            context.SaveChanges();
        }
    }
}
