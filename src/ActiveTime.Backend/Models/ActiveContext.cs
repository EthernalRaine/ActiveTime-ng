using Microsoft.EntityFrameworkCore;

namespace ActiveTime.Backend.Models
{
    public class ActiveContext : DbContext
    {
        public ActiveContext(DbContextOptions<ActiveContext> options) : base(options) 
        {
                
        }
    }
}