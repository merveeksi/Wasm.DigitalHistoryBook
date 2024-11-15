namespace Wasm.DigitalHistoryBook.Models;

public class UserProgress
{
    public int Id { get; set; }
    public string UserId { get; set; }  // Anonim kullanıcılar için tarayıcı ID'si
    public int StoryId { get; set; }
    public Story Story { get; set; }
    public bool IsCompleted { get; set; }
    public int CorrectAnswers { get; set; }
    public int TotalQuestions { get; set; }
    public DateTime CompletionDate { get; set; }
    public TimeSpan ReadingDuration { get; set; }  // Hikayeyi okumak için harcanan süre
        
    public UserProgress()
    {
            
    }
        
    public UserProgress(int id, string userId, int storyId, bool isCompleted, int correctAnswers, int totalQuestions, 
        DateTime completionDate, TimeSpan readingDuration):this()
    {
        Id = id;
        UserId = userId;
        StoryId = storyId;
        IsCompleted = isCompleted;
        CorrectAnswers = correctAnswers;
        TotalQuestions = totalQuestions;
        CompletionDate = completionDate;
        ReadingDuration = readingDuration;
    }
}
