using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EstudoCSharp.Fundamentos {

     class EstdGS {

        string nome;
        public string Nome {
            get { return nome; }
            set { nome = value; }
            // get => nome;
            // set => this.nome = nome
        }
        public string Tipo { get; set; }

        public void Exec() {
            Nome = "nome1";
            Console.WriteLine(Nome);
            Tipo = "Carro";
            Console.WriteLine(Tipo);
        }
    }
}