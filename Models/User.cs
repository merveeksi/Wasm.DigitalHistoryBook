namespace Wasm.DigitalHistoryBook.Models;

public class User
{
    public long Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public DateTime RegisterDate { get; set; }
    public List<TestResult> TestResults { get; set; }
    public List<Story> ReadStories { get; set; }
        
    public User()
    {
            
    }

    public User(long id, string username, string email, string passwordHash, DateTime registerDate,
        List<TestResult> testResults, List<Story> readStories) : this()
    {
        Id = id;
        Username = username;
        Email = email;
        PasswordHash = passwordHash;
        RegisterDate = registerDate;
        TestResults = testResults;
        ReadStories = readStories;
    }
}