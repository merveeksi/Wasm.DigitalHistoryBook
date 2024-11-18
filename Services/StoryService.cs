using System.Net.Http.Json;
using Wasm.DigitalHistoryBook.Enums;
using Wasm.DigitalHistoryBook.Interfaces;
using Wasm.DigitalHistoryBook.Models;

namespace Wasm.DigitalHistoryBook.Services;

public class StoryService : IStoryService {
    private readonly List<Story> _stories;
    private readonly HttpClient _httpClient;
    private List<Story> stories = new List<Story>
    {
        new Story { Id = 1, Title = "Hikaye 1", Content = "Hikaye 1 içeriği", AgeGroup = AgeGroup.ThreeToFive },
        new Story { Id = 2, Title = "Hikaye 2", Content = "Hikaye 2 içeriği", AgeGroup = AgeGroup.SixToEight },
        new Story { Id = 3, Title = "Hikaye 3", Content = "Hikaye 3 içeriği", AgeGroup = AgeGroup.NineToTwelve }
    };
    public StoryService()
    {
        _stories = new List<Story>
        {
            new Story
            {
                Title = "Örnek Hikaye",
                Author = "Yazar Adı",
                PdfUrl = "wwwroot/pdf/OrnekHikaye.pdf"
            }
            // Diğer hikayeleri buraya ekleyin
        };
    }

    public StoryService(HttpClient httpClient) {
        _httpClient = httpClient;
        _stories = new List<Story>();
    }

    public void AddStory(string story)
    {
        // Convert string to Story object if necessary
        // For example, if Story has a constructor that takes a string
        // _stories.Add(new Story(story));
        // Otherwise, you might need to parse the string into a Story object
        // This is a placeholder for the actual implementation
    }

    public List<string> GetStories()
    {
        // Convert List<Story> to List<string> if necessary
        // For example, if you want to return a list of story titles
        // return _stories.Select(s => s.Title).ToList();
        // Otherwise, you might need to implement a different method to return a list of strings
        // This is a placeholder for the actual implementation
        return new List<string>(); // Placeholder return statement
    }

    public Task<List<Story>> GetStoriesAsync()
    {
      return Task.FromResult(stories as List<Story>);
    }

    public async Task<string> GenerateStoryAsync(string title, string genre, string targetAge, string illustrationStyle)
    {
        var requestBody = new
        {
            title,
            genre,
            target_age = targetAge,
            illustration_style = illustrationStyle
        };
        var response = await _httpClient.PostAsJsonAsync("http://localhost:5000/generate_story", requestBody);
        response.EnsureSuccessStatusCode();

        var result = await response.Content.ReadFromJsonAsync<Dictionary<string, string>>();
        return result["story"];
    }

    public Task<Story> GetStoryByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<Story> GetStoryByIdAsync(int id) {
        return _stories.FirstOrDefault(s => s.Id == id);
    }

    public async Task<string> GetAudioForStoryAsync(int id) {
        var response = await _httpClient.GetAsync($"api/stories/{id}/audio");
        response.EnsureSuccessStatusCode();

        var audioUrl = await response.Content.ReadAsStringAsync();
        return audioUrl;
    }

    public async Task<string> CreateStory(string title, string genre, string targetAge, string illustrationStyle)
    {
        var requestBody = new
        {
            title,
            genre,
            target_age = targetAge,
            illustration_style = illustrationStyle
        };
        var response = await _httpClient.PostAsJsonAsync("http://localhost:5000/create_story", requestBody);
        response.EnsureSuccessStatusCode();

        var result = await response.Content.ReadFromJsonAsync<Dictionary<string, string>>();
        return result["story_id"];
    }

    public async Task DeleteStoryAsync(int storyId)
    {
        var response = await _httpClient.DeleteAsync($"http://localhost:5000/stories/{storyId}");
        response.EnsureSuccessStatusCode();
    }
} 