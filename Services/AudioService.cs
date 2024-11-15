using Wasm.DigitalHistoryBook.Interfaces;

namespace Wasm.DigitalHistoryBook.Services;

public class AudioService : IAudioService
{
    public void PlayAudio(string audioFile)
    {
        // Ses dosyasını çalma işlemi
        Console.WriteLine($"Playing audio: {audioFile}");
    }

    public void StopAudio()
    {
        // Ses dosyasını durdurma işlemi
        Console.WriteLine("Audio stopped.");
    }
}
