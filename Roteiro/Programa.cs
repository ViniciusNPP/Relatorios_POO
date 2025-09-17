using Roteiro.Roteiro1;
using Roteiro.Roteiro2;
using Roteiro.Roteiro3;
using Roteiro.Roteiro3.Roteiro3._3;
using Roteiro.Roteiro3.Roteiro3._4;
using Roteiro.Roteiro4.Roteiro4._1;
using Roteiro.Roteiro4.Roteiro4._2;
using System;

namespace Roteiro
{
    internal class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PESSOA");
            Console.WriteLine("===================================");

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

            Console.WriteLine("===================================");
            Console.WriteLine("FANTASMINHA");
            Console.WriteLine("===================================");

            Fantasminha f1 = new Fantasminha();

            f1.nick = "Rick";
            f1.cor = "Vermelho";
            f1.habilidade = "Teleporte";

            f1.gerarFantasminha();
            f1.Mover("direita");

            Console.WriteLine("===================================");
            Console.WriteLine("PRODUTO");
            Console.WriteLine("===================================");

            Produto pe = new Produto("Celular", 1500);
            pe.ExibirDetalhes();
            pe.Preco = -200;

            Console.WriteLine("===================================");
            Console.WriteLine("CARRO");
            Console.WriteLine("===================================");

            Carro c = new Carro("Ferrari");
            c.Acelerar(50);
            Console.WriteLine(c.VelocidadeAtual); // Deve exibir 50
            c.Frear(30);
            Console.WriteLine(c.VelocidadeAtual); // Deve exibir 20
            c.Frear(50); // Não pode ficar negativo, deve exibir 0

            Console.WriteLine("===================================");
            Console.WriteLine("ELEVADOR");
            Console.WriteLine("===================================");

            Elevador e = new Elevador(10); // 10 andares
            e.Subir();
            e.Subir();
            Console.WriteLine(e.AndarAtual); // Deve exibir 2
            e.Descer();
            Console.WriteLine(e.AndarAtual); // Deve exibir 1
            e.Descer();
            e.Descer(); // Deve continuar em 0

            Console.WriteLine("===================================");
            Console.WriteLine("ANIMAL");
            Console.WriteLine("===================================");

            Animal a = new Animal();
            a.emitirSom();
            Cachorro ca = new Cachorro();
            ca.emitirSom();

            Console.WriteLine("===================================");
            Console.WriteLine("PEDIDO");
            Console.WriteLine("===================================");

            Cliente cliente = new Cliente();
            cliente.RealizarPedido("Cachorro Quente");

            Console.WriteLine("===================================");
            Console.WriteLine("INTERFACE VEÍCULO");
            Console.WriteLine("===================================");

            Carro_ carro = new Carro_();
            Bicicleta bike = new Bicicleta();
            carro.Mover();
            bike.Mover();

            Console.WriteLine("===================================");
            Console.WriteLine("INTERFACE VOAR E NADAR");
            Console.WriteLine("===================================");

            Aguia aguia = new Aguia();
            Peixe peixe = new Peixe();
            Pato pato = new Pato();
            aguia.Voar();
            peixe.Nadar();
            pato.Voar();
            pato.Nadar();

            Console.WriteLine("===================================");
            Console.WriteLine("PAGAMENTOS");
            Console.WriteLine("===================================");

            string[] metodoPagamento = { "pix", "cartao", "boleto" };

            foreach (var i in metodoPagamento)
            {
                if (i == "pix")
                {
                    Pix pix = new Pix();
                    pix.ProcessarPagamento();
                }
                else if (i == "cartao")
                {
                    CartaoCredito cartao = new CartaoCredito();
                    cartao.ProcessarPagamento();
                }
                else
                {
                    BoletoBancario boleto = new BoletoBancario();
                    boleto.ProcessarPagamento();
                }
            }

            Console.WriteLine("===================================");
            Console.WriteLine("FUNCIONÁRIOS");
            Console.WriteLine("===================================");

            Gerente g = new Gerente() { Salario = 5000 };
            g.CalcularSalario();
            Programador pr = new Programador() { Salario = 5000 };
            pr.CalcularSalario();
        }
    }
}
