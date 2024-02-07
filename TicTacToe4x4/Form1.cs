using System.Drawing.Text;
using System.Linq.Expressions;

namespace TicTacToe4x4
{ 
    public partial class Form1 : Form
    {
        //Entscheidet welcher Spieler am Zug ist
        bool kreisZug;
        bool kreuzZug;

        //Rundenanzahl
        int runde = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void spielVerlassenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void knopf_klick(object sender, EventArgs e)
        {
            if (runde % 2 == 0)
            {
                kreisZug = true;
                kreuzZug = false;
            }
            else
            {
                kreisZug = false;
                kreuzZug = true;
            }
            
            Button k = (Button)sender;

            if (kreisZug == true)
            {
                k.Text = "O";
            }
            else
            {
                k.Text = "X";
            }
            runde++;
            k.Enabled = false;
            verliererCheck();
        }
        //Methode um zu prüfen ob ein Spieler verloren hat
        private void verliererCheck()
        {
            bool spielerVerloren = false;

            //horizontale Gewinnereignisse
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (A1.Enabled == false))
                spielerVerloren = true;
            if ((A2.Text == A3.Text) && (A3.Text == A4.Text) && (A4.Enabled == false))
                spielerVerloren = true;
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (B1.Enabled == false))
                spielerVerloren = true;
            if ((B2.Text == B3.Text) && (B3.Text == B4.Text) && (B4.Enabled == false))
                spielerVerloren = true;
            if ((D1.Text == D2.Text) && (D2.Text == D3.Text) && (D1.Enabled == false))
                spielerVerloren = true;
            if ((D2.Text == D3.Text) && (D3.Text == D4.Text) && (D4.Enabled == false))
                spielerVerloren = true;

            //vertikale Gewinnereignisse
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (A1.Enabled == false))
                spielerVerloren = true;
            if ((B1.Text == C1.Text) && (C1.Text == D1.Text) && (B1.Enabled == false))
                spielerVerloren = true;
            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (A2.Enabled == false))
                spielerVerloren = true;
            if ((B2.Text == C2.Text) && (C2.Text == D2.Text) && (B2.Enabled == false))
                spielerVerloren = true;
            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (A3.Enabled == false))
                spielerVerloren = true;
            if ((B3.Text == C3.Text) && (C3.Text == D3.Text) && (B3.Enabled == false))
                spielerVerloren = true;
            if ((A4.Text == B4.Text) && (B4.Text == C4.Text) && (A4.Enabled == false))
                spielerVerloren = true;
            if ((B4.Text == C4.Text) && (C4.Text == D4.Text) && (B4.Enabled == false))
                spielerVerloren = true;

            //diagonale Gewinnereignisse
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (A1.Enabled == false))
                spielerVerloren = true;
            if ((B2.Text == C3.Text) && (C3.Text == D3.Text) && (B2.Enabled == false))
                spielerVerloren = true;
            if ((B1.Text == C2.Text) && (C2.Text == D3.Text) && (B1.Enabled == false))
                spielerVerloren = true;
            if ((A2.Text == B3.Text) && (B3.Text == C4.Text) && (A2.Enabled == false))
                spielerVerloren = true;
            if ((D1.Text == C2.Text) && (C2.Text == B3.Text) && (D1.Enabled == false))
                spielerVerloren = true;
            if ((C2.Text == B3.Text) && (B3.Text == A4.Text) && (C2.Enabled == false))
                spielerVerloren = true;
            if ((C1.Text == B2.Text) && (B2.Text == A3.Text) && (C1.Enabled == false))
                spielerVerloren = true;
            if ((D2.Text == C3.Text) && (C3.Text == B4.Text) && (D2.Enabled == false))
                spielerVerloren = true;

            //Unentschieden Check
            if(runde == 16)
            {
                MessageBox.Show("Unentschieden!");
                steuerungAusschalten();
            }

            //Gewinner Anzeige + Ausschalten der Steuerung
            if (spielerVerloren == true)
            {
                String gewinner = "";
                if(kreisZug == true)
                {
                    gewinner = "X";
                }
                else
                {
                    gewinner = "O";
                }
                MessageBox.Show($"{gewinner} gewinnt!");
                steuerungAusschalten();


            }

        }


        //Methode zum deaktivieren der Spielersteuerung
        private void steuerungAusschalten()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button k = (Button)c;
                    k.Enabled = false;
                }
            }
            catch { }

               
        }
    }
}
