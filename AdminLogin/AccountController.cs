using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MyEshop.Classes;
using MyEshop.Models;
using SendMail;

namespace MyEshop.Controllers
{
    public class AccountController : Controller
    {
        Mvc_Eshop_DB_02Entities db=new Mvc_Eshop_DB_02Entities();
        // GET: Account

        [Route("Register")]
        public ActionResult Register()
        {
            return View();
        }

        [Route("Register")]
        [HttpPost]
        public ActionResult Register(RegisterViewModel register)
        {
            if (ModelState.IsValid)
            {
                if (!db.Users.Any(u => u.Email == register.Email.Trim().ToLower()))
                {
                    Users users=new Users()
                    {
                        Email = register.Email.Trim().ToLower(),
                        ActiveCode = Guid.NewGuid().ToString(),
                        IsActive = false,
                        Password = FormsAuthentication.HashPasswordForStoringInConfigFile(register.Pass,"MD5"),
                        RoleID = 2,
                        RegisterDate = DateTime.Now,
                        UserName = register.UserName
                    };
                    db.Users.Add(users);
                    db.SaveChanges();

                    string Body = PartialToStringClass.RenderPartialView("ManageEmail", "ActiveAccount", users);

                    SendEmailGmail.Send(users.Email,"ایمیل فعال سازی",Body);

                    return View("_MessageSuccessRegister", users);
                }
                else
                {
                    ModelState.AddModelError("Email","ایمیل وارد شده تکراری است");
                }
            }
            return View(register);
        }


        public ActionResult ActiveUser(string id)
        {
            var user = db.Users.FirstOrDefault(u => u.ActiveCode == id);

            if (user != null)
            {
                user.ActiveCode = Guid.NewGuid().ToString();
                user.IsActive = true;
                db.SaveChanges();

                ViewBag.IsOk = true;
            }


            return View();
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel login, string ReturnUrl="/")
        {
            if (ModelState.IsValid)
            {
                string Pass = FormsAuthentication.HashPasswordForStoringInConfigFile(login.Pass, "MD5");

                var user = db.Users.FirstOrDefault(u => u.UserName == login.UserName && u.Password == Pass);

                if (user != null)
                {
                    if (user.IsActive)
                    {
                        FormsAuthentication.SetAuthCookie(user.UserName,login.Remember);
                        return Redirect(ReturnUrl);
                    }
                    else
                    {
                        ModelState.AddModelError("UserName", "حساب کاربری شما فعال نشده است"); 
                    }
                }
                else
                {
                    ModelState.AddModelError("UserName","نام کاربری یا کلمه عبور اشتباه است");
                }
            }
            return View(login);
        }


        public ActionResult CheckUserLogin()
        {
            return PartialView();
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return Redirect("/");
        }


        public ActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ForgotPassword(RecoveryPassViewModel recovery)
        {

            if (ModelState.IsValid)
            {
                var user = db.Users.FirstOrDefault(u => u.Email == recovery.Email);
                if (user!=null)
                {
                    string Body = PartialToStringClass.RenderPartialView("ManageEmail", "ForgotPass", user);

                    SendEmailGmail.Send(user.Email, "بازیابی کلمه عبور", Body);
                }
                else
                {
                    ModelState.AddModelError("Email","ایمیل وارد شده صحیح نمی باشد");
                }
            }

            return View(recovery);
        }


        public ActionResult ChangePass(string id)
        {
            return View(new ChangePassViewModel()
            {
                ActiveCode = id
            });
        }


        [HttpPost]
        public ActionResult ChangePass(ChangePassViewModel password)
        {
            var user = db.Users.FirstOrDefault(u => u.ActiveCode == password.ActiveCode);

            if (user != null)
            {
                user.ActiveCode = Guid.NewGuid().ToString();
                string newPass = FormsAuthentication.HashPasswordForStoringInConfigFile(password.Pass, "MD5");
                user.Password = newPass;
                db.SaveChanges();
                ViewBag.IsChanged = true;
            }
            else
            {
                ViewBag.IsChanged = false;
            }
            return View();
        }
    }
}