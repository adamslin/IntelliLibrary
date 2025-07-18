using System.ComponentModel.DataAnnotations;

namespace LibraryInventoryApp.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Author { get; set; } = string.Empty;

        [Required]
        public string ISBN { get; set; } = string.Empty;

        public int Quantity { get; set; }
    }
}