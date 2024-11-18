using Wasm.DigitalHistoryBook.Enums;

namespace Wasm.DigitalHistoryBook.Models;

public class Story
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public Genre Genre { get; set; } // Hikaye türü
    public IllustrationStyle IllustrationStyle { get; set; }
    public string Author { get; set; }
    public string ImageUrl { get; set; }
    public string PdfUrl { get; set; } // Dosya yolu
    public AgeGroup AgeGroup { get; set; }  // Yaş grubu (örn: 5-7, 8-10 yaş)
    public ReadingLevel ReadingLevel { get; set; }  // Okuma seviyesi (Başlangıç, Orta, İleri)
    public TimeSpan EstimatedReadTime { get; set; }  // Tahmini okuma süresi
    public string AudioFile { get; set; } 
    public string AudioUrl { get; set; }  // Text-to-Speech ile oluşturulan ses dosyasının URL'i
    public List<Question> Questions { get; set; }
        
    public Story()
    {
            
    }
        
    public Story(int id, string title, string content, Genre genre, 
        IllustrationStyle illustrationStyle, string author, string imageUrl, 
        AgeGroup ageGroup, ReadingLevel readingLevel, TimeSpan estimatedReadTime, 
        string audioFile, string audioUrl, List<Question> questions):this()
    {
        Id = id;
        Title = title;
        Content = content;
        Genre = genre;
        IllustrationStyle = illustrationStyle;
        Author = author;
        ImageUrl = imageUrl;
        AgeGroup = ageGroup;
        ReadingLevel = readingLevel;
        EstimatedReadTime = estimatedReadTime;
        AudioFile = audioFile;
        AudioUrl = audioUrl;
        Questions = questions;
    }
}