using FilmesAPI.Models;

namespace FilmesAPI.Data.Dtos
{
    public class CreateAddressDto
    {
        public string Street { get; set; }
        public int Number { get; set; }

        public int AddressId { get; set; }
    }
}
