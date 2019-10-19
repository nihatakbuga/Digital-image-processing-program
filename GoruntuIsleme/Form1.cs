using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoruntuIsleme
{
    public partial class Form1 : Form
    {
        islemler islemler = new islemler();
        OpenFileDialog openfile = new OpenFileDialog();
       public Form1()
        {
            InitializeComponent();
            openfile.DefaultExt = ".jpg";
            openfile.Filter = "Image Files(*.JPG;*.BMP;*.GIF;*.PNG;*.TIFF;*.WMF;*.ICON;*.EXİF;*.EMF)|*.JPG;*.BMP;*.GIF;*.PNG;*.TIFF;*.WMF;*.ICON;*.EXİF;*.EMF|All files (*.*)|*.*";
        }
    


        private void btn_yükle_Click(object sender, EventArgs e)
        {
           if(openfile.ShowDialog()==DialogResult.OK)
            {
                pBoriginalresim.Image = Image.FromFile(openfile.FileName);
            }
        }

        private void pBoriginalresim_MouseMove(object sender, MouseEventArgs e)
        {
            if(pBoriginalresim.Image!=null)
            {
                if(cbİslemler.SelectedItem.ToString()=="Mouse İle Renk Alma")
                {
                    Bitmap bitmap;
                    bitmap = (Bitmap)pBoriginalresim.Image;

                    Color color = bitmap.GetPixel(e.X, e.Y);
                    pBislenmisresim.Image =null;
                    pBislenmisresim.BackColor = color;
                }
            }
          
        }

        private void btn_işle_Click(object sender, EventArgs e)
        {
            Bitmap orjinalresim = (Bitmap)Image.FromFile(openfile.FileName);
            Bitmap gelenresim = null;
            switch(cbİslemler.SelectedItem)
            {
                case "Negatifini Alma":
                    gelenresim = islemler.Negative((Bitmap)orjinalresim);
                    break;
                case "Gri Tonlama":
                    gelenresim = islemler.GriyeCevir((Bitmap)orjinalresim);
                    break;
                case "Eşikleme":
                    gelenresim = islemler.GriyeCevir((Bitmap)orjinalresim);
                    gelenresim = islemler.SiyahBeyaz((Bitmap)orjinalresim,trackBar1.Value);
                    break;
                case "Parlaklık":
                   gelenresim = islemler.Parlaklık((Bitmap)orjinalresim,trackBar1.Value);
                    break;
                case "Kontrast":
                    gelenresim = islemler.Kontrast((Bitmap)orjinalresim, trackBar1.Value);
                    break;
                
            }
            pBislenmisresim.Image = gelenresim;
        }

        private void cbİslemler_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbİslemler.SelectedItem.ToString() == "Mouse İle Renk Alma")
            {
                pBoriginalresim.SizeMode = PictureBoxSizeMode.Normal;
                pBislenmisresim.SizeMode = PictureBoxSizeMode.Normal;
            }
            else
            {
                pBoriginalresim.SizeMode = PictureBoxSizeMode.Zoom;
                pBislenmisresim.SizeMode = PictureBoxSizeMode.Zoom;
                pBislenmisresim.BackColor = Color.Lavender;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbİslemler.SelectedIndex = 0;
            lbl_trackbar.Text = trackBar1.Value.ToString();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            lbl_trackbar.Text = trackBar1.Value.ToString();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Jpeg Resmi|*.jpg|Bitmap Resmi|*.bmp|Gif Resmi|*.gif|Png Resmi|*.png|Tiff Resmi|*.tiff|Wmf Resmi|*.wmf|Icon Resmi|*.ıcon|Exif Resmi|*.exif|Emf Resmi|*.emf";
            savefile.Title = "Resmi Kaydet";
            savefile.ShowDialog();
            if (savefile.FileName != "") //Dosya adı boş değilse kaydedecek.
            {
                // FileStream nesnesi ile kayıtı gerçekleştirecek.
                FileStream DosyaAkisi = (FileStream)savefile.OpenFile();
                switch (savefile.FilterIndex)
                {
                    case 1:
                        pBislenmisresim.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 2:
                        pBislenmisresim.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 3:
                        pBislenmisresim.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case 4:
                        pBislenmisresim.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case 5:
                        pBislenmisresim.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                    case 6:
                        pBislenmisresim.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Wmf);
                        break;
                    case 7:
                        pBislenmisresim.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Icon);
                        break;
                    case 8:
                        pBislenmisresim.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Exif);
                        break;
                    case 9:
                        pBislenmisresim.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Emf);
                        break;
                }
                DosyaAkisi.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                pBislenmisresim.Image = null;
                pBislenmisresim.BackColor = Color.Black;
                ArrayList DiziPiksel = new ArrayList();
                int OrtalamaRenk = 0;
                Color OkunanRenk;
                Bitmap GirisResmi = new Bitmap(pBoriginalresim.Image);
                for (int x = 0; x < GirisResmi.Width; x++)
                {
                    for (int y = 0; y < GirisResmi.Height; y++)
                    {
                        OkunanRenk = GirisResmi.GetPixel(x, y);
                        OrtalamaRenk = (int)(OkunanRenk.R + OkunanRenk.G + OkunanRenk.B) / 3; //Griton resimde üç kanal rengi aynı değere sahiptir.
                        DiziPiksel.Add(OrtalamaRenk); //Resimdeki tüm noktaları diziye atıyor.
                    }
                }
                int[] DiziPikselSayilari = new int[256];
                for (int r = 0; r < 255; r++) //256 tane renk tonu için dönecek.
                {
                    int PikselSayisi = 0;
                    for (int s = 0; s < DiziPiksel.Count; s++) //resimdeki piksel sayısınca dönecek.
                    {
                        if (r == Convert.ToInt16(DiziPiksel[s]))
                            PikselSayisi++;
                    }
                    DiziPikselSayilari[r] = PikselSayisi;
                }
                int RenkMaksPikselSayisi = 0; //Grafikte y eksenini ölçeklerken kullanılacak.
                for (int k = 0; k <= 255; k++)
                {
                    listBox1.Items.Add("Renk:" + k + "=" + DiziPikselSayilari[k]);
                    if (DiziPikselSayilari[k] > RenkMaksPikselSayisi)
                    {
                        RenkMaksPikselSayisi = DiziPikselSayilari[k];
                    }
                }
                Graphics CizimAlani;
                Pen Kalem1 = new Pen(System.Drawing.Color.Yellow, 1);
                Pen Kalem2 = new Pen(System.Drawing.Color.Red, 1);
                CizimAlani = pBislenmisresim.CreateGraphics();
                pBislenmisresim.Refresh();
                int GrafikYuksekligi = 400;
                double OlcekY = RenkMaksPikselSayisi / GrafikYuksekligi, OlcekX = 1.6;
                for (int x = 0; x <= 255; x++)
                {
                    CizimAlani.DrawLine(Kalem1, (int)(20 + x * OlcekX), GrafikYuksekligi, (int)(20 + x * OlcekX),
                   (GrafikYuksekligi - (int)(DiziPikselSayilari[x] / OlcekY)));
                    if (x % 50 == 0)
                        CizimAlani.DrawLine(Kalem2, (int)(20 + x * OlcekX), GrafikYuksekligi, (int)(20 + x * OlcekX), 0);
                }
                textBox1.Text = "Maks.Piks=" + RenkMaksPikselSayisi.ToString();
        }

    }
}

