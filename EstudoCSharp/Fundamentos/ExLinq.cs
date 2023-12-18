using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace EstudoCSharp.Fundamentos {
    public class Aluno {
        public string nome;
        public int idade;
        public double nota;
    }
    public class ExLinq {
        public static void Exec() {
            var alunos = new List<Aluno> {
            new Aluno() {nome = "pedro", idade = 15, nota = 8.5},
            new Aluno() {nome = "luiz", idade = 16, nota = 8.1},
            new Aluno() {nome = "clara", idade = 15, nota = 7.8},
            new Aluno() {nome = "babi", idade = 16, nota = 7.5},
            new Aluno() {nome = "raissa", idade = 16, nota = 9.5}
            };
            Console.WriteLine("======Alunos aprovados=====");
            var aprovados = alunos.Where(a => a.nota >= 8)
                .OrderBy(a=> a.nota);
            foreach(var a in aprovados) {
                Console.WriteLine($"Nome: {a.nome}, Nota: {a.nota}");
            }
            Console.WriteLine("======Chamada=====");
            var chamada = alunos.OrderBy(a => a.nome).Select(a => a.nome);
            foreach(var a in chamada) {
                Console.WriteLine(a);
            }
            Console.WriteLine("===Aprovados por idade===");
            var AprovIdade = 
                from aluno in alunos
                where aluno.nota>=8
                orderby aluno.idade
                select new { aluno.nome, aluno.nota };
            foreach (var aluno in AprovIdade) {
                Console.WriteLine($"Nome: {aluno.nome}, Nota: {aluno.nota}");
            }
        }
        
    }
}
