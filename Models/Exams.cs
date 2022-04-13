using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace KonusarakOgrenCase.Models
{
    public class Exams
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Essay { get; set; }
        public string Title1 { get; set; }
        public string Option1A { get; set; }
        public string Option1B { get; set; }
        public string Option1C { get; set; }
        public string Option1D { get; set; }
        public string CorrectAnswer1 { get; set; }
        public string Title2 { get; set; }
        public string Option2A { get; set; }
        public string Option2B { get; set; }
        public string Option2C { get; set; }
        public string Option2D { get; set; }
        public string CorrectAnswer2 { get; set; }
        public string Title3 { get; set; }
        public string Option3A { get; set; }
        public string Option3B { get; set; }
        public string Option3C { get; set; }
        public string Option3D { get; set; }
        public string CorrectAnswer3 { get; set; }
        public string Title4 { get; set; }
        public string Option4A { get; set; }
        public string Option4B { get; set; }
        public string Option4C { get; set; }
        public string Option4D { get; set; }
        public string CorrectAnswer4 { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
