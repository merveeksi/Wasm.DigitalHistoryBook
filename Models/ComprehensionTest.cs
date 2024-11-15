namespace Wasm.DigitalHistoryBook.Models;

public class ComprehensionTest
{
    public int Id { get; set; }
    public int StoryId { get; set; }
    public Story Story { get; set; }
    public List<Question> Questions { get; set; }

    public ComprehensionTest()
    {
            
    }

    public ComprehensionTest(int id, int storyId, List<Question> questions):this()
    {
        Id = id;
        StoryId = storyId;
        Questions = questions;
    }
}