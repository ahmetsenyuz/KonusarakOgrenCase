using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using KonusarakOgrenCase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KonusarakOgrenCase.Controllers
{
    public class AssignmentController : Controller
    {
        private readonly MyContext _context;

        public AssignmentController(MyContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Exam()
        {
            var exams = await _context.Exams.ToListAsync();
            Random rnd = new Random();
            var a = rnd.Next(0, exams.Count);
            var aas = exams[a];
            List<string> alist = new List<string>();
            string q1 = aas.CorrectAnswer1;
            alist.Add(q1);
            string q2 = aas.CorrectAnswer2;
            alist.Add(q2);
            string q3 = aas.CorrectAnswer3;
            alist.Add(q3);
            string q4 = aas.CorrectAnswer4;
            alist.Add(q4);
            ViewBag.Answers = alist;
            return View(exams[a]);
        }
    }
}
