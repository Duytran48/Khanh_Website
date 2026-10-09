using Khanh_Project.Models;

namespace Khanh_Project.Data
{
    public static class SeedData
    {
        public static RecentActivityOverview GetOverview()
        {
            return new RecentActivityOverview
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
            };
        }

        public static List<ToeicExam> GetExams()
        {
            return new List<ToeicExam>
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
            };
        }

        public static List<VocabularyTopic> GetVocabTopics()
        {
            return new List<VocabularyTopic>
            {
                new VocabularyTopic
                {
                    Id = 1,
                    Title = "Hợp Đồng & Đàm Phán (Contracts)",
                    Description = "Các điều khoản thương lượng, ký kết văn bản và thỏa thuận kinh doanh.",
                    Icon = "bi-file-earmark-text-fill",
                    TotalWords = 10,
                    LearnedWords = 10,
                    Status = "completed",
                    TargetBand = "600+"
                },
                new VocabularyTopic
                {
                    Id = 2,
                    Title = "Tài Chính & Doanh Thu (Finance)",
                    Description = "Báo cáo doanh số, thuế, phân tích chi phí và thị trường đầu tư chứng khoán.",
                    Icon = "bi-cash-coin",
                    TotalWords = 10,
                    LearnedWords = 6,
                    Status = "in-progress",
                    TargetBand = "700+"
                },
                new VocabularyTopic
                {
                    Id = 3,
                    Title = "Quản Trị Văn Phòng (General Business)",
                    Description = "Giao tiếp nội bộ, phân công dự án, gửi email và lịch trình làm việc.",
                    Icon = "bi-briefcase-fill",
                    TotalWords = 10,
                    LearnedWords = 4,
                    Status = "in-progress",
                    TargetBand = "500+"
                },
                new VocabularyTopic
                {
                    Id = 4,
                    Title = "Tuyển Dụng & Nhân Sự (Personnel)",
                    Description = "Quy trình phỏng vấn, hồ sơ ứng viên, thăng chức và chính sách bảo hiểm.",
                    Icon = "bi-people-fill",
                    TotalWords = 10,
                    LearnedWords = 10,
                    Status = "completed",
                    TargetBand = "650+"
                },
                new VocabularyTopic
                {
                    Id = 5,
                    Title = "Du Lịch & Đặt Phòng (Travel & Hotel)",
                    Description = "Hành trình bay, thủ tục hải quan, đặt phòng nghỉ dưỡng và hội nghị quốc tế.",
                    Icon = "bi-airplane-engines-fill",
                    TotalWords = 10,
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
                    TotalWords = 10,
                    LearnedWords = 0,
                    Status = "not-started",
                    TargetBand = "600+"
                }
            };
        }

        public static List<VocabularyWord> GetWordsByTopicId(int topicId)
        {
            var allWords = GetAllWords();
            return allWords.Where(w => w.TopicId == topicId).ToList();
        }

        public static List<VocabularyWord> GetAllWords()
        {
            return new List<VocabularyWord>
            {
                // Topic 1: Contracts (Hợp đồng & Đàm phán)
                new VocabularyWord
                {
                    Id = 101,
                    TopicId = 1,
                    Word = "Agreement",
                    Phonetic = "/əˈɡriːmənt/",
                    PartOfSpeech = "noun",
                    Topic = "Contracts",
                    Meaning = "Hợp đồng, thỏa thuận, hiệp định",
                    Example = "The two companies reached a preliminary agreement on the merger."
                },
                new VocabularyWord
                {
                    Id = 102,
                    TopicId = 1,
                    Word = "Negotiate",
                    Phonetic = "/nəˈɡoʊʃieɪt/",
                    PartOfSpeech = "verb",
                    Topic = "Contracts",
                    Meaning = "Thương lượng, đàm phán",
                    Example = "The union is negotiating for higher wages and better working conditions."
                },
                new VocabularyWord
                {
                    Id = 103,
                    TopicId = 1,
                    Word = "Obligation",
                    Phonetic = "/ˌɑːblɪˈɡeɪʃn/",
                    PartOfSpeech = "noun",
                    Topic = "Contracts",
                    Meaning = "Nghĩa vụ, bổn phận theo hợp đồng",
                    Example = "Employers have an obligation to provide a safe workplace."
                },
                new VocabularyWord
                {
                    Id = 104,
                    TopicId = 1,
                    Word = "Clause",
                    Phonetic = "/klɔːz/",
                    PartOfSpeech = "noun",
                    Topic = "Contracts",
                    Meaning = "Điều khoản (trong hợp đồng)",
                    Example = "Please read the confidentiality clause carefully before signing."
                },
                new VocabularyWord
                {
                    Id = 105,
                    TopicId = 1,
                    Word = "Comply",
                    Phonetic = "/kəmˈplaɪ/",
                    PartOfSpeech = "verb",
                    Topic = "Contracts",
                    Meaning = "Tuân thủ, làm theo đúng quy định",
                    Example = "All suppliers must comply with our strict safety standards."
                },
                new VocabularyWord
                {
                    Id = 106,
                    TopicId = 1,
                    Word = "Binding",
                    Phonetic = "/ˈbaɪndɪŋ/",
                    PartOfSpeech = "adjective",
                    Topic = "Contracts",
                    Meaning = "Có tính ràng buộc (pháp lý)",
                    Example = "This document is legally binding on all participating parties."
                },
                new VocabularyWord
                {
                    Id = 107,
                    TopicId = 1,
                    Word = "Breach",
                    Phonetic = "/briːtʃ/",
                    PartOfSpeech = "noun / verb",
                    Topic = "Contracts",
                    Meaning = "Sự vi phạm hợp đồng / Vi phạm",
                    Example = "Failure to deliver the goods on time constitutes a breach of contract."
                },
                new VocabularyWord
                {
                    Id = 108,
                    TopicId = 1,
                    Word = "Terminate",
                    Phonetic = "/ˈtɜːrmɪneɪt/",
                    PartOfSpeech = "verb",
                    Topic = "Contracts",
                    Meaning = "Chấm dứt, hủy bỏ hợp đồng",
                    Example = "Either party may terminate the contract with a 30-day notice."
                },

                // Topic 2: Finance (Tài chính & Doanh thu)
                new VocabularyWord
                {
                    Id = 201,
                    TopicId = 2,
                    Word = "Revenue",
                    Phonetic = "/ˈrevənuː/",
                    PartOfSpeech = "noun",
                    Topic = "Finance",
                    Meaning = "Doanh thu, tổng thu nhập",
                    Example = "Company revenue increased by 15% in the fourth quarter."
                },
                new VocabularyWord
                {
                    Id = 202,
                    TopicId = 2,
                    Word = "Budget",
                    Phonetic = "/ˈbʌdʒɪt/",
                    PartOfSpeech = "noun",
                    Topic = "Finance",
                    Meaning = "Ngân sách tài chính",
                    Example = "The marketing department was allocated a budget of $50,000."
                },
                new VocabularyWord
                {
                    Id = 203,
                    TopicId = 2,
                    Word = "Expenditure",
                    Phonetic = "/ɪkˈspendɪtʃər/",
                    PartOfSpeech = "noun",
                    Topic = "Finance",
                    Meaning = "Chi phí, sự chi tiêu",
                    Example = "We must reduce capital expenditure to maintain cash reserves."
                },
                new VocabularyWord
                {
                    Id = 204,
                    TopicId = 2,
                    Word = "Audit",
                    Phonetic = "/ˈɔːdɪt/",
                    PartOfSpeech = "noun / verb",
                    Topic = "Finance",
                    Meaning = "Kiểm toán, sự kiểm tra sổ sách",
                    Example = "An independent firm was hired to conduct an annual financial audit."
                },
                new VocabularyWord
                {
                    Id = 205,
                    TopicId = 2,
                    Word = "Dividend",
                    Phonetic = "/ˈdɪvɪdend/",
                    PartOfSpeech = "noun",
                    Topic = "Finance",
                    Meaning = "Cổ tức",
                    Example = "Shareholders will receive a dividend of 50 cents per share."
                },
                new VocabularyWord
                {
                    Id = 206,
                    TopicId = 2,
                    Word = "Fiscal",
                    Phonetic = "/ˈfɪskl/",
                    PartOfSpeech = "adjective",
                    Topic = "Finance",
                    Meaning = "Thuộc tài chính, năm tài khóa",
                    Example = "The new fiscal year will begin on January 1st."
                },

                // Topic 4: Personnel (Tuyển dụng & Nhân sự)
                new VocabularyWord
                {
                    Id = 401,
                    TopicId = 4,
                    Word = "Candidate",
                    Phonetic = "/ˈkændɪdət/",
                    PartOfSpeech = "noun",
                    Topic = "Personnel",
                    Meaning = "Ứng viên ứng tuyển",
                    Example = "We interviewed six promising candidates for the marketing manager position."
                },
                new VocabularyWord
                {
                    Id = 402,
                    TopicId = 4,
                    Word = "Resume",
                    Phonetic = "/ˈrezəmeɪ/",
                    PartOfSpeech = "noun",
                    Topic = "Personnel",
                    Meaning = "Sơ yếu lý lịch, CV xin việc",
                    Example = "Please submit your resume along with two professional references."
                },
                new VocabularyWord
                {
                    Id = 403,
                    TopicId = 4,
                    Word = "Recruit",
                    Phonetic = "/rɪˈkruːt/",
                    PartOfSpeech = "verb",
                    Topic = "Personnel",
                    Meaning = "Tuyển dụng nhân viên mới",
                    Example = "The tech company is actively recruiting talented software engineers."
                },
                new VocabularyWord
                {
                    Id = 404,
                    TopicId = 4,
                    Word = "Probation",
                    Phonetic = "/proʊˈbeɪʃn/",
                    PartOfSpeech = "noun",
                    Topic = "Personnel",
                    Meaning = "Thời gian thử việc",
                    Example = "All new employees must complete a three-month probation period."
                },
                new VocabularyWord
                {
                    Id = 405,
                    TopicId = 4,
                    Word = "Promotion",
                    Phonetic = "/prəˈmoʊʃn/",
                    PartOfSpeech = "noun",
                    Topic = "Personnel",
                    Meaning = "Sự thăng chức, thăng tiến",
                    Example = "Her exceptional performance earned her a promotion to team leader."
                },
                new VocabularyWord
                {
                    Id = 406,
                    TopicId = 4,
                    Word = "Salary",
                    Phonetic = "/ˈsæləri/",
                    PartOfSpeech = "noun",
                    Topic = "Personnel",
                    Meaning = "Tiền lương hàng tháng",
                    Example = "They offered a competitive salary with generous benefits."
                },

                // Topic 3: General Business (Quản trị văn phòng)
                new VocabularyWord
                {
                    Id = 301,
                    TopicId = 3,
                    Word = "Agenda",
                    Phonetic = "/əˈdʒendə/",
                    PartOfSpeech = "noun",
                    Topic = "General Business",
                    Meaning = "Chương trình nghị sự, lịch họp",
                    Example = "The first item on the meeting agenda is the quarterly sales review."
                },
                new VocabularyWord
                {
                    Id = 302,
                    TopicId = 3,
                    Word = "Colleague",
                    Phonetic = "/ˈkɑːliːɡ/",
                    PartOfSpeech = "noun",
                    Topic = "General Business",
                    Meaning = "Đồng nghiệp",
                    Example = "I discussed the project proposal with my colleagues yesterday."
                },
                new VocabularyWord
                {
                    Id = 303,
                    TopicId = 3,
                    Word = "Deadline",
                    Phonetic = "/ˈdedlaɪn/",
                    PartOfSpeech = "noun",
                    Topic = "General Business",
                    Meaning = "Hạn chót, thời hạn hoàn thành",
                    Example = "We are working overtime to meet the client's deadline."
                },
                new VocabularyWord
                {
                    Id = 304,
                    TopicId = 3,
                    Word = "Delegate",
                    Phonetic = "/ˈdelɪɡeɪt/",
                    PartOfSpeech = "verb",
                    Topic = "General Business",
                    Meaning = "Ủy thác, giao phó nhiệm vụ",
                    Example = "A good manager knows how to delegate responsibilities effectively."
                },

                // Topic 5: Travel & Hotel (Du lịch & Khách sạn)
                new VocabularyWord
                {
                    Id = 501,
                    TopicId = 5,
                    Word = "Itinerary",
                    Phonetic = "/aɪˈtɪnəreri/",
                    PartOfSpeech = "noun",
                    Topic = "Travel & Hotel",
                    Meaning = "Lịch trình chuyến đi",
                    Example = "The travel agent sent us the detailed flight and hotel itinerary."
                },
                new VocabularyWord
                {
                    Id = 502,
                    TopicId = 5,
                    Word = "Accommodation",
                    Phonetic = "/əˌkɑːməˈdeɪʃn/",
                    PartOfSpeech = "noun",
                    Topic = "Travel & Hotel",
                    Meaning = "Chỗ ở, phòng nghỉ",
                    Example = "Hotel accommodation is included in the business conference package."
                },
                new VocabularyWord
                {
                    Id = 503,
                    TopicId = 5,
                    Word = "Reservation",
                    Phonetic = "/ˌrezərˈveɪʃn/",
                    PartOfSpeech = "noun",
                    Topic = "Travel & Hotel",
                    Meaning = "Sự đặt trước (vé, phòng, bàn)",
                    Example = "I would like to make a reservation for a single room for three nights."
                },

                // Topic 6: Shopping & Shipping (Mua sắm & Hậu cần)
                new VocabularyWord
                {
                    Id = 601,
                    TopicId = 6,
                    Word = "Inventory",
                    Phonetic = "/ˈɪnvəntɔːri/",
                    PartOfSpeech = "noun",
                    Topic = "Shopping & Shipping",
                    Meaning = "Hàng tồn kho, sự kiểm kê",
                    Example = "The warehouse conducts a monthly inventory check to track stock."
                },
                new VocabularyWord
                {
                    Id = 602,
                    TopicId = 6,
                    Word = "Dispatch",
                    Phonetic = "/dɪˈspætʃ/",
                    PartOfSpeech = "verb",
                    Topic = "Shopping & Shipping",
                    Meaning = "Gửi đi, xuất kho vận chuyển",
                    Example = "Orders placed before 2 PM will be dispatched on the same day."
                },
                new VocabularyWord
                {
                    Id = 603,
                    TopicId = 6,
                    Word = "Supplier",
                    Phonetic = "/səˈplaɪər/",
                    PartOfSpeech = "noun",
                    Topic = "Shopping & Shipping",
                    Meaning = "Nhà cung cấp hàng hóa",
                    Example = "We negotiate directly with raw material suppliers to lower costs."
                }
            };
        }
    }
}
