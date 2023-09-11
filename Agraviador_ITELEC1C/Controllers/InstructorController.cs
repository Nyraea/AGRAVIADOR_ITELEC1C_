using Microsoft.AspNetCore.Mvc;
using Agraviador_ITELEC1C.Models;

namespace Agraviador_ITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    Id= 1,FirstName = "Maria",LastName = "Edang", Rank = Rank.Professor, HiringDate = DateTime.Parse("2022-01-04"), IsTenured = true
                },
                new Instructor()
                {
                    Id= 2,FirstName = "Jobert",LastName = "Magtamo", Rank = Rank.AssistantProfessor, HiringDate = DateTime.Parse("2020-08-26"), IsTenured = false
                },
                new Instructor()
                {
                    Id= 3,FirstName = "Sinturon",LastName = "Dela Cruz", Rank = Rank.AssociateProfessor, HiringDate = DateTime.Parse("2019-04-16"), IsTenured = false
                }
            };
        public IActionResult Index()
        {

            return View(InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();
        }

    }
}

