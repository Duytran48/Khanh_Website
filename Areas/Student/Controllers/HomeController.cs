using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Khanh_Project.Models;
using Khanh_Project.Data;

namespace Khanh_Project.Areas.Student.Controllers
{
    [Area("Student")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var viewModel = new HomeViewModel
            {
                UserName = "Khánh (Học viên)",
                TargetScore = 800,
                CurrentStreak = 7,
                Overview = SeedData.GetOverview(),
                AvailableExams = SeedData.GetExams(),
                VocabTopics = SeedData.GetVocabTopics()
            };

            return View(viewModel);
        }

        public IActionResult Exams()
        {
            var viewModel = new HomeViewModel
            {
                UserName = "Khánh (Học viên)",
                AvailableExams = SeedData.GetExams()
            };
            return View(viewModel);
        }

        public IActionResult Vocab()
        {
            var viewModel = new HomeViewModel
            {
                UserName = "Khánh (Học viên)",
                VocabTopics = SeedData.GetVocabTopics()
            };
            return View(viewModel);
        }

        // Trang chi tiết học từ vựng theo từng chủ đề
        public IActionResult VocabDetail(int id)
        {
            var topics = SeedData.GetVocabTopics();
            var currentTopic = topics.FirstOrDefault(t => t.Id == id) ?? topics.First();
            var words = SeedData.GetWordsByTopicId(currentTopic.Id);

            var viewModel = new VocabDetailViewModel
            {
                Topic = currentTopic,
                Words = words
            };

            return View(viewModel);
        }

        public IActionResult Grammar()
        {
            var viewModel = new HomeViewModel
            {
                UserName = "Khánh (Học viên)"
            };
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}