using audio_quiz.Models.DbModels;
using System.Net.NetworkInformation;
using Newtonsoft.Json;
namespace audio_quiz.Models.DbModels
{
    public class Quiz
    {
        public string AudioUrl { get; set; }
        public List<Question> Questions { get; set; }


        public static Quiz FromFile(string filePath)
        {
            string json = File.ReadAllText(filePath);
            Quiz quiz = JsonConvert.DeserializeObject<Quiz>(json);
            return quiz;
        }

    }
}