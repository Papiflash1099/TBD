using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> Listar(int idusuario)
        {
            List<Permiso> lista = new List<Permiso>();

            using (SqlConnection oconectar = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder consulta = new StringBuilder();
                    consulta.AppendLine("select p.IdRol,p.NombreMenu from PERMISO p");
                    consulta.AppendLine("inner join ROL r on r.IdRol = p.IdRol");
                    consulta.AppendLine("inner join USUARIO u on u.IdRol = r.IdRol");
                    consulta.AppendLine("where u.IdUsuario = @Idusuario");
                 
                    SqlCommand cmd = new SqlCommand(consulta.ToString(), oconectar);
                    cmd.Parameters.AddWithValue("@Idusuario", idusuario);
                    cmd.CommandType = CommandType.Text;

                    oconectar.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                oRolP = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]) },
                                NombreMenu = dr["NombreMenu"].ToString(),
                                
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Permiso>();
                }
            }
            return lista;
        }
    }
}
