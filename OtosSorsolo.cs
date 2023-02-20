using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otoslotto
{
    public partial class OtosSorsolo : Form
    {

        int sorszam = 6;
        int oszlopszam = 15;
        int gombmer = 40;
        Random randomszamok = new Random();
        List<string> valasztottszamok = new List<string>();

        public OtosSorsolo()
        {
            InitializeComponent();
        }

        private void OtosSorsolo_Load(object sender, EventArgs e)
        {

            PanelFriss();

        }

        private void PanelFriss()
        {
            lottoszamokpan.Controls.Clear();
            for (int i = 0; i < sorszam; i++)
            {

                for (int j = 0; j < oszlopszam; j++)
                {

                    Button button = new Button();
                    button.SetBounds(j * gombmer, i * gombmer, gombmer, gombmer);
                    button.Text = (i * oszlopszam + 1 + j).ToString();
                    button.BackColor = Color.LightBlue;
                    button.Click += (o, ev) => {

                        if (button.BackColor == Color.LightBlue)
                        {

                            DialogResult dialogresult = MessageBox.Show(button.Text + "\nValóban ezt a számot szeretné választani?", "Lottószám", MessageBoxButtons.YesNo);
                            if (dialogresult == DialogResult.Yes)
                            {
                                MessageBox.Show($"A {button.Text} szám lett kiválasztva!");
                                button.BackColor = Color.Red;
                                valasztottszamok.Add(button.Text);

                            }
                            else if (dialogresult == DialogResult.No)
                            {

                                MessageBox.Show($"A {button.Text} szám nem lett kiválasztva!");

                            }

                        }

                        megjatszottlab.Text = "Megjátszott-> " + String.Join(", ",valasztottszamok);

                        if (button.BackColor == Color.Red)
                        {

                            DialogResult dialogresult1 = MessageBox.Show(button.Text + "\nValóban módosítani szeretné választását?", "Lottószám", MessageBoxButtons.YesNo);
                            if (dialogresult1 == DialogResult.Yes)
                            {

                                MessageBox.Show("A választás módosítva lett!");
                                button.BackColor = Color.LightBlue;
                                valasztottszamok.Remove(button.Text);

                            }
                            else if (dialogresult1 == DialogResult.No)
                            {

                                MessageBox.Show("A választás nem lett módosítva!");

                            }

                        }

                        megjatszottlab.Text = "Megjátszott-> " + String.Join(", ",valasztottszamok);

                    };
                    lottoszamokpan.Controls.Add(button);

                }

            }
        }


        private void sorsolobutton_Click(object sender, EventArgs e)
        {
            int randomszam;
            bool dupla;
            int[] nyeroszamok = new int[5];
            for (int i = 0; i < nyeroszamok.Length; i++)
            {
                do
                {
                    randomszam = randomszamok.Next(1, 91);
                    dupla = false;

                    for (int j = 0; j < i; j++)
                    {

                        if (nyeroszamok[j] == randomszam)
                        {

                            dupla = true;
                            break;

                        }

                    }

                }while (dupla);

                nyeroszamok[i] = randomszam;
            }
            nyeroszamoklab.Text = "Nyerőszámok-> " + String.Join(", " ,nyeroszamok);

            for (int i = 0; i < nyeroszamok.Length; i++)
            {

                for (int j = 0; j < valasztottszamok.Count; j++)
                {

                    if (String.Join(", ", nyeroszamok[i]) == String.Join(", ", valasztottszamok[j]))
                    {

                        talalatlab.Text = "Találat-> " + String.Join(", ", valasztottszamok[j]);

                    }
                    else
                    {

                        talalatlab.Text = "Találat-> ";

                    }

                }

            }
            

        }

    }
}
