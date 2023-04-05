using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 
{

}

namespace TintSysClass
{
    public class Produto
    {

        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Unidade { get; set; } 
        public string CodBar { get; set;}
        public double Preco { get; set;} 
        public double Desconto { get; set;}
        public bool Descontinuado { get; set;}

        public Produto()
        {

        }
        public Produto(string descricao, string unidade, string codBar, double preco, double desconto)
        {
            Descricao = descricao;
            Unidade = unidade;
            CodBar = codBar;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto(string descricao, string unidade, string codBar, double preco, double desconto, bool descontinuado)
        {
            Descricao = descricao;
            Unidade = unidade;
            CodBar = codBar;
            Preco = preco;
            Desconto = desconto;
            Descontinuado = descontinuado;
        }

        public Produto(int id, string descricao, string unidade, string codBar, double preco, double desconto, bool descontinuado)
        {
            Id = id;
            Descricao = descricao;
            Unidade = unidade;
            CodBar = codBar;
            Preco = preco;
            Desconto = desconto;
            Descontinuado = descontinuado;
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert produtos (descricao, unidade, codbar, " +
                "preco, desconto, descontinuado) " +
                " values(@descricao, @unidade, @codbar, @preco, @desconto, 0)";
            cmd.Parameters.Add("@descricao", MySqlDbType.VarChar).Value

        
        }
        public List<Produto> Listar(string descricao = "") 
        {   
            List<Produto> lista = new List<Produto>();
            // busca
            return lista; 
        }
        public static Produto ObterPorId(int id)
        {
            Produto produto = new Produto();    
            // busca
            return produto;
        }
        public void Atualizar() 
        { 
            
        }
        public void Arquivar() 
        { 
        
        }
        public void Restaurar()
        { 
        
        }

    }
}
