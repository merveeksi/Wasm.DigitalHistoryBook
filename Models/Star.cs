namespace Wasm.DigitalHistoryBook.Models;

public class Star
{
    public Star(List<Star> stars)
    {
        Stars = stars;
    }

    public List<Star> Stars { get; set; }

    public double Xpx { get; set; } // X pozisyonu
    public double Ypx { get; set; } // Y pozisyonu
    public double Sizepx { get; set; } // Yıldızın boyutu
    public int Speedms { get; set; } // Animasyon hızı (milisaniye cinsinden)

    public class DOMRect
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Top { get; set; }
        public double Left { get; set; }
        public double Right { get; set; }
        public double Bottom { get; set; }
    }
}

