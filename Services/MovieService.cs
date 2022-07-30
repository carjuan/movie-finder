using System.Text.Json;
using System.Diagnostics;
using System.Collections;
using MovieFinder.ConsoleOutDebug;
using MovieFinder.Models;

namespace MovieFinder.Services;

public class MovieService : IMovieService
{
    public List<Movie>? _movies;

    public IEnumerable<Movie> GetAllMockMovies()
    {
        return GetMoviesFromJason();
    }
    public IEnumerable<Movie> GetMoviesFromJason()
    {
        string MoviesJson = File.ReadAllText($"{Directory.GetCurrentDirectory()}/Models/mockMovieList.json");

        MoviesCollection movies = JsonSerializer.Deserialize<MoviesCollection>(MoviesJson);

        return movies.movies;
    }
}

public class MoviesCollection
{
    public List<Movie> movies { get; set; }
    public int count { get; }

    public int GetCount()
    {
        return movies.Count;
    }
}
