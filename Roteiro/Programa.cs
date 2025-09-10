using Roteiro.Roteiro1;
using Roteiro.Roteiro2;
using System;

namespace Roteiro
{
    internal class Programa
    {
        static void Main(string[] args)
        {
            //PESSOA
            /*
            Pessoa p = new Pessoa();
            p.idade = 12;
            p.nome = "Roberto";
            p.cargo = "Funcionario";
            p.apresentar();

            Pessoa p1 = new Pessoa();
            p1.idade = 21;
            p1.nome = "Vinícius";
            p1.cargo = "Gerente";
            p1.apresentar();
            p1.apresentarSalario();

            Pessoa p2 = new Pessoa();
            p2.idade = 30;
            p2.nome = "Márcio";
            p2.cargo = "Estagiario";
            p2.apresentar();
            p2.apresentarSalario();

            Pessoa p3 = new Pessoa();
            p3.idade = 15;
            p3.nome = "Herison";
            p3.cargo = "Desenvolvedor";
            p3.apresentar();
            p3.apresentarSalario();
            */

            //FANTASMINHA
            /*Fantasminha f1 = new Fantasminha();

            f1.nick = "Rick";
            f1.cor = "Vermelho";
            f1.habilidade = "Teleporte";

            f1.gerarFantasminha();
            f1.Mover("direita");
            */

            //PRODUTO
            /*
             * Produto p = new Produto("Celular", 1500);
            p.ExibirDetalhes();
            p.Preco = -200;
            */

            //CARRO
            /*
            Carro c = new Carro("Ferrari");
            c.Acelerar(50);
            Console.WriteLine(c.VelocidadeAtual); // Deve exibir 50
            c.Frear(30);
            Console.WriteLine(c.VelocidadeAtual); // Deve exibir 20
            c.Frear(50); // Não pode ficar negativo, deve exibir 0
            */

            //ELEVADOR
            /*
            Elevador e = new Elevador(10); // 10 andares
            e.Subir();
            e.Subir();
            Console.WriteLine(e.AndarAtual); // Deve exibir 2
            e.Descer();
            Console.WriteLine(e.AndarAtual); // Deve exibir 1
            e.Descer();
            e.Descer(); // Deve continuar em 0
            */

        }
    }
}
