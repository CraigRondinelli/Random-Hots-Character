using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_HoTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DoubleBuffered = true;

            this.Text = "Papachips' Random HoTS Picker";

            picChar.Location = new Point (270,189);
        }

        private void picGo_Click(object sender, EventArgs e)
        {
            picChar.Location = new Point (270,189);

            Random randomnumber = new Random();
            int charselect = randomnumber.Next(1, 2);

            label1.Text = charselect.ToString();

            if(charselect == 1)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Abathur.png");
                picChar.Location = new Point(130, 120);
            }

            else if (charselect == 2)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\AnubArak.png");
                picChar.Location = new Point(130, 120);
            }

            //else if (charselect == 41)
            //{
            //    picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Artanis.png");
            // picChar.Location = new Point(105, 120);
            //}

            else if (charselect == 3)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Arthas.png");
                picChar.Location = new Point(120, 120);
            }

            else if (charselect == 4)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Azmodan.png");
                picChar.Location = new Point(134, 120);
            }

            else if (charselect == 5)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Brightwing.png");
                picChar.Location = new Point(130, 120);
            }

            else if (charselect == 6)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Butcher.png");
                picChar.Location = new Point(106, 120);
            }

            else if (charselect == 7)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Chen.png");
                picChar.Location = new Point(141, 120);
            }

            else if (charselect == 8)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Diablo.png");
                picChar.Location = new Point(116, 120);
            }

            else if (charselect == 9)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\ETC.png");
                picChar.Location = new Point(103, 120);
            }

            else if (charselect == 10)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Falstad.png");
            }

            else if (charselect == 11)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Illidan.png");
            }

            else if (charselect == 12)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Jaina.png");
            }

            else if (charselect == 13)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Johanna.png");
            }

            else if (charselect == 14)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\KaelThas.png");
            }

            else if (charselect == 15)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Kerrigan.png");
            }

            else if (charselect == 16)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Leoric.png");
            }

            else if (charselect == 17)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Lili.png");
            }

            else if (charselect == 18)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\LostVikings.png");
            }

            else if (charselect == 19)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Malfurion.png");
            }

            //else if (charselect == 42)
            //{
            //    picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Medic.png");
            //}

            else if (charselect == 20)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Monk.png");
            }

            else if (charselect == 21)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Muradin.png");
            }

            else if (charselect == 22)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Murky.png");
            }

            else if (charselect == 23)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Nazeebo.png");
            }

            else if (charselect == 24)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Nova.png");
            }

            else if (charselect == 25)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Raynor.png");
            }

            else if (charselect == 26)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Rehgar.png");
            }

            else if (charselect == 43)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Rexxar.png");
            }

            else if (charselect == 27)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Sg_Hammer.png");
            }

            else if (charselect == 28)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Sonya.png");
            }

            else if (charselect == 29)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Stitches.png");
            }

            else if (charselect == 30)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Sylvanas.png");
            }

            else if (charselect == 31)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Tassadar.png");
            }

            else if (charselect == 32)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Thrall.png");
            }

            else if (charselect == 33)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Tinker.png");
            }

            else if (charselect == 34)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Tychus.png");
            }

            else if (charselect == 35)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Tyrael.png");
            }

            else if (charselect == 36)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Tyrande.png");
            }

            else if (charselect == 37)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Uther.png");
            }

            else if (charselect == 38)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Valla.png");
            }

            else if (charselect == 39)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Zagara.png");
            }

            else if (charselect == 40)
            {
                picChar.ImageLocation = (@"C:\Users\Craig\Desktop\Random Hots\Random HoTS\Random HoTS\bin\Debug\Stock Heroes\Zeratul.png");
            }
        }
    }
}
