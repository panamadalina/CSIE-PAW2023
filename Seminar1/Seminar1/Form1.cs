namespace Seminar1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(tbNume.Text);

            int cod = Convert.ToInt32(tbCod.Text);
            string nume = tbNume.Text;
            int varsta = Convert.ToInt32(tbVarsta.Text);
            float medie = (float)Convert.ToDouble(tbMedie.Text);

            Student s = new Student(cod, nume, varsta, medie);

            MessageBox.Show(s.ToString());
           // MessageBox.Show(s.afisare());
        }
    }
}