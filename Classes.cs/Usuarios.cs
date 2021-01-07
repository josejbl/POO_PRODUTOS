using System;

namespace POO_PRODUTOS.Classes.cs
{
    public class Usuarios
    {
        public Usuarios(){
            //Cadastra usuario automaticamente quando essa classe for estnciada
            Cadastrar();
        }

        public Usuarios(int _codigo, string _nome, string _email, string _senha){
            Codigo = _codigo;
            Nome   = _nome;
            Email  = _email;
            Senha  = _senha;
            DataCadastro = DateTime.UtcNow;
        }
        int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email  { get; set; }
        public string Senha { get; set; }
        DateTime DataCadastro { get; set; }

        public void Cadastrar(){
            Nome = "Jose Tadeu";
            Email = "josetadeudosantostj@gmail.com";
            Senha = "123456";
            DataCadastro = DateTime.UtcNow;
        }
        
        public void Deletar(int cod){
            Nome  = "";
            Email = "";
            Senha = "";
            DataCadastro = DateTime.Parse("0000-00-00T00:00:00");


        }
        
        
        

        
 
    }
}