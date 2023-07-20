using System.ComponentModel.DataAnnotations;

namespace eMoviesTickets.Models
{
    public class Director
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        //Relationship
        public List<Movie> Movies { get; set; } //Director can have multiple movies
    }
}
