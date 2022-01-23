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
    public class PostsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IPostRepository repository;

        public PostsController(AppDbContext context, IPostRepository _repository)
        {
            _context = context;
            repository = _repository;
        }

        // GET: api/Users
        [HttpGet]
        public List<Post> GetPosts()
        {
            return (repository.Get().ToList());
        }





        [HttpPut("{id}")]
        public List<Post> PutPosts(Post post)
        {
            if (ModelState.IsValid)
            {

                repository.Update(post);
            }



            return repository.Get().ToList();

        }


        [HttpPost]
        public List<Post> PostPost(Post post)
        {
            repository.Add(post);
            return repository.Get().ToList();
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public List<Post> DeletePost(int id)
        {
            repository.Delete(id);
            return repository.Get().ToList();
        }

        private bool PostExists(int id)
        {
            return _context.Posts.Any(e => e.Id == id);
        }
    }
}

