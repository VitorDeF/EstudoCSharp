using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoCSharp.Fundamentos {

    public class MeuArray {
        public string[] alunos = { "A", "B", "C" };
        public MeuArray() {
            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }
        }
    }
    public class MinhaLista {
        public List<string> alunos = new List<string>();
        public List<string> alunos2 = new List<string> {"Dante","Elder","Felipe"};
        public MinhaLista() {
            alunos.Add("Ana");
            alunos.Add("Bernardo");
            alunos.Add("Carlos");
            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }
            alunos.AddRange(alunos2);
            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }
        }
    }
    public class MeuArrayList {
        public ArrayList arraylist = new ArrayList {
            3,
            "String",
            true
            };
        public MeuArrayList() {
            arraylist.Add(3.14);
            foreach (var item in arraylist) { 
                Console.WriteLine($"{item} => {item.GetType()}");
            }
        }
    }
    public class MeuSet {
        public HashSet<string> produto = new HashSet<string> {"livro", "camisa", "filme"};
        public HashSet<string> produto2 = new HashSet<string> {"dvd", "disco", "série"};
        public MeuSet() {
            produto.Add("talher");
            Console.WriteLine("tamanho: "+produto.Count);
            produto.Add("estojo");
            Console.WriteLine("tamanho: "+produto.Count);
            produto.Add("estojo");
            Console.WriteLine("tamanho: "+produto.Count);
            foreach (var item in produto) {
                Console.WriteLine($"item {item}");
            }
            Console.WriteLine("tamanho: "+produto.Count);
            produto.UnionWith( produto2);
            Console.WriteLine("tamanho: "+produto.Count);
            foreach (var item in produto) {
                Console.WriteLine($"item {item}");
            }
        }
    }
    public class MinhaQueue {
        public Queue<string> fila = new Queue<string>();
        public MinhaQueue() {
            fila.Enqueue("Fulano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Ciclano");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);
            Console.WriteLine(fila.Peek());
        }
    }
    public class MeuStack {
        public Stack pilha = new Stack();
        public MeuStack() {
            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(false);
            foreach (var item in pilha) {
                Console.WriteLine(item);
            }
            Console.WriteLine("Pop: "+pilha.Pop());
            Console.WriteLine(pilha.Count);
            Console.WriteLine("Peek: "+pilha.Peek());
            Console.WriteLine(pilha.Count);
        }
    }
    public class MeuDictonary {
        public Dictionary<int, string> dicionario = new Dictionary<int, string>();
        public MeuDictonary() {
            dicionario.Add(1, "Primeira");
            dicionario.Add(2, "Segunda");
            dicionario.Add(3, "Terceira");
            Console.WriteLine($"Tem chave 1: {dicionario.ContainsKey(1)} ... Tem valor primeiro: {dicionario.ContainsValue("Primeiro")}");
            Console.WriteLine($"Chave 3: {dicionario[3]}");
            Console.WriteLine($"Chave 4: {dicionario.GetValueOrDefault(4)}");
            dicionario.TryGetValue(2, out string segundo);
            Console.WriteLine($"Chave 2: {segundo}");
            foreach (var item in dicionario) {
                Console.WriteLine($"{item.Key} é a {item.Value} chave");
            }
        }
    }
    public class Colecoes {
        public static void Exec() {
            MeuArray a = new MeuArray();
            MinhaLista a1 = new MinhaLista();
            MeuArrayList a2 = new MeuArrayList();
            MeuSet a3 = new MeuSet();
            MinhaQueue a4 = new MinhaQueue();
            MeuStack a5 = new MeuStack();
            MeuDictonary a6 = new MeuDictonary();
        }
    }
}
