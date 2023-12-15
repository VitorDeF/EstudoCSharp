using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoCSharp.Fundamentos {
    class PrimeiroPrograma {
        // Campo imutável após a primeira leitura;
        readonly string hello;

        public PrimeiroPrograma() {
            hello = "Hello, World!";
        }
        public void Exec() {
            Console.WriteLine(hello);

        }
    }
}
