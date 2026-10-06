namespace Khanh_Project.Models
{
    public class ToeicExam
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Category { get; set; } = "Full Test";
        public int DurationMinutes { get; set; } = 120;
        public int TotalQuestions { get; set; } = 200;
        public int ParticipantsCount { get; set; } = 1200;
        public double Rating { get; set; } = 4.9;
        public string Tag { get; set; } = "Mới nhất";
        public string Series { get; set; } = "ETS";
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = "not-started";
        public int CompletedQuestions { get; set; } = 0;
        public int? Score { get; set; } = null;
    }

    public class VocabularyWord
    {
        public int Id { get; set; }
        public string Word { get; set; } = string.Empty;
        public string Phonetic { get; set; } = string.Empty;
        public string Meaning { get; set; } = string.Empty;
        public string PartOfSpeech { get; set; } = string.Empty;
        public string Topic { get; set; } = string.Empty;
        public string Example { get; set; } = string.Empty;
    }

    public class VocabularyTopic
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Icon { get; set; } = "bi-journal-bookmark";
        public int TotalWords { get; set; } = 50;
        public int LearnedWords { get; set; } = 0;
        public string Status { get; set; } = "not-started";
        public string TargetBand { get; set; } = "550+";
    }

    public class GrammarTopic
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Level { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public int TotalLessons { get; set; }
    }

    public class RecentActivityOverview
    {
        // Chủ đề từ vựng mới vừa học xong
        public string RecentVocabTopic { get; set; } = "Tuyển Dụng & Nhân Sự (Personnel)";
        public int RecentVocabCount { get; set; } = 45;
        public string RecentVocabTime { get; set; } = "Hôm nay, 14:30";

        // Đề vừa được làm
        public string RecentExamTitle { get; set; } = "ETS TOEIC 2024 - Test 01";
        public int RecentExamScore { get; set; } = 825;
        public int RecentExamTotal { get; set; } = 990;
        public int TargetScore { get; set; } = 850;
        public int MissingScore { get; set; } = 25; // hoặc điểm còn thiếu
        public string RecentExamDate { get; set; } = "Hôm qua, 20:15";

        // Bài ngữ pháp mới vừa học
        public string RecentGrammarTitle { get; set; } = "Mệnh Đề Quan Hệ & Rút Gọn";
        public string RecentGrammarLevel { get; set; } = "Trung cấp - 650+";
        public string RecentGrammarTime { get; set; } = "Hôm nay, 09:10";
    }

    public class HomeViewModel
    {
        public string UserName { get; set; } = "Học viên TOEIC";
        public int TargetScore { get; set; } = 800;
        public int CurrentStreak { get; set; } = 7;
        public RecentActivityOverview Overview { get; set; } = new();
        public List<ToeicExam> AvailableExams { get; set; } = new();
        public List<VocabularyTopic> VocabTopics { get; set; } = new();
        public List<VocabularyWord> FeaturedWords { get; set; } = new();
        public List<GrammarTopic> GrammarTopics { get; set; } = new();
    }
}