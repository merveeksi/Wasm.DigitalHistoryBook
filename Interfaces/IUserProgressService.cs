using Wasm.DigitalHistoryBook.Models;

namespace Wasm.DigitalHistoryBook.Interfaces;

public interface IUserProgressService
{
    Task SaveProgressAsync(UserProgress progress);
    Task<UserProgress> GetProgressAsync(int userId, int storyId);
    void UpdateProgress(string userId, int progress); // Kullanıcı ilerlemesini güncelle
    int GetProgress(string userId); // Kullanıcı ilerlemesini döndür
    // ... diğer ilerleme ile ilgili metodlar
}