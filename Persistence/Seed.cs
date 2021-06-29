using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Publishers.Any()) return;
            
            var publishers = new List<Publisher>
            {
                new Publisher
                {
                    Title = "Minerva",
                    Address = "Rr. Konferenca e Pezes, Nr. 71,",
                    City = "Tirane",
                    Tel = "00355 42 478 007",
                    Email = "info@minervabotime.com",
                },
                new Publisher
                {
                    Title = "Minerva",
                    Address = "Rr. Konferenca e Pezes, Nr. 71,",
                    City = "Tirane",
                    Tel = "00355 42 478 007",
                    Email = "info@minervabotime.com",
                },
                new Publisher
                {
                    Title = "Minerva",
                    Address = "Rr. Konferenca e Pezes, Nr. 71,",
                    City = "Tirane",
                    Tel = "00355 42 478 007",
                    Email = "info@minervabotime.com",
                },
                new Publisher
                {
                   Title = "Minerva",
                    Address = "Rr. Konferenca e Pezes, Nr. 71,",
                    City = "Tirane",
                    Tel = "00355 42 478 007",
                    Email = "info@minervabotime.com",
                },
                new Publisher
                {
                   Title = "Minerva",
                    Address = "Rr. Konferenca e Pezes, Nr. 71,",
                    City = "Tirane",
                    Tel = "00355 42 478 007",
                    Email = "info@minervabotime.com",
                },
                new Publisher
                {
                    Title = "Minerva",
                    Address = "Rr. Konferenca e Pezes, Nr. 71,",
                    City = "Tirane",
                    Tel = "00355 42 478 007",
                    Email = "info@minervabotime.com",
                },
                new Publisher
                {
                   Title = "Minerva",
                    Address = "Rr. Konferenca e Pezes, Nr. 71,",
                    City = "Tirane",
                    Tel = "00355 42 478 007",
                    Email = "info@minervabotime.com",
                }
            };
               
           await context.Publishers.AddRangeAsync(publishers);
            await context.SaveChangesAsync();
        
    }
}
}