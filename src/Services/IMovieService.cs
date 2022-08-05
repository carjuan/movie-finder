using MovieFinder.Models;

namespace MovieFinder.Services;

public interface IMovieService
{
    IEnumerable<Movie> GetAllMockMovies();
}
