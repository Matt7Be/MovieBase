using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMovie.Models
{
    public enum RatingAction
    {
        Up,
        Down
    }

    public class MovieItemVM
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [Display(Name = "What happens?")]
        public string Description { get; set; }

        public int Year { get; set; }

        [Display(Name = "How much is this rated?")]
        public byte Rating { get; set; }

        [Display(Name = "The Director")]
        public string Director { get; set; }

        [Display(Name = "All the actors")]
        public ICollection<MovieActorVM> Actors;
    }
}
