using System.ComponentModel.DataAnnotations;

namespace HttpReplApi.Models
{
    public class Band
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
