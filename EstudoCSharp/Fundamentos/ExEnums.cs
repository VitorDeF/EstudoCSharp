using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoCSharp.Fundamentos {
    
    public enum Genero { Acao, Aventura, Terror, Animacao};
    
    public class Filme {
        public string Titulo;
        public Genero GeneroFilme;
    }
    public class ExEnums {
        public static void Exec() {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filme = new Filme();
            filme.Titulo = "Anabelle";
            filme.GeneroFilme= Genero.Terror;
            Console.WriteLine("{0} é filme de {1}",filme.Titulo, filme.GeneroFilme);
        }
    }
}
