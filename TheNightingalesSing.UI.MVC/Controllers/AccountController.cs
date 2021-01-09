using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TheNightingalesSing.BLL.Abstract;
using TheNightingalesSing.Model.Entities;
using TheNightingalesSing.Model.Enums;
using TheNightingalesSing.UI.MVC.Helper;
using TheNightingalesSing.UI.MVC.Models;

namespace TheNightingalesSing.UI.MVC.Controllers
{
    public class AccountController : Controller
    {
        IUserBLL userBLL;
        public AccountController(IUserBLL bll)
        {
            userBLL = bll;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserVM userVM)
        {
            try
            {
                User user = new User
                {
                    ID = 0,
                    FirstName = userVM.FirstName,
                    LastName = userVM.LastName,
                    UserName = userVM.UserName,
                    Email = userVM.Email,
                    Address=userVM.Adress
                };
                
                userBLL.InsertUser(user,userVM.Password);

                bool result = MailHelper.SendActivationCode(user.UserName, user.Email, user.ActivationCode);

                if (result)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    ViewBag.Message = "Activasyon Kodu gönderilemedi. Bilgilerinizi kontrol ediniz";
                    return View();
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
        public IActionResult ActivationUser(Guid id)
        {
            User newUser = userBLL.GetUserByActCode(id);
            if (newUser != null)
            {
                newUser.IsActive = true;
                userBLL.Update(newUser);
                return RedirectToAction("Login");
            }
            else
            {
                ViewBag.Message = "Aktif edilecek kullanıcı bulunamadı.";
                return View();
            }
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginVM login)
        {
            try
            {
                User loginUser = userBLL.GetUserByLoginData(login.UserName, login.Password);
                if (loginUser != null)
                {
                    List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,loginUser.UserName),
                    new Claim(ClaimTypes.Role,loginUser.Role.ToString())
                };
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                    if (loginUser.Role == UserRole.Admin)
                    {
                        return RedirectToAction("Index", "Admin", new { area = "Admin" });
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ViewBag.Message = "Kullanıcı bilgilerinizi kontrol ediniz.";
                }
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
        public IActionResult LogOff()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
