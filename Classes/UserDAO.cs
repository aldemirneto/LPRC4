using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DAO;
using System.Text;
using System.Threading.Tasks;
// using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace noteHub
{
    public class UserDAO
    {
            public List<User> List()
            {
                List<User> lista = new List<User>();
                try
                {
                    DataTable objDataTable = null;
                    //Se quiser personalizar a busca
                    string strSQL = "select Username, Password from User";
                    objDataTable = DAO.AcessoDadosMySQL.ExecutaConsultar(CommandType.Text, strSQL);
                    if (objDataTable.Rows.Count <= 0)
                    {
                        return lista;
                    }

                    foreach (DataRow objLinha in objDataTable.Rows)
                    {
                        User objNovoUser = new User();
                        objNovoUser.Username = objLinha["Username"] != DBNull.Value ? Convert.ToString(objLinha["Username"]) : "null";
                        objNovoUser.Password = objLinha["Password"] != DBNull.Value ? Convert.ToString(objLinha["Password"]) : "";

                        lista.Add(objNovoUser);
                    }
                    return lista;
                }
                catch (Exception)
                {
                    return lista;
                }
            }

            public bool Create(User user)
            {
                try
                {
                    DAO.AcessoDadosMySQL.LimparParametros();

                    object objRetorno = null;
                    if (user != null)
                    {
                        //AcessoDados.AcessoDadosPostgreSQL.AdicionarParametros("@intCod_banda", banda.Codigo);
                        DAO.AcessoDadosMySQL.AdicionarParametros("@Name", user.Name);

                        string strSQL = "insert into User (Name) values ( @Name);";
                        objRetorno = DAO.AcessoDadosMySQL.ExecutarManipulacao(CommandType.Text, strSQL);
                    }

                    int intResultado = 0;
                    if (objRetorno != null)
                    {
                        if (int.TryParse(objRetorno.ToString(), out intResultado))
                            return true;
                    }

                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public bool Edit(User user)
            {
                try
                {
                    DAO.AcessoDadosMySQL.LimparParametros();

                    object objRetorno = null;
                    if (user != null)
                    {
                        DAO.AcessoDadosMySQL.AdicionarParametros("@Username", user.Username);
                        DAO.AcessoDadosMySQL.AdicionarParametros("@Name", user.Name);

                        string strSQL = "update User set Name = @Name where Username = @USername; select @Username;";
                        objRetorno = DAO.AcessoDadosMySQL.ExecutarManipulacao(CommandType.Text, strSQL);
                    }

                    int intResultado = 0;
                    if (objRetorno != null)
                    {
                        if (int.TryParse(objRetorno.ToString(), out intResultado))
                            return true;
                    }

                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public bool Delete(User user)
            {
                try
                {
                    DAO.AcessoDadosMySQL.LimparParametros();

                    object objRetorno = null;
                    if (user != null)
                    {
                        DAO.AcessoDadosMySQL.AdicionarParametros("@Username", user.Username);

                        string strSQL = "delete from User where Username = @Username; select @Username;";
                        objRetorno = DAO.AcessoDadosMySQL.ExecutarManipulacao(CommandType.Text, strSQL);
                    }

                    int intResultado = 0;
                    if (objRetorno != null)
                    {
                        if (int.TryParse(objRetorno.ToString(), out intResultado))
                            return true;
                    }

                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }


        }
    }

