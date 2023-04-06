namespace Seminar4
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbCod.Text == "")
            {
                errorProviderCod.SetError(tbCod, "Introduceti codul");
            }
            else
            {
                errorProviderCod.Clear();
            }

            if (tbNume.Text == "")
            {
                errorProviderNume.SetError(tbNume, "Introduceti nume");
            }
            else
            {
                errorProviderNume.Clear();
            }
            if (tbVarsta.Text == "")
            {
                errorProviderVarsta.SetError(tbVarsta, "Introduceti varsta");
            }
            else
            {
                errorProviderVarsta.Clear();
            }
            if (tbNote.Text == "")
            {
                errorProviderNote.SetError(tbNote, "Introduceti note");
            }
            else
            {
                errorProviderNote.Clear();
            }

            if (comboBoxSex.Text == "")
            {
                errorProviderSex.SetError(comboBoxSex, "Alegeti sexul");
            }
            else
            {
                errorProviderSex.Clear();
            }
            if (tbCod.Text != "" && tbNume.Text != "" && tbVarsta.Text != "" && tbNote.Text != "" && comboBoxSex.Text != "")
            {
                //  MessageBox.Show("Hello!");
                int cod = Convert.ToInt32(tbCod.Text);
                int varsta = Convert.ToInt32(tbVarsta.Text);//??

                string[] noteString = tbNote.Text.Trim().Split(',');
                int[] note = new int[noteString.Length];
                for (int i = 0; i < noteString.Length; i++)
                {
                    note[i] = Convert.ToInt32(noteString[i]);
                }
                char gen = Convert.ToChar(comboBoxSex.Text);
                Student s = new Student(cod, tbNume.Text, gen, varsta, note);
                students.Add(s);
                tbCod.Clear();
                tbNume.Clear();
                tbVarsta.Clear();
                tbNote.Clear();
                comboBoxSex.Text = "";
                MessageBox.Show("Studentul a fost adaugat cu succes!");
            }

        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(students);
            form2.ShowDialog();
            // MessageBox.Show();
        }
    }
}