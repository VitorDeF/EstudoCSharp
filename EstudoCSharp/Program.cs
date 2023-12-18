// See https://aka.ms/new-console-template for more information
using EstudoCSharp.Excecoes;
using EstudoCSharp.Fundamentos;
using System;

namespace EstucoCSharp {
    class Program {
        static void Main(String[] args) {
            PrimeiroPrograma p = new PrimeiroPrograma();
            p.Exec();
            EstdGS e = new EstdGS();
            e.Exec();
            ExEnums.Exec();
            StructVsClasse.Exec();
            RefEOut.Exec();
            Colecoes.Exec();
            Metodos.Exec();
            ExcecoesPersonalizadas.Exec();
            ExLinq.Exec();
        }
    }
}