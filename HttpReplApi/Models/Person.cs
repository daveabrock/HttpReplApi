using System.ComponentModel.DataAnnotations;

namespace HttpReplApi.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
