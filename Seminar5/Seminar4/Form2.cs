using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar4
{
    public partial class Form2 : Form
    {
        List<Student> listStudents2 = new List<Student>();//sem5
        public Form2(List<Student> students)
        {
            InitializeComponent();
            listStudents2=students;//sem5
            //textBox1.Text = students.Count.ToString();
            foreach (Student s in listStudents2)
                textBox1.Text += s.ToString() + Environment.NewLine;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //serializare
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);
            //bf.Serialize(fs, textBox1.Text);
            bf.Serialize(fs, listStudents2); //error if
                                             //Student is not marked as [serializable]
            fs.Close();
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // deserializare

            textBox1.Clear();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("fisier.dat", FileMode.Open, FileAccess.Read);
            //textBox1.Text = (string)bf.Deserialize(fs);
            List<Student> lista3 = (List<Student>)bf.Deserialize(fs);

            foreach (Student s in lista3)
                textBox1.Text += s.ToString() + Environment.NewLine;

            fs.Close();

        }
    }
}
