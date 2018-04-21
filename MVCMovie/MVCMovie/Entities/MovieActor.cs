using System;
using System.Collections.Generic;

namespace MVCMovie.Entities
{
    public partial class MovieActor
    {
        public int MovieId { get; set; }
        public int ActorId { get; set; }

        public Person Actor { get; set; }
        public Movie Movie { get; set; }
    }
}
