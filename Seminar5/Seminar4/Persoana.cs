using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar4 {
    [Serializable]
    public  class Persoana {

        private int cod;
        private char gen;
        public Persoana() {
            cod = 0;
            gen = 'M';
        }

        public Persoana(int cod, char gen) {
            this.cod = cod;
            this.gen = gen;
        }


        //   public abstract int spuneAnNastere();
    }
}
