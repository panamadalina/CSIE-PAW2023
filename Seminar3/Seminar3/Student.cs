using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3 {
    public class Student : Persoana,IComparable {

        private int varsta;
        private string nume;
        private int[] note;

        public Student(int varsta, string nume, int[] note) {
            this.varsta = varsta;
            this.nume = nume;
            this.note = note;
        }

        public int CompareTo(Object? obj) {
            // throw new NotImplementedException();
            //  Student student= obj as Student;
            Student student = (Student)obj;
            if (student.nume.CompareTo(nume) == 0) {
                return 1;
            }
            else {
                return 0;
            }
            //return string.Compare(student.nume, nume);
        }

        public override int spuneAnNastere() {
            //throw new NotImplementedException();
            return 2023- this.varsta;
        }
    }
}
