using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace LifeShare.Models
{
    public class Login
    {
        public String Email{ get; set; } = "admin@gmail.com";
        public string Senha { get; set; } = "admin";

    }
}