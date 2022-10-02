using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noteHub
{
    internal class NotaDAO
    {
        public List<Note> List()
        {
            List<Note> lista = new List<Note>();
            try
            {
                DataTable objDataTable = null;
                //Se quiser personalizar a busca
                string strSQL = "select Note, Descricao from Notes";
                objDataTable = DAO.AcessoDadosMySQL.ExecutaConsultar(CommandType.Text, strSQL);
                if (objDataTable.Rows.Count <= 0)
                {
                    return lista;
                }

                foreach (DataRow objLinha in objDataTable.Rows)
                {
                    Note objNovaNota = new Note();
                    objNovaNota.Name = objLinha["Name"] != DBNull.Value ? Convert.ToString(objLinha["Name"]) : "null";
                    objNovaNota.Description = objLinha["Description"] != DBNull.Value ? Convert.ToString(objLinha["Description"]) : "";

                    lista.Add(objNovaNota);
                }
                return lista;
            }
            catch (Exception)
            {
                return lista;
            }
        }

        public bool Create(Note note)
        {
            try
            {
                DAO.AcessoDadosMySQL.LimparParametros();

                object objRetorno = null;
                if (note != null)
                {
                    //AcessoDados.AcessoDadosPostgreSQL.AdicionarParametros("@intCod_banda", banda.Codigo);
                    DAO.AcessoDadosMySQL.AdicionarParametros("@Desc_nota", note.Description);

                    string strSQL = "insert into Note (Description) values ( @Desc_nota);";
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

        public bool Edit(Note note)
        {
            try
            {
                DAO.AcessoDadosMySQL.LimparParametros();

                object objRetorno = null;
                if (note != null)
                {
                    DAO.AcessoDadosMySQL.AdicionarParametros("@Topic", note.Topic);
                    DAO.AcessoDadosMySQL.AdicionarParametros("@Description", note.Description);

                    string strSQL = "update User set Topic = @Topic where Description = @Description; select @Topic;";
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

        public bool Delete(Note nota)
        {
            try
            {
                DAO.AcessoDadosMySQL.LimparParametros();

                object objRetorno = null;
                if (nota != null)
                {
                    DAO.AcessoDadosMySQL.AdicionarParametros("@idnota", nota.ID);

                    string strSQL = "delete from Notes where IDNOTA = @idnota; select @idnota;";
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
