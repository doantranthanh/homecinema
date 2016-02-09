using System;

namespace HomeCinema.Entities
{
    public class Error : IEntityBase
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string StrackTrace { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
