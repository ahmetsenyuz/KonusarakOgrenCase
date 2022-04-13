using HtmlAgilityPack;
using KonusarakOgrenCase.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgrenCase.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ExamsController : Controller
    {
        private readonly MyContext _context;

        public ExamsController(MyContext context)
        {
            _context = context;
        }

        // get: exams
        public async Task<IActionResult> Index()
        {
            return View(await _context.Exams.ToListAsync());
        }
        public IActionResult Create()
        {
            HtmlAgilityPack.HtmlWeb website = new HtmlAgilityPack.HtmlWeb();
            var links = new List<Essays>();
            HtmlAgilityPack.HtmlDocument document = website.Load("https://www.wired.com/");
            var dataList = document.DocumentNode.SelectNodes("//div[@class='SummaryItemWrapper-gdEuvf bvhsay summary-item summary-item--has-margin-spacing summary-item--has-border summary-item--no-icon summary-item--text-align-left summary-item--layout-placement-side-by-side summary-item--layout-position-image-right summary-item--layout-proportions-33-66 summary-item--side-by-side-align-center summary-item--standard SummaryItemWrapper-bGkJDw ifBcbu summary-list__item']");
            foreach (HtmlNode node in dataList)
            {
                var paragraph = string.Empty;
                var path = node
                    .SelectSingleNode(
                        ".//div[@class='SummaryItemContent-gYA-Dbp bHOHql summary-item__content summary-item__content--no-rubric']//a")
                    .GetAttributeValue("href", string.Empty);
                var link = "https://www.wired.com" + path;
                HtmlAgilityPack.HtmlDocument document1 = website.Load(link);
                var pars = document1.DocumentNode.SelectNodes(".//div[@data-testid='BodyWrapper']//p");
                foreach (HtmlNode par in pars.Take(4))
                {
                    paragraph = paragraph+par.InnerText.Replace("&#x27;", "'")+"\n";
                }
                links.Add(new Essays()
                {
                    Header = node.SelectSingleNode(".//h2").InnerText.Replace("&#39;", "'"),
                    Path = link,
                    Paragraph = paragraph
                });
            }

            ViewBag.Essays = links;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Header,Essay,Title1,Option1A,Option1B,Option1C,Option1D,CorrectAnswer1,Title2,Option2A,Option2B,Option2C,Option2D,CorrectAnswer2,Title3,Option3A,Option3B,Option3C,Option3D,CorrectAnswer3,Title4,Option4A,Option4B,Option4C,Option4D,CorrectAnswer4")] Exams exams)
        {
            exams.CreatedDate = DateTime.Now;
            if (ModelState.IsValid)
            {
                _context.Add(exams);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(exams);
        }
        // GET: Exams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exams = await _context.Exams
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exams == null)
            {
                return NotFound();
            }

            return View(exams);
        }

        // POST: Exams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var exams = await _context.Exams.FindAsync(id);
            _context.Exams.Remove(exams);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExamsExists(int id)
        {
            return _context.Exams.Any(e => e.Id == id);
        }
    }
}
