using System.ComponentModel.DataAnnotations;

namespace eMoviesTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Cinema Logo")]
        public string? Logo { get; set; }

        [Display(Name = "Cinema Name")]
        public string? CinemaName { get; set; }

        [Display(Name = "Cinema Description")]
        public string? CinemaDescription { get; set; }

        //Relationship
        public List<Movie> Movies { get; set; } //Cinema can have multiple movies
    }
}
