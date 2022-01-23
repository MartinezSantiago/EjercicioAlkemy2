using EjercicioAlkemy2.Context;
using EjercicioAlkemy2.Models;
using EjercicioAlkemy2.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EjercicioAlkemy2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ICommentRepository repository;

        public CommentsController(AppDbContext context, ICommentRepository _repository)
        {
            _context = context;
            repository = _repository;
        }

        // GET: api/Users
        [HttpGet]
        public List<Comment> GetComments()
        {
            return (repository.Get().ToList());
        }





        [HttpPut("{id}")]
        public List<Comment> PutComments(Comment comment)
        {
            if (ModelState.IsValid)
            {

                repository.Update(comment);
            }



            return repository.Get().ToList();

        }


        [HttpPost]
        public List<Comment> PostComment(Comment comment)
        {
            repository.Add(comment);
            return repository.Get().ToList();
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public List<Comment> DeleteComment(int id)
        {
            repository.Delete(id);
            return repository.Get().ToList();
        }

        private bool CommentExists(int id)
        {
            return _context.Comments.Any(e => e.Id == id);
        }
    }
}
