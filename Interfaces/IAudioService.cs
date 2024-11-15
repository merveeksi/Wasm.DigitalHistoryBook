namespace Wasm.DigitalHistoryBook.Interfaces;

public interface IAudioService
{
    void PlayAudio(string audioFile); // Ses dosyasını çal
    void StopAudio(); // Ses dosyasını durdur
}