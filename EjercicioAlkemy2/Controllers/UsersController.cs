using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EjercicioAlkemy2.Context;
using EjercicioAlkemy2.Models;
using EjercicioAlkemy2.Repository;

namespace EjercicioAlkemy2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController:ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IUserRepository repository;

        public UsersController(AppDbContext context,IUserRepository _repository)
        {
            _context = context;
            repository = _repository;
        }

        // GET: api/Users
        [HttpGet]
        public List<User> GetUsers()
        {
            return (repository.Get().ToList());
        }

      
      

        
        [HttpPut("{id}")]
        public List<User> PutUser(User user)
        {
            if (ModelState.IsValid)
            {

                repository.Update(user);
            }



            return repository.Get().ToList();
            
        }

        
        [HttpPost]
        public List<User> PostUser(User user)
        {
            repository.Add(user);
            return repository.Get().ToList();
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public List<User> DeleteUser(int id)
        {
            repository.Delete(id);
            return repository.Get().ToList();
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
