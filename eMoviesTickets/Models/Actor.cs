using System.ComponentModel.DataAnnotations;

namespace eMoviesTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required (ErrorMessage = "Profile Picture is required!")]
        public string? ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Actor Full Name is required!")]
        public string? FullName { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Actor Description is required!")]
        public string? Description { get; set; }

        //Relationship
        public List<Actor_Movie> Actors_Movies { get; set; }

    }
}
