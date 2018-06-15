using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace abyNa3.Web.Models
{
    public class UserViewModel
    {
        [HiddenInput]
        public Int32 Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}