using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoCSharp.Fundamentos {
    public struct SPonto {
        public int X;
        public int Y;
    }

    public class CPonto {
        public int X;
        public int Y;
        public void mudaPontoXY(int X, int Y) {
            this.X = X;
            this.Y = Y;
        }

        public virtual void imprimePonto() {
            Console.WriteLine("X: "+X + " Y: "+Y);
        }
    }

    public class CPonto3D : CPonto {
        public CPonto3D() : base() {

        }

        int Z;
        //oculta o método da classe pai. Diferente do override, não participa de re-instanciações
        public new void mudaPontoXY(int X, int Y) {
            this.X=X;
            this.Y=Y;
        }
        //faz o processo de override no método
        public override void imprimePonto() {
            Console.WriteLine("X: " + X + " Y: " + Y + " Z: "+Z);
        }
    }

    class StructVsClasse
    {
        public static void Exec() {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1; // Atribuição por VALOR!!!
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 X:{0}", ponto1.X);
            Console.WriteLine("Copia Ponto 1 X:{0}", copiaPonto1.X);

            CPonto ponto2 = new CPonto { X = 2, Y = 4 };
            CPonto copiaPonto2 = ponto2; // Atribuição por REFERÊNCIA!!!
            ponto2.X = 4;

            Console.WriteLine("Ponto 2 X:{0}", ponto2.X);
            Console.WriteLine("Copia Ponto 2 X:{0}", copiaPonto2.X);
        }
    }
}