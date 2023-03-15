using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Seminar2
{
    public class Animal : ICloneable
    {

        //atribute
        //nume
        //varsta
        //greutate

        //constr fara param
        //cu param
        //getters
        //setters
        //toString

        private int varsta;

        private string nume;// { get; set; }
        private int greutate;// { get; set; }

        public int Varsta
        {
            get { return varsta; }
            set { varsta = value; }
        }
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public int Greutate
        {
            get { return greutate; }
            set { greutate = value; }
        }


        public Animal()
        {
            this.varsta = 0;
            this.nume = "Anonim";
            this.greutate = 0;

        }
        public Animal(string nume, int varsta, int greutate)
        {
            this.varsta = varsta;
            this.nume = nume;
            this.greutate = greutate;

        }

        public Animal(Animal animal)
        {
            this.varsta = animal.varsta;
            this.nume = animal.nume;
            this.greutate = animal.greutate;

        }
        public override string ToString()
        {
            return new String("\nAniaml: " + nume + " varsta: " + varsta + " are greutatea: " + greutate);
        }

        public object Clone()
        {
            //throw new NotImplementedException();
            //Var1:
            // return new Animal(this);//!!!

            //Var 2 Shallow Copy
            return this.MemberwiseClone() as Animal;

            //Var 3 Deep Copy
            /*var clone = this.MemberwiseClone() as Animal;
            clone.nume = String.Copy(Nume);
            // clone.varsta = new Varsta(IdInfo.IdNumber);
            //return clone;
            //https://stackoverflow.com/questions/2289420/what-is-the-method-memberwiseclone-doing
            */

        }
    }
}