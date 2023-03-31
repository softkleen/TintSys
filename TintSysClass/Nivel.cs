using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace TintSysClass
{
    public class Nivel //(Abstração)
    {
        //atributos
        private int id;
        private string nome;
        private string sigla;

        // Propriedades (Encapsulamento) getters and setters
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sigla { get => sigla; set => sigla = value; }

        // Métodos contrutores 
        public Nivel() { } // vazio
        public Nivel(string _nome, string _sigla)
        {
            Nome = _nome;
            Sigla = _sigla;
        }
        public Nivel(int _id, string _nome, string _sigla)
        {
            Id = _id;
            Nome = _nome;
            Sigla = _sigla;
        }

        // Métodos da Classes (inserir, alterar, consultar,por Id, por nome, etc.... )
        public void Inserir() //teste ok
        {
            // cria uma variável com conexão de banco aberta
            var cmd = Banco.Abrir();
            // define o tipo de instrução MySQL a ser processada pelo serv banco dados 
            cmd.CommandType = CommandType.Text;
            // define a query sql especificada com parametros (@nome...)
            cmd.CommandText = "insert niveis (nome, sigla) values (@nome, @sigla)";
            // cria o parametro e associa ao valor
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.AddWithValue("@sigla", Sigla);
            // executa a instrução SQL na conexão
            cmd.ExecuteNonQuery();
            // obtendo o id do nível recém inserido
            cmd.CommandText = "select @@identity";
            // recupera o id na Propriedade
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            // fecha a conexão
            Banco.Fechar(cmd);
        }
        public static Nivel ObterPorId(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from niveis where id = @id";
            cmd.Parameters.AddWithValue("@id", _id);
            var dr = cmd.ExecuteReader();
            Nivel nivel = null;
            while(dr.Read()) 
            {
                nivel = new Nivel(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)
                    );
            }
            Banco.Fechar(cmd);
            return nivel;
        }
        public static List<Nivel> Listar()
        { 
            List<Nivel> lista = new List<Nivel>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from niveis order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Nivel(dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2)
                    )
                );
            }
            Banco.Fechar(cmd);
            return lista;
        }
        public void Atualizar() 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update niveis set nome = @nome, sigla = @sigla where id = @id";
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@nome",Nome);
            cmd.Parameters.AddWithValue("@sigla",Sigla);
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);  
        }
        public int Excluir()
        { 
            int msg = 0;
            var cmd = Banco.Abrir();
            cmd.CommandText = "delete from niveis where id ="+ id;
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    msg = 1;
                }
            }
            catch (Exception e)
            {
                if (e.Message.Contains("FOREIGN KEY"))
                msg = 2;
            }
            Banco.Fechar(cmd);
            return msg;
        }

    }
}
