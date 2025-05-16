using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SimpleSchool.Data;
using Simpleschool.Models;


namespace SimpleSchool.Controllers
{
    public class VakkenController : Controller
    {
        private readonly SimpleSchoolContext _context;

        public VakkenController(SimpleSchoolContext context) // Fixed extra closing parenthesis
        {
            _context = context;
        }

        // Other methods remain unchanged
    }

    // Other methods remain unchanged
}
