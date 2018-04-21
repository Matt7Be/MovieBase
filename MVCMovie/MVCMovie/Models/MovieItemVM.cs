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

        [Display(Name = "Description")]
        public string Description { get; set; }

        public int Year { get; set; }

        [Display(Name = "Rating")]
        public byte Rating { get; set; }

        [Display(Name = "Director")]
        public string Director { get; set; }

        [Display(Name = "Actors")]
        public ICollection<MovieActorVM> Actors;
    }
}
