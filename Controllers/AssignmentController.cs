﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using KonusarakOgrenCase.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KonusarakOgrenCase.Controllers
{
    [Authorize]
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
            var exam = exams[a];
            List<string> alist = new List<string>();
            string q1 = exam.CorrectAnswer1;
            alist.Add(q1);
            string q2 = exam.CorrectAnswer2;
            alist.Add(q2);
            string q3 = exam.CorrectAnswer3;
            alist.Add(q3);
            string q4 = exam.CorrectAnswer4;
            alist.Add(q4);
            ViewBag.Answers = alist;
            return View(exam);
        }
    }
}
