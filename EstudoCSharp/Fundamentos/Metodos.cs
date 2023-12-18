using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoCSharp.Fundamentos {
    // Sempre retorno void
    public class  FuncaoLambda
    {
        public FuncaoLambda() {
            algoNoConsole();
        }
        Action algoNoConsole = () => {
            Console.WriteLine("Função lambda C#");
        };
    }
    // Possui retorno
    public class FuncaoFunc {
        public Func<int> jogarDado = () => {
            Random random = new Random();
            return random.Next(1, 7);
        };
        public Func<int, int, string> somaDeDois = (a, b) => "A soma dos dois números é: " + (a + b);
    }

    public delegate double Operacao(double x, double y);
    public class LambdaDelegate {
        public Operacao sum = (x, y) => x + y;
        public Operacao sub = (x, y) => x - y;
        public Operacao mult = (x, y) => x * y;
    }
    
    public class UsandoDeleg {
        public delegate double soma(double x, double y);

        static double operacaoSoma(double x, double y) {
            return x + y;
        }

        public UsandoDeleg() {
            soma op = operacaoSoma;
            Console.WriteLine(op(1, 2));
        }
    }

    public class Metodos {
        public static void Exec() {
            FuncaoLambda funcaoLambda = new FuncaoLambda();
            FuncaoFunc funcaoFunc = new FuncaoFunc();
            LambdaDelegate funcaoLambdaDel = new LambdaDelegate();
            Console.WriteLine("Função func: "+funcaoFunc.jogarDado());
            Console.WriteLine("Função func: "+funcaoFunc.somaDeDois(1, 2));
            Console.WriteLine($"Soma: {funcaoLambdaDel.sum(3,3)}\nSub: {funcaoLambdaDel.sub(3, 3)}\nMulti: {funcaoLambdaDel.mult(3, 3)}");
            UsandoDeleg usandoDeleg = new UsandoDeleg();
        }
    }
}
