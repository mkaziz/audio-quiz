namespace audio_quiz.Models.DbModels
{
    public class Question
    {
        public string QuestionText { get; set; }
        public int QuestionId { get; set; }
        public List<Answer> Answers { get; set; }
        public int CorrectAnswerId { get; set; }
    }
}
