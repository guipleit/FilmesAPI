using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Movie
{
    [Required]
    [Key]
    public int Id { get; set; }
    [Range(60, 500, ErrorMessage = "A duração deve ser entre 60 e 500 minutos.")]
    public int Duration { get; set; }
    [Required(ErrorMessage = "O título é obrigatório.")]
    public string Genre { get; set; }
    [Required(ErrorMessage = "O título é obrigatório.")]
    public string Title { get; set; }
    [MaxLength(50)]
    public string Description { get; set; }
    public virtual ICollection<Session> Sessions { get; set; }

}
