using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem4 {
    public class Student : Persoana /*,IComparable*/ {

        private int varsta;
        private string nume;
        private int[] note;

        public Student(string nume,int varsta, int[] note) {
            this.varsta = varsta;
            this.nume = nume;
            this.note = note;
        }
        public Student(int cod, string nume,char gen, int varsta, int[] note):base(cod,gen){
            
            this.varsta = varsta;
            this.nume = nume;
            this.note = note;
        }

        public override string? ToString() {
            string s= "Studentul "+nume+" are notele: ";
            for(int i = 0; i < note.Length; i++) {
                s += note[i].ToString()+",";
            }
            return s;

        }

        //public int CompareTo(Object? obj) {
        //    // throw new NotImplementedException();
        //    //  Student student= obj as Student;
        //    Student student = (Student)obj;
        //    if (student.nume.CompareTo(nume) == 0) {
        //        return 1;
        //    }
        //    else {
        //        return 0;
        //    }
        //    //return string.Compare(student.nume, nume);
        //}

        //public override int spuneAnNastere() {
        //    //throw new NotImplementedException();
        //    return System.DateTime.Now.Year- this.varsta;
        //}


    }
}
