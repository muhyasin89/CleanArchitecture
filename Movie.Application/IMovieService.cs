using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Application
{
    public internal interface IMovieService
    {
        List<Movie> GetAllMovies();
    }
}
