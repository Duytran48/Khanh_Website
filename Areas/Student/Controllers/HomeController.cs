using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Khanh_Project.Models;

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
                Overview = new RecentActivityOverview
                {
                    RecentVocabTopic = "Tuyển Dụng & Nhân Sự (Personnel)",
                    RecentVocabCount = 45,
                    RecentVocabTime = "Hôm nay, 14:30",

                    RecentExamTitle = "ETS TOEIC 2024 - Test 01",
                    RecentExamScore = 825,
                    RecentExamTotal = 990,
                    TargetScore = 850,
                    MissingScore = 25,
                    RecentExamDate = "Hôm qua, 20:15",

                    RecentGrammarTitle = "Mệnh Đề Quan Hệ & Rút Gọn",
                    RecentGrammarLevel = "Trung cấp - 650+",
                    RecentGrammarTime = "Hôm nay, 09:10"
                },
                AvailableExams = new List<ToeicExam>
                {
                    new ToeicExam
                    {
                        Id = 1,
                        Title = "ETS TOEIC 2024 - Test 01 (Full Format)",
                        Category = "Full Test",
                        Series = "ETS",
                        DurationMinutes = 120,
                        TotalQuestions = 200,
                        ParticipantsCount = 3840,
                        Rating = 4.9,
                        Tag = "Hot nhất",
                        Description = "Bộ đề sát đề thi thật nhất năm 2024 từ Viện Khảo thí Giáo dục Hoa Kỳ (ETS).",
                        Status = "completed",
                        CompletedQuestions = 200,
                        Score = 825
                    },
                    new ToeicExam
                    {
                        Id = 2,
                        Title = "ETS TOEIC 2024 - Test 02 (Listening & Reading)",
                        Category = "Full Test",
                        Series = "ETS",
                        DurationMinutes = 120,
                        TotalQuestions = 200,
                        ParticipantsCount = 2950,
                        Rating = 4.8,
                        Tag = "Mới cập nhật",
                        Description = "Đầy đủ 7 Part với giọng đọc chuẩn Bắc Mỹ, Anh, Úc và lời giải chi tiết.",
                        Status = "in-progress",
                        CompletedQuestions = 115,
                        Score = null
                    },
                    new ToeicExam
                    {
                        Id = 3,
                        Title = "Hacker TOEIC 3 - Actual Practice Test 05",
                        Category = "Nâng cao",
                        Series = "HACKER",
                        DurationMinutes = 120,
                        TotalQuestions = 200,
                        ParticipantsCount = 1890,
                        Rating = 4.9,
                        Tag = "Mục tiêu 800+",
                        Description = "Độ khó cao hơn đề thi thật 10-15%, phù hợp cho các bạn muốn bứt phá band 850+.",
                        Status = "not-started",
                        CompletedQuestions = 0,
                        Score = null
                    },
                    new ToeicExam
                    {
                        Id = 4,
                        Title = "Big Step TOEIC 3 - Test 01 (Chinh phục 750+)",
                        Category = "Full Test",
                        Series = "BIGSTEP",
                        DurationMinutes = 120,
                        TotalQuestions = 200,
                        ParticipantsCount = 2420,
                        Rating = 4.9,
                        Tag = "Toàn diện",
                        Description = "Bộ đề kinh điển phân tích sâu các dạng bẫy ngữ pháp và từ vựng xuất hiện trong đề TOEIC.",
                        Status = "completed",
                        CompletedQuestions = 200,
                        Score = 780
                    },
                    new ToeicExam
                    {
                        Id = 5,
                        Title = "New Economy TOEIC Test 03",
                        Category = "Full Test",
                        Series = "ECONOMY",
                        DurationMinutes = 120,
                        TotalQuestions = 200,
                        ParticipantsCount = 2100,
                        Rating = 4.7,
                        Tag = "Kinh điển",
                        Description = "Tổng hợp đề luyện phản xạ nghe và đọc hiểu văn bản thương mại thực tế.",
                        Status = "in-progress",
                        CompletedQuestions = 65,
                        Score = null
                    },
                    new ToeicExam
                    {
                        Id = 6,
                        Title = "Hacker TOEIC 2 - Practice Test 01",
                        Category = "Nâng cao",
                        Series = "HACKER",
                        DurationMinutes = 120,
                        TotalQuestions = 200,
                        ParticipantsCount = 1760,
                        Rating = 4.8,
                        Tag = "Độ khó cao",
                        Description = "Rèn luyện kỹ năng giải quyết các câu hỏi Part 3, 4 dài và đoạn văn đọc hiểu Part 7.",
                        Status = "not-started",
                        CompletedQuestions = 0,
                        Score = null
                    }
                },
                VocabTopics = new List<VocabularyTopic>
                {
                    new VocabularyTopic
                    {
                        Id = 1,
                        Title = "Hợp Đồng & Đàm Phán (Contracts)",
                        Description = "Các điều khoản thương lượng, ký kết văn bản và thỏa thuận kinh doanh.",
                        Icon = "bi-file-earmark-text-fill",
                        TotalWords = 50,
                        LearnedWords = 50,
                        Status = "completed",
                        TargetBand = "600+"
                    },
                    new VocabularyTopic
                    {
                        Id = 2,
                        Title = "Tài Chính & Doanh Thu (Finance)",
                        Description = "Báo cáo doanh số, thuế, phân tích chi phí và thị trường đầu tư chứng khoán.",
                        Icon = "bi-cash-coin",
                        TotalWords = 60,
                        LearnedWords = 42,
                        Status = "in-progress",
                        TargetBand = "700+"
                    },
                    new VocabularyTopic
                    {
                        Id = 3,
                        Title = "Quản Trị Văn Phòng (General Business)",
                        Description = "Giao tiếp nội bộ, phân công dự án, gửi email và lịch trình làm việc.",
                        Icon = "bi-briefcase-fill",
                        TotalWords = 50,
                        LearnedWords = 28,
                        Status = "in-progress",
                        TargetBand = "500+"
                    },
                    new VocabularyTopic
                    {
                        Id = 4,
                        Title = "Tuyển Dụng & Nhân Sự (Personnel)",
                        Description = "Quy trình phỏng vấn, hồ sơ ứng viên, thăng chức và chính sách bảo hiểm.",
                        Icon = "bi-people-fill",
                        TotalWords = 45,
                        LearnedWords = 45,
                        Status = "completed",
                        TargetBand = "650+"
                    },
                    new VocabularyTopic
                    {
                        Id = 5,
                        Title = "Du Lịch & Đặt Phòng (Travel & Hotel)",
                        Description = "Hành trình bay, thủ tục hải quan, đặt phòng nghỉ dưỡng và hội nghị quốc tế.",
                        Icon = "bi-airplane-engines-fill",
                        TotalWords = 50,
                        LearnedWords = 0,
                        Status = "not-started",
                        TargetBand = "550+"
                    },
                    new VocabularyTopic
                    {
                        Id = 6,
                        Title = "Mua Sắm & Hậu Cần (Shopping & Shipping)",
                        Description = "Đặt đơn hàng, chuỗi cung ứng, vận chuyển kho bãi và chính sách hoàn trả.",
                        Icon = "bi-box-seam-fill",
                        TotalWords = 55,
                        LearnedWords = 0,
                        Status = "not-started",
                        TargetBand = "600+"
                    }
                }
            };

            return View(viewModel);
        }

        public IActionResult Exams()
        {
            var viewModel = GetSampleHomeViewModel();
            return View(viewModel);
        }

        public IActionResult Vocab()
        {
            var viewModel = GetSampleHomeViewModel();
            return View(viewModel);
        }

        public IActionResult Grammar()
        {
            var viewModel = GetSampleHomeViewModel();
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        private HomeViewModel GetSampleHomeViewModel()
        {
            return new HomeViewModel
            {
                UserName = "Khánh (Học viên)",
                TargetScore = 800,
                CurrentStreak = 7,
                Overview = new RecentActivityOverview
                {
                    RecentVocabTopic = "Tuyển Dụng & Nhân Sự (Personnel)",
                    RecentVocabCount = 45,
                    RecentVocabTime = "Hôm nay, 14:30",

                    RecentExamTitle = "ETS TOEIC 2024 - Test 01",
                    RecentExamScore = 825,
                    RecentExamTotal = 990,
                    TargetScore = 850,
                    MissingScore = 25,
                    RecentExamDate = "Hôm qua, 20:15",

                    RecentGrammarTitle = "Mệnh Đề Quan Hệ & Rút Gọn",
                    RecentGrammarLevel = "Trung cấp - 650+",
                    RecentGrammarTime = "Hôm nay, 09:10"
                },
                AvailableExams = new List<ToeicExam>
                {
                    new ToeicExam
                    {
                        Id = 1,
                        Title = "ETS TOEIC 2024 - Test 01 (Full Format)",
                        Category = "Full Test",
                        Series = "ETS",
                        DurationMinutes = 120,
                        TotalQuestions = 200,
                        ParticipantsCount = 3840,
                        Rating = 4.9,
                        Tag = "Hot nhất",
                        Description = "Bộ đề sát đề thi thật nhất năm 2024 từ Viện Khảo thí Giáo dục Hoa Kỳ (ETS).",
                        Status = "completed",
                        CompletedQuestions = 200,
                        Score = 825
                    },
                    new ToeicExam
                    {
                        Id = 2,
                        Title = "ETS TOEIC 2024 - Test 02 (Listening & Reading)",
                        Category = "Full Test",
                        Series = "ETS",
                        DurationMinutes = 120,
                        TotalQuestions = 200,
                        ParticipantsCount = 2950,
                        Rating = 4.8,
                        Tag = "Mới cập nhật",
                        Description = "Đầy đủ 7 Part với giọng đọc chuẩn Bắc Mỹ, Anh, Úc và lời giải chi tiết.",
                        Status = "in-progress",
                        CompletedQuestions = 115,
                        Score = null
                    },
                    new ToeicExam
                    {
                        Id = 3,
                        Title = "Hacker TOEIC 3 - Actual Practice Test 05",
                        Category = "Nâng cao",
                        Series = "HACKER",
                        DurationMinutes = 120,
                        TotalQuestions = 200,
                        ParticipantsCount = 1890,
                        Rating = 4.9,
                        Tag = "Mục tiêu 800+",
                        Description = "Độ khó cao hơn đề thi thật 10-15%, phù hợp cho các bạn muốn bứt phá band 850+.",
                        Status = "not-started",
                        CompletedQuestions = 0,
                        Score = null
                    },
                    new ToeicExam
                    {
                        Id = 4,
                        Title = "Big Step TOEIC 3 - Test 01 (Chinh phục 750+)",
                        Category = "Full Test",
                        Series = "BIGSTEP",
                        DurationMinutes = 120,
                        TotalQuestions = 200,
                        ParticipantsCount = 2420,
                        Rating = 4.9,
                        Tag = "Toàn diện",
                        Description = "Bộ đề kinh điển phân tích sâu các dạng bẫy ngữ pháp và từ vựng xuất hiện trong đề TOEIC.",
                        Status = "completed",
                        CompletedQuestions = 200,
                        Score = 780
                    },
                    new ToeicExam
                    {
                        Id = 5,
                        Title = "New Economy TOEIC Test 03",
                        Category = "Full Test",
                        Series = "ECONOMY",
                        DurationMinutes = 120,
                        TotalQuestions = 200,
                        ParticipantsCount = 2100,
                        Rating = 4.7,
                        Tag = "Kinh điển",
                        Description = "Tổng hợp đề luyện phản xạ nghe và đọc hiểu văn bản thương mại thực tế.",
                        Status = "in-progress",
                        CompletedQuestions = 65,
                        Score = null
                    },
                    new ToeicExam
                    {
                        Id = 6,
                        Title = "Hacker TOEIC 2 - Practice Test 01",
                        Category = "Nâng cao",
                        Series = "HACKER",
                        DurationMinutes = 120,
                        TotalQuestions = 200,
                        ParticipantsCount = 1760,
                        Rating = 4.8,
                        Tag = "Độ khó cao",
                        Description = "Rèn luyện kỹ năng giải quyết các câu hỏi Part 3, 4 dài và đoạn văn đọc hiểu Part 7.",
                        Status = "not-started",
                        CompletedQuestions = 0,
                        Score = null
                    }
                },
                VocabTopics = new List<VocabularyTopic>
                {
                    new VocabularyTopic
                    {
                        Id = 1,
                        Title = "Hợp Đồng & Đàm Phán (Contracts)",
                        Description = "Các điều khoản thương lượng, ký kết văn bản và thỏa thuận kinh doanh.",
                        Icon = "bi-file-earmark-text-fill",
                        TotalWords = 50,
                        LearnedWords = 50,
                        Status = "completed",
                        TargetBand = "600+"
                    },
                    new VocabularyTopic
                    {
                        Id = 2,
                        Title = "Tài Chính & Doanh Thu (Finance)",
                        Description = "Báo cáo doanh số, thuế, phân tích chi phí và thị trường đầu tư chứng khoán.",
                        Icon = "bi-cash-coin",
                        TotalWords = 60,
                        LearnedWords = 42,
                        Status = "in-progress",
                        TargetBand = "700+"
                    },
                    new VocabularyTopic
                    {
                        Id = 3,
                        Title = "Quản Trị Văn Phòng (General Business)",
                        Description = "Giao tiếp nội bộ, phân công dự án, gửi email và lịch trình làm việc.",
                        Icon = "bi-briefcase-fill",
                        TotalWords = 50,
                        LearnedWords = 28,
                        Status = "in-progress",
                        TargetBand = "500+"
                    },
                    new VocabularyTopic
                    {
                        Id = 4,
                        Title = "Tuyển Dụng & Nhân Sự (Personnel)",
                        Description = "Quy trình phỏng vấn, hồ sơ ứng viên, thăng chức và chính sách bảo hiểm.",
                        Icon = "bi-people-fill",
                        TotalWords = 45,
                        LearnedWords = 45,
                        Status = "completed",
                        TargetBand = "650+"
                    },
                    new VocabularyTopic
                    {
                        Id = 5,
                        Title = "Du Lịch & Đặt Phòng (Travel & Hotel)",
                        Description = "Hành trình bay, thủ tục hải quan, đặt phòng nghỉ dưỡng và hội nghị quốc tế.",
                        Icon = "bi-airplane-engines-fill",
                        TotalWords = 50,
                        LearnedWords = 0,
                        Status = "not-started",
                        TargetBand = "550+"
                    },
                    new VocabularyTopic
                    {
                        Id = 6,
                        Title = "Mua Sắm & Hậu Cần (Shopping & Shipping)",
                        Description = "Đặt đơn hàng, chuỗi cung ứng, vận chuyển kho bãi và chính sách hoàn trả.",
                        Icon = "bi-box-seam-fill",
                        TotalWords = 55,
                        LearnedWords = 0,
                        Status = "not-started",
                        TargetBand = "600+"
                    }
                }
            };
        }
    }
}