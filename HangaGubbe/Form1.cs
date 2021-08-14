using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangaGubbe
{
    public partial class Form1 : Form
    {
        private string text, gissning, visa;

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxSvar.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxSvar_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSvar.Text.Equals("")) return;

            labelSvar.Text = "_ _ _ _ _ _";
            pictureBoxGubbe.Top = 0;
            textBoxGissa.Clear();
            textBoxVisa.Clear();

            labelInfo.Text = "Gissa på en bokstav";

            if (textBoxSvar.TextLength == 6)
            {
                textBoxGissa.Enabled = true;
                text = textBoxSvar.Text.ToUpper();
                visa = "??????";
                textBoxGissa.Focus();
                /*
                svar logic
                second, fourth and sixth characters should be- 
                visible to other player
                t.ex. flicka => f?i??a ... region => r?g??n
                 */
                labelSvar.Text= (text.First() + " _ " + text.Substring(2, 1) + " _ _ " + text.Last()).ToUpper();
            }
            else
            {
                textBoxGissa.Enabled = false;
            }
        }

        private void textBoxGissa_TextChanged(object sender, EventArgs e)
        {
            if (textBoxGissa.Text.Length==0 || textBoxGissa.Text==" ") // null eller användaren trycket spacebar
                return;
            
            gissning = textBoxGissa.Text.ToUpper();

            int index = text.IndexOf(gissning);

            if (index<0)
            {
                pictureBoxGubbe.Top += panel1.Height / 10;
            }
            else
            {
                do
                {
                    string temp = visa.Remove(index,1);
                    visa = temp.Insert(index, gissning);
                    
                    textBoxVisa.Text = visa;
                    index = text.IndexOf(gissning, index + 1);
                } while (index>0);
            }

            if (pictureBoxGubbe.Bottom>=pictureBoxMark.Top)
            {
                textBoxSvar.Text = "";
                labelInfo.Text = "Game Over";
                textBoxGissa.Enabled = false;
            }
            if (!visa.Contains("?"))
            {
                labelInfo.Text = "Kull, Du vann!";
                textBoxSvar.Text = "";
                textBoxGissa.Text = "";
                labelSvar.Text = text.ToString().ToLower();
                textBoxGissa.Enabled = false;
                MessageBox.Show("Kull, Du vann!🎉👏👏👏", Application.ProductName.ToString() + " 😊");

            }
        }

    }
}
