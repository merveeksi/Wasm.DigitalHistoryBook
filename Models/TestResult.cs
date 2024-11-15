namespace Wasm.DigitalHistoryBook.Models;

public class TestResult
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public int ComprehensionTestId { get; set; }
    public ComprehensionTest ComprehensionTest { get; set; }
    public int Score { get; set; }
    public DateTime CompletionDate { get; set; }
        
    public TestResult()
    {
            
    }
        
    public TestResult(int id, int userId, int comprehensionTestId, int score, DateTime completionDate):this()
    {
        Id = id;
        UserId = userId;
        ComprehensionTestId = comprehensionTestId;
        Score = score;
        CompletionDate = completionDate;
    }
}