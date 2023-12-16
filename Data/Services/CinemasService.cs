using OnlineTicketsMovieManagement.Data.Base;
using OnlineTicketsMovieManagement.Models;

namespace OnlineTicketsMovieManagement.Data.Services
{
    public class CinemasService: EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context) { }
    }
}
