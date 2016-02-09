using System;
using System.Collections.Generic;

namespace HomeCinema.Entities
{
    public class Genre : IEntityBase
    {
        public Genre()
        {
            Movies = new List<Movie>();
        }
        public int ID { get; set; }

        public string Name { get; set; }

        public vitual ICollection<Movie> Movies { get; set; }
    }
}
