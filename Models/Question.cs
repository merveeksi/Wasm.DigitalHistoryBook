namespace Wasm.DigitalHistoryBook.Models;

public class Question
{
    public int Id { get; set; }
    public int StoryId { get; set; }
    public Story Story { get; set; }
    public string QuestionText { get; set; }
    public List<string> Options { get; set; }
    public int CorrectOptionIndex { get; set; }
    public string Explanation { get; set; }  // Doğru cevabın açıklaması

    public Question()
    {
        Options = new List<string>();
    }
        
    public Question(int id, int storyId, string questionText, List<string> options, int correctOptionIndex, string explanation):this()
    {
        Id = id;
        StoryId = storyId;
        QuestionText = questionText;
        Options = options;
        CorrectOptionIndex = correctOptionIndex;
        Explanation = explanation;
    }
    
    
    public bool IsCorrect(int selectedOptionIndex)
    {
        return selectedOptionIndex == CorrectOptionIndex;
    }
    
    public override string ToString()
    {
        return $"{QuestionText} {Options[CorrectOptionIndex]}";
    }
}