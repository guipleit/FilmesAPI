using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class ReadMovieDto
{
    public int Duration { get; set; }
    public string Genre { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime QueryTime { get; set; } = DateTime.Now;
    public ICollection<ReadSessionDto> Sessions { get; set; }
}
