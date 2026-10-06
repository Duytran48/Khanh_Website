using Microsoft.AspNetCore.Mvc;
using Khanh_Project.Models;

namespace Khanh_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.TotalStudents = 1420;
            ViewBag.TotalExams = 35;
            ViewBag.TotalSubmissionsToday = 286;
            ViewBag.AverageScore = 675;

            var recentExams = new List<ToeicExam>
            {
                new ToeicExam { Id = 1, Title = "ETS TOEIC 2024 - Test 01", Category = "Full Test", TotalQuestions = 200, ParticipantsCount = 3840, Rating = 4.9 },
                new ToeicExam { Id = 2, Title = "ETS TOEIC 2024 - Test 02", Category = "Full Test", TotalQuestions = 200, ParticipantsCount = 2950, Rating = 4.8 },
                new ToeicExam { Id = 3, Title = "Hacker TOEIC 3 - Test 05", Category = "Nâng cao", TotalQuestions = 200, ParticipantsCount = 1890, Rating = 4.9 },
                new ToeicExam { Id = 4, Title = "Mini Test 01 - Part 5 & 6", Category = "Mini Test", TotalQuestions = 46, ParticipantsCount = 5420, Rating = 4.9 }
            };

            return View(recentExams);
        }

        public IActionResult ManageExams()
        {
            return View();
        }

        public IActionResult ManageStudents()
        {
            return View();
        }
    }
}