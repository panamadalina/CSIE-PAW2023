using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3
{
    public class Leu:Animal,IComparabil {

        private char sex;
        private string[] hrana;
        private bool esteAlfa;

        public Leu(char sex, string[] hrana, bool esteAlfa) {
            this.sex = sex;
            this.hrana = hrana;
            this.esteAlfa = esteAlfa;
        }

        public Leu() {
            this.sex = 'M';
            this.hrana = null;
            this.esteAlfa = false;
        }

        public char Sex {
            get { return sex; }
            set { sex = value; }
        }
        public string[] Hrana {
            get { return hrana; }
            set { hrana = value; }
        }
        public bool EsteAlfa {
            get { return esteAlfa; }
            set { esteAlfa = value; }
        }

        public override string ToString() {
            return "Animalul este un leu de gen: "+this.sex+"si este/nu este alfa:"+this.esteAlfa;//base.ToString();
        }

        public bool Compare(Leu l) {
            // throw new NotImplementedException();
            if (this.hrana.Length > l.hrana.Length) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
