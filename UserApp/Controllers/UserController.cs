using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserApp.Entity;
using UserApp.Models;
using UserApp.Service;

namespace UserApp.Controllers
{
    [Route("[controller]/[action]")]
    public class UserController : Controller
    {
        private readonly UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            List<UserViewModel> models = new List<UserViewModel>();

            var users = _userService.GetAllUsers();
            foreach (var user in users)
            {
                models.Add(new UserViewModel
                {
                    Id = user.Id,
                    BirthDate = user.BirthDate,
                    Email = user.Email,
                    Gender = user.Gender,
                    GitHubAccountUrl = user.GitHubAccountUrl,
                    Name = user.Name,
                    Surname = user.Surname
                });
            }
            return View(models);
        }


        [HttpGet]
        public IActionResult Add()
        {
            var model = new UserViewModel();
            SelectListItem[] genderList = new SelectListItem[]
            {
                new SelectListItem(){Text="Seçiniz"},
                new SelectListItem(){Text="Kadın",Value="Female"},
                new SelectListItem(){Text="Erkek",Value="Male"}
            };
            ViewBag.GenderList = genderList;
            return View(model);
        }


        [HttpPost]
        public IActionResult Add(UserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                    SelectListItem[] genderList = new SelectListItem[]
                {
                    new SelectListItem(){Text="Seçiniz"},
                    new SelectListItem(){Text="Kadın",Value="Female"},
                    new SelectListItem(){Text="Erkek",Value="Male"}
                };
                ViewBag.GenderList = genderList;

                return View(model);
            }
            UserEntity entity = new UserEntity
            {
                Id = model.Id,
                BirthDate = model.BirthDate,
                Email = model.Email,
                Gender = model.Gender,
                GitHubAccountUrl = model.GitHubAccountUrl,
                Name = model.Name,
                Surname = model.Surname
            };

            _userService.Add(entity);
            return RedirectToAction(nameof(Index), "User");
        }

  
        public IActionResult GetUser(int id)
        {
            var userEntity = _userService.GetUser(id);
            var model = new UserViewModel
            {
                Id = userEntity.Id,
                Name = userEntity.Name,
                Surname = userEntity.Surname,
                BirthDate = userEntity.BirthDate,
                Email = userEntity.Email,
                Gender = userEntity.Gender,
                GitHubAccountUrl = userEntity.GitHubAccountUrl
            };
            return View(model);
        }
       
        
        public IActionResult Edit(int id)
        {
            var userEntity = _userService.GetUser(id);
            var model = new UserViewModel
            {
                Id = userEntity.Id,
                Name = userEntity.Name,
                Surname = userEntity.Surname,
                BirthDate = userEntity.BirthDate,
                Email = userEntity.Email,
                Gender = userEntity.Gender,
                GitHubAccountUrl = userEntity.GitHubAccountUrl
            };
            SelectListItem[] genderList = new SelectListItem[]
            {
                new SelectListItem(){Text="Seçiniz"},
                new SelectListItem(){Text="Kadın",Value="Female"},
                new SelectListItem(){Text="Erkek",Value="Male"}
            };
            ViewData["GenderList"] = genderList;
            return View(model);
        }


        [HttpPost]
        public IActionResult Edit(UserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                SelectListItem[] genderList = new SelectListItem[]
            {
                    new SelectListItem(){Text="Seçiniz"},
                    new SelectListItem(){Text="Kadın",Value="Female"},
                    new SelectListItem(){Text="Erkek",Value="Male"}
            };
                ViewData["GenderList"] = genderList;
                return View(model);
            }
            UserEntity entity = new UserEntity
            {
                Id = model.Id,
                BirthDate = model.BirthDate,
                Email = model.Email,
                Gender = model.Gender,
                GitHubAccountUrl = model.GitHubAccountUrl,
                Name = model.Name,
                Surname = model.Surname
            };
            _userService.Edit(entity);

            return RedirectToAction(nameof(Index), "User");
        }


        [HttpGet("{id}/{name}/{surname}")]
        public IActionResult Query(int id,string name,string surname)
        {
            var models = new List<UserViewModel>();
            var userEntityList = _userService.Query(id,name,surname);
            foreach (var item in userEntityList)
            {
                models.Add(new UserViewModel(){
                    Id = item.Id,
                    Name = item.Name,
                    Surname = item.Surname,
                    BirthDate = item.BirthDate,
                    Email = item.Email,
                    Gender = item.Gender,
                    GitHubAccountUrl = item.GitHubAccountUrl
                });
            }

            return View("Index", models);
        }

    }
}
