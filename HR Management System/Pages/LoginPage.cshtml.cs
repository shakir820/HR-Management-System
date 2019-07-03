﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HR_Management_System.Pages
{
    public class LoginPageModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        public LoginPageModel(HRMS_DB_Context context)
        {
            _db = context;
        }

        public List<UserModel> Users { get; set; }

       




        //public long Id { get; set; }

        //public string Name { get; set; }
        [BindProperty]
        [Required]
        public string UserName { get; set; }
      
        //[EmailAddress]
        //public string Email { get; set; }

        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //[Display(Name = "Remember me?")]
        //public bool RememberMe { get; set; }


        public void OnGet()
        {
            var yes = _db.Users.Any();
        }

        public IActionResult OnPostAsync()
        {
            var _user = _db.Users.Where( a => a.UserName == UserName).ToList().SingleOrDefault();

            if(_user == null)
            {
                return Page();
            }

            if(Password == _user.Password)
            {
                //var acc = new AccountManageModel(_user);
                //ViewData.Add("User_Name", (string)_user.Name);
                return RedirectToPage("/AdminDashboard", _user);
            }
            else
            {
                return Page();
            }
        }
    }
}