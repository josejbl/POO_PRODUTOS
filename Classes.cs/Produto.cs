using System;
using System.Collections.Generic;

namespace POO_PRODUTOS.Classes.cs
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set;}
        public Marca Marca { get; set; }
        public Usuarios CadastradoPor { get; set; }
        public List<Produto> ListaDeProduto { get; set; }
        
        public void Cadastrar(){
            Produto novoProduto = new Produto();

            Console.WriteLine("Digite o Código do Produto:");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Nome do Produto:");
            novoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o Preço do prduto");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            DataCadastro = DateTime.UtcNow;

            //Atribuindo nosso marca através de um metodos criador para cadastro

            Marca = Marca.CadastrarMarca();

            
            // Atribuímos o usuário atrvés do método construtor
            
            novoProduto.CadastradoPor = new Usuarios();

            ListaDeProduto.Add(novoProduto);
        }

        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in ListaDeProduto)
            {
            Console.WriteLine($"Código: {item.Codigo}");
            Console.WriteLine($"Produto: {item.NomeProduto}");
            Console.WriteLine($"Preco: R$ {item.Preco}");
            Console.WriteLine($"Data de Cadastro: {item.DataCadastro}");
            Console.WriteLine($"Marca :{item.Marca.NomeMarca}");
            Console.WriteLine($"Cadastrado por: {item.CadastradoPor.Nome}");
            Console.WriteLine();
            }
            Console.ResetColor();
        }
        public void Deletar(int cod){
            Produto prodDelete = ListaDeProduto.Find(p => p.Codigo == cod);
            ListaDeProduto.Remove(prodDelete);
        }
    }
}
            
            



            

        
        
        
        
        