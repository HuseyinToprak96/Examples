using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Patterns
{
    //9. Proxy: Bir nesnenin yerine geçerek istemci ile gerçek nesne arasındaki erişimi kontrol eden bir desendir. İstemci ve gerçek nesne arasındaki etkileşimi yönetir.
    public interface IImage
    {
        void Display();
    }

    public class RealImage : IImage
    {
        private string filename;

        public RealImage(string filename)
        {
            this.filename = filename;
            LoadImageFromDisk();
        }

        private void LoadImageFromDisk()
        {
            Console.WriteLine("Loading image from disk: " + filename);
        }

        public void Display()
        {
            Console.WriteLine("Displaying image: " + filename);
        }
    }

    public class ProxyImage : IImage
    {
        private string filename;
        private RealImage realImage;

        public ProxyImage(string filename)
        {
            this.filename = filename;
        }

        public void Display()
        {
            if (realImage == null)
            {
                realImage = new RealImage(filename);
            }
            realImage.Display();
        }
    }
}
