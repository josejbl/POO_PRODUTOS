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
            
            CadastradoPor = new Usuarios();
        }

        public void Listar(){

        }
        
        
        
        
        
    }
}