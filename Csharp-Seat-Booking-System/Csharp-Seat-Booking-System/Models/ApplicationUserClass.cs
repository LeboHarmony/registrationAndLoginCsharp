using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Csharp_Seat_Booking_System.Models
{
    public class ApplicationUserClass : DbContext
    {
        public ApplicationUserClass(DbContextOptions<ApplicationUserClass> options):base(options)
        {

        }

        public DbSet<UserClass> UserReg { get; set; }
    }
}
