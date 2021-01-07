using System;
using System.Collections.Generic;

namespace POO_PRODUTOS.Classes.cs
{
    public class Marca
    {
        int Codigo { get; set; }
        public string NomeMarca { get; set; }
        DateTime DataCadastro { get; set; }

        List<Marca> Marcas { get; set; }
        public Marca CadastrarMarca(){

            Marca novaMarca = new Marca();

            Console.WriteLine("Digite o Código da marca :");
            Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da marca :");
            NomeMarca = Console.ReadLine();

            novaMarca.DataCadastro = DateTime.UtcNow;

            Marcas.Add(novaMarca);

            return novaMarca;
            
    

                              

         
        }
        public void Listar(){

            Console.WriteLine("Marcas Cadastradas:");
            foreach ( Marca item in Marcas)
            {
                Console.WriteLine($"Código : {item.Codigo}");
                Console.WriteLine($"Marca : {item.NomeMarca}");
                Console.WriteLine($"Data do Cadastro : {item.DataCadastro}");
                
                
                
            }

        }
        public void Deletar(int cod){
            Marca marcaDElete = Marcas.Find(m => m.Codigo == cod);
            Marcas.Remove(marcaDElete);

        }
        
        
        
        
    }
}