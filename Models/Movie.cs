namespace MovieFinder.Models;

public class Movie
{
    public string? Popularity { get; set; }
    public int VoteCount { get; set; }
    public bool Video { get; set; }
    public string? PosterPath { get; set; }
    public int Id { get; set; }
    public bool Adult { get; set; }
    public string? BackDropPath { get; set; }
    public string? OriginalLanguage { get; set; }
    public string? OriginalTitle { get; set; }
    public Tuple<int>? GenreIds { get; set; }
    public string? Title { get; set; }
    public double VoteAverage { get; set; }
    public string? Overview { get; set; }
    public DateTime ReleaseDate { get; set; }
    /* http://image.tmdb.org/t/p/w220_and_h330_face<PosterPath>*/
}

