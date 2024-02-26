using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class CreateCinemaDto
{
    [Required(ErrorMessage = "O campo Nome é obrigatório.")]

    public string Name { get; set; }
    public int AddressId { get; set; }
}
