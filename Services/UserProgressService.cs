using Wasm.DigitalHistoryBook.Interfaces;
using Wasm.DigitalHistoryBook.Models;

namespace Wasm.DigitalHistoryBook.Services;

public class UserProgressService : IUserProgressService {
    private readonly List<UserProgress> _userProgresses = new List<UserProgress>();
    private Dictionary<string, int> userProgress = new Dictionary<string, int>(); // Kullanıcı ilerlemesini saklamak için bir sözlük

    public async Task SaveProgressAsync(UserProgress progress)
    {
        _userProgresses.Add(progress);
    }
    

    public async Task<UserProgress> GetProgressAsync(int userId, int storyId)
    {
        return _userProgresses.FirstOrDefault(p => p.UserId.ToString() == userId.ToString() && p.StoryId == storyId);
    }

    Task<UserProgress> IUserProgressService.GetProgressAsync(int userId, int storyId)
    {
        return GetProgressAsync(userId, storyId);
    }

    public void UpdateProgress(string userId, int progress) {
        userProgress[userId] = progress; // Kullanıcı ilerlemesini güncelle
    }

    public int GetProgress(string userId) {
        return userProgress.ContainsKey(userId) ? userProgress[userId] : 0; // Kullanıcı ilerlemesini döndür
    }

    // ... diğer ilerleme ile ilgili metodlar
} 