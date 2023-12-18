using OnlineTicketsMovieManagement.Data.Base;
using OnlineTicketsMovieManagement.Models;

namespace OnlineTicketsMovieManagement.Data.Services
{
    public class ProducersService: EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context) { }
        
    }
}
 