using System.ComponentModel.DataAnnotations;

namespace HttpReplApi
{
    public record Band(int Id, [Required] string Name);
    public record Movie(int Id, [Required] string Name, int ReleaseYear);
    public record Person(int Id, [Required] string FirstName, string LastName);
}
