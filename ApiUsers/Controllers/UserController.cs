using Application.Interfaces;
using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace ApiUsers.Controllers
{
    public class UserController : Controller
    {
        private readonly IServiceUser _service;
        public UserController(IServiceUser service) 
        {
            _service = service;
        }

        [HttpGet]
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            try 
            {
                var users = await _service.GetUsers();
                ViewBag.Users = users.Users;
                return View();
            }
            catch (Exception ex) 
            { 
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("ViewCreateUser")]
        public IActionResult ViewCreateUser() 
        {
            try 
            {
                return View();
            }
            catch (Exception e) 
            { 
                return BadRequest();
            }   
        }

        [HttpPost]
        [Route("AddUser")]
        public async Task<IActionResult> Add(User user) 
        {
            try 
            {
               await _service.Add(user);
               return RedirectToAction("Index");
            }
            catch (Exception e) 
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("Edit")]
        public async Task<IActionResult> Edit(User user) 
        {
            try
            {
                await _service.Edit(user);
                return RedirectToAction("Index");
            }
            catch (Exception e) 
            { 
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("Delete")]
        public async Task<IActionResult> Delete(int id) 
        {
            try 
            { 
                await _service.Delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception e) 
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("ViewEditUser")]
        public IActionResult ViewEditUser(int id) 
        {
            try 
            {
                var response = _service.GetUser(id);
                ViewBag.User = response.Result.user;
                return View();
            }
            catch (Exception e) 
            {
                return BadRequest();
            }

        }
    }
}
