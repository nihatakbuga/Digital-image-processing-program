using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoruntuIsleme
{
    class islemler
    {
        public Bitmap Negative(Bitmap bitmap)
        {
            Bitmap sonuc = new Bitmap(bitmap.Width, bitmap.Height);
            Color color1, color2;
            int r, g, b;
            for (int j = 0; j < bitmap.Width; j++)
            {
                for (int k = 0; k < bitmap.Height; k++)
                {
                    color1 = bitmap.GetPixel(j, k);
                    r = 255 - color1.R;
                    g = 255 - color1.G;
                    b = 255 - color1.B;
                    color2 = Color.FromArgb(r, g, b);
                    sonuc.SetPixel(j, k, color2);
                }

            }
            return sonuc;
        }
        public Bitmap GriyeCevir(Bitmap bitmap)
        {
            Bitmap sonuc = new Bitmap(bitmap.Width, bitmap.Height);
            int ton;
            Color color, color1;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    color = bitmap.GetPixel(i, j);
                    ton = Convert.ToInt16(color.R * 0.299) + Convert.ToInt16(color.G * 0.587) + Convert.ToInt16(color.B * 0.114);
                    color1 = Color.FromArgb(ton, ton, ton);
                    sonuc.SetPixel(i, j, color1);
                }
            }
            return sonuc;
        }
        public Bitmap SiyahBeyaz(Bitmap bitmap, int esik)
        {
            Bitmap sonuc = new Bitmap(bitmap.Width, bitmap.Height);
           // int ton;
            Color color, color1;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    color = bitmap.GetPixel(i, j);
                    if (color.R >= esik)
                    {
                        color1 = Color.FromArgb(255, 255, 255);
                    }
                    else
                    {
                        color1 = Color.FromArgb(0, 0, 0);
                    }
                    sonuc.SetPixel(i, j, color1);
                }
            }
            return sonuc;
        }
        public Bitmap Parlaklık(Bitmap bitmap, int parlaklık)
        {
            Bitmap sonuc = new Bitmap(bitmap.Width, bitmap.Height);
           // int ton;
            Color color, color1;
            int r, g, b;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    color = bitmap.GetPixel(i, j);
                    if (color.R + parlaklık > 255)
                    {
                        r = 255;
                    }
                    else if (color.R + parlaklık < 0)
                    {
                        r = 0;
                    }
                    else
                    {
                        r = color.R + parlaklık;
                    }

                    color = bitmap.GetPixel(i, j);
                    if (color.G + parlaklık > 255)
                    {
                        g = 255;
                    }
                    else if (color.G + parlaklık < 0)
                    {
                        g = 0;
                    }
                    else
                    {
                        g = color.G + parlaklık;
                    }

                    color = bitmap.GetPixel(i, j);
                    if (color.B + parlaklık > 255)
                    {
                        b = 255;
                    }
                    else if (color.B + parlaklık < 0)
                    {
                        b = 0;
                    }
                    else
                    {
                        b = color.B + parlaklık;
                    }
                    color1 = Color.FromArgb(r, g, b);
                    sonuc.SetPixel(i, j, color1);
                }
            }
            return sonuc;
        }
        public Bitmap Kontrast(Bitmap bitmap, int kontrast)
        {
            Bitmap sonuc = new Bitmap(bitmap.Width, bitmap.Height);
            int R = 0, G = 0, B = 0;
            Color color, color1;
            double KontrastSeviyesi = kontrast;
            double KontrastFaktoru = (259 * (KontrastSeviyesi + 255)) / (255 * (259 - KontrastSeviyesi));
            for (int x = 0; x < bitmap.Width; x++)
            {

                for (int y = 0; y < bitmap.Height; y++)
                {
                    color = bitmap.GetPixel(x, y);
                    R = color.R;
                    G = color.G;
                    B = color.B;
                    R = (int)((KontrastFaktoru * (R - 128)) + 128);
                    G = (int)((KontrastFaktoru * (G - 128)) + 128);
                    B = (int)((KontrastFaktoru * (B - 128)) + 128);

                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;
                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;
                    color1 = Color.FromArgb(R, G, B);
                    sonuc.SetPixel(x, y, color1);
                }
            }
            return sonuc;
        }
     
    }
}



