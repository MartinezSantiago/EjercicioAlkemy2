using System;

namespace EjercicioAlkemy2.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public virtual int PostId { get; set; }
    }
}
