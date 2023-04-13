using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TintSysClass
{
    public class Pedido
    {

        // propriedades
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }  
        public double Desconto { get; set; }    
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }    
        public DateTime ArquivadoEm { get; set; }
        public string HashCode { get; set;}
        public List<ItemPedido> Itens { get; set; }

        public Pedido()
        {
        }

        public Pedido(DateTime data, string status, double desconto, Cliente cliente, Usuario usuario, DateTime arquivadoEm, string hashCode)
        {
            Data = data;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            ArquivadoEm = arquivadoEm;
            HashCode = hashCode;
        }

        public Pedido(int id, DateTime data, string status, double desconto, Cliente cliente, Usuario usuario,string hashCode)
        {
            Id = id;
            Data = data;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
           // ArquivadoEm = arquivadoEm;
            HashCode = hashCode;
            Itens = ItemPedido.ListarPorPedido(id); 
        }

        public Pedido(Cliente cliente, Usuario usuario)
        {
            Cliente = cliente;
            Usuario = usuario;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert pedidos (data, status, desconto, cliente_id, usuario_id,hashcode) " +
                " values(default, default, 0, @cliente, @usuario, @hash)";
            cmd.Parameters.Add("@cliente",MySqlDbType.Int32).Value= Cliente.Id;
            cmd.Parameters.Add("@usuario", MySqlDbType.Int32).Value = Usuario.Id;
            cmd.Parameters.Add("@hash", MySqlDbType.VarChar).Value = ObterHashCode(Cliente.Id, Usuario.Id);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }
        public static Pedido ObterPorId(int id) 
        {
            Pedido pedido = null;
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from pedidos where id = "+id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedido = new Pedido(
                    dr.GetInt32(0),
                    dr.GetDateTime(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    Cliente.ObterPorId(dr.GetInt32(4)),
                    Usuario.ObterPorId(dr.GetInt32(5)),
                    dr.GetString(7)
                    );
            }

            return pedido;
        }

        public static List<Pedido> ObterPorCliente(int id) 
        {
            List<Pedido> pedidos = null;
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from pedidos where cliente_id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(
                    new Pedido(
                        dr.GetInt32(0),
                        dr.GetDateTime(1),
                        dr.GetString(2),
                        dr.GetDouble(3),
                        Cliente.ObterPorId(dr.GetInt32(4)),
                        Usuario.ObterPorId(dr.GetInt32(5)),

                        dr.GetString(7)
                        )
                    );
            }
            return pedidos;
        }
        public static List<Pedido> Listar() 
        {
            List<Pedido> pedidos = null;
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from pedidos ";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(
                    new Pedido(
                        dr.GetInt32(0),
                        dr.GetDateTime(1),
                        dr.GetString(2),
                        dr.GetDouble(3),
                        Cliente.ObterPorId(dr.GetInt32(4)),
                        Usuario.ObterPorId(dr.GetInt32(5)),

                        dr.GetString(7)
                        )
                    );
            }
            return pedidos;

        }
        public static bool Fechar(int id)
        {
            bool teste = false;
            MySqlCommand cmd = null;
            try
            {
                cmd = Banco.Abrir();
                cmd.CommandText = "update pedidos set status = 'F' where id = " + id;
                if (cmd.ExecuteNonQuery() > 0)
                    teste=true;
            }
            catch (Exception)
            {
                //  mostra o erro
            }
            finally
            { 
                Banco.Fechar(cmd);
                
            }
            return teste;

           
            
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update pedidos set desconto = @desconto " +
                "where id = "+Id;
            cmd.Parameters.Add("@desconto", MySqlDbType.Decimal).Value = Desconto;
            cmd.ExecuteNonQuery();
        }
        public void Arquivar() { }
        public void Restaurar() { }

        private string ObterHashCode(int cli, int user) 
        { 
            StringBuilder sb = new StringBuilder();
            sb.Append("PD-");
            Random rd = new Random();
            sb.Append(rd.Next(123450,543210));
            sb.Append("-");
            sb.Append(cli);
            sb.Append("-");
            sb.Append(user);
            return sb.ToString(); 
        }

    }
}
