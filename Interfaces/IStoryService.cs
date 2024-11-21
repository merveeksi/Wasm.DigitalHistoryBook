using Wasm.DigitalHistoryBook.Models;

namespace Wasm.DigitalHistoryBook.Interfaces;

public interface IStoryService
{
    void AddStory(string story); // Yeni hikaye ekle
    List<string> GetStories(); // Tüm hikayeleri döndür
    Task<List<Story>> GetStoriesAsync();
    Task<string> GenerateStoryAsync(string title, string genre, string targetAge, string illustrationStyle);
    Task<Story> GetStoryByIdAsync(int id);
    Task<string> GetAudioForStoryAsync(int id); // Hikaye ses dosyasını al
    Task<string> CreateStory(string title, string genre, string targetAge, string illustrationStyle);
    Task DeleteStoryAsync(int storyId);
    void SetStory(string newStory);
    string GetStory();
}