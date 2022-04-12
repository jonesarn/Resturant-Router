using Microsoft.EntityFrameworkCore;

namespace ResturantRaterAPI
{
    public class ResturantDbContext : DbContext
    {
        public ResturantDbContext(DbContextOptions<ResturantDbContext>options : base(options){

        }
    }
}