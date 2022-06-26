using EcommerceWebApi.Interfaces;
using EcommerceWebApi.Models;
using EcommerceWebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EcommerceWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        EcommerceDBContext db;
        IJWTMangerRepository iJWTMangerRepository;
        public LoginController(EcommerceDBContext _db, IJWTMangerRepository _iJWTMangerRepository)
        {
            db = _db;
            iJWTMangerRepository = _iJWTMangerRepository;
        }

        [HttpGet]
        [Route("User")]
        public IEnumerable<TblLogin> Get()
        {
            return db.TblLogins;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            var token = iJWTMangerRepository.Authenicate(loginViewModel, false);
            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }
        [HttpPost]
        [Route("register")]
        public IActionResult Register(RegisterViewModel registerViewModel)
        {
            LoginViewModel login = new LoginViewModel();
            login.UserName = registerViewModel.UserName;
            login.UserLastName = registerViewModel.UserLastName;
            login.EmailId = registerViewModel.EmailId;
            login.Password = registerViewModel.Password;
            login.Gender = registerViewModel.Gender;
            var token = iJWTMangerRepository.Authenicate(login, true);
            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }
    }
}
