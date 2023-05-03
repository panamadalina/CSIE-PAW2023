using System.Drawing.Printing;

namespace test_sem8
{
    public partial class Form1 : Form
    {

        int nrElem = 0;
        double[] vect = new double[100]; //double ca sa permita si afisarea de valori cu virgula
        const int marg = 10; //margine
        bool vb = false; //imi va spune daca am citit mai intai datele din fisier si daca am datele fac reprezentarea
        Font font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold); //dimensiune 12
        Color culoare = Color.Blue;

        public Form1()
        {
            InitializeComponent();
        }



        private void construiesteGraficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //citim datele din fisier si le incarcam intr-un vector declarat la nivelul clasei
            StreamReader sr = new StreamReader("Fisier.txt");
            string linie = null; //citesc o linie
            while ((linie = sr.ReadLine()) != null)
            {
                vect[nrElem] = Convert.ToDouble(linie);
                nrElem++;
                vb = true;
            }
            sr.Close();
            //  panel1_Paint();
            panel1.Invalidate();//traseaza graficul
        }


        //pt a desena tratam evenimentul de print pe panel

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (vb == true)
            {
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.Red, 3);
                Rectangle rec = new Rectangle(panel1.Location.X + marg, 
                    panel1.Location.Y + 4 * marg,
                    panel1.Width - 2 * marg, 
                    panel1.Height - 5 * marg);
                g.DrawRectangle(pen, rec);


                Rectangle[] recs = new Rectangle[nrElem];
                double latime = rec.Width / nrElem / 3;
                double distanta = (rec.Width - latime * nrElem) / (nrElem + 1);//distanta dintre dreptunghiuri= din latime mare scad latimeMica*nrelem si impart la (nr elem+1)nr de distante
                double vMax = vect.Max();
                Brush br = new SolidBrush(culoare);
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle(
                        (int)(rec.Left + (i + 1) * distanta + i * latime),
                        (int)(rec.Bottom - vect[i] / vMax * rec.Height),
                        (int)latime,
                        (int)(vect[i] / vMax * rec.Height));//rec.left- dist de la x 

                    g.DrawString(vect[i].ToString(),
                        font,
                        br,
                        (int)(rec.Left + (i + 1) * distanta + i * latime),
                        (int)(rec.Bottom - vect[i] / vMax * rec.Height - font.Height - 5));

                }


                g.FillRectangles(br, recs);


                for (int i = 0; i < nrElem - 1; i++)
                {
                    g.DrawLine(pen,
                        new Point((int)(recs[i].Location.X + latime / 2), recs[i].Location.Y),
                        new Point((int)(recs[i + 1].Location.X + latime / 2), recs[i + 1].Location.Y));
                }
            }
        }
    }
}