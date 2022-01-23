using System;
using System.Collections.Generic;

namespace EjercicioAlkemy2.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }=DateTime.Now;
        public virtual int UserId { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
