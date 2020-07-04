using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data; 

namespace PALUNO
{
    class Aluno
    {
        private int raAluno;
        private string nomeAluno;
        private int cidadeIdcidade;

        public int RaAluno {
            get { return raAluno; }
            set { raAluno = value; }
        }
        public string NomeAluno {
            get { return nomeAluno; }
            set { nomeAluno = value; }
        }
        public int CidadeIdcidade {
            get { return cidadeIdcidade; }
            set { cidadeIdcidade = value; }
        }

        public DataTable Listar()
        {
            SqlDataAdapter daAluno;
            DataTable dtAluno = new DataTable();
            try
            {
                daAluno = new SqlDataAdapter("SELECT * FROM TBALUNO", FrmPrincipal.conexao);
                daAluno.Fill(dtAluno);
                daAluno.FillSchema(dtAluno, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtAluno;
        }

        public int Salvar()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;
                int nReg;
                mycommand = new SqlCommand("INSERT INTO TBALUNO VALUES(@ra_aluno,@nome_aluno,@cidade_id_cidade)", FrmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@ra_aluno", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nome_aluno", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@cidade_id_cidade", SqlDbType.Int));
                mycommand.Parameters["@ra_aluno"].Value = raAluno;
                mycommand.Parameters["@nome_aluno"].Value = nomeAluno;
                mycommand.Parameters["@cidade_id_cidade"].Value = cidadeIdcidade;
                nReg = mycommand.ExecuteNonQuery();
                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public int Alterar()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;
                int nReg = 0;
                mycommand = new SqlCommand("UPDATE TBALUNO SET NOME_ALUNO=@nome_aluno,CIDADE_ID_CIDADE=@cidade_id_cidade WHERE RA_ALUNO=@ra_aluno", FrmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@ra_aluno", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nome_aluno", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@cidade_id_cidade", SqlDbType.Int));
                mycommand.Parameters["@ra_aluno"].Value = raAluno;
                mycommand.Parameters["@nome_aluno"].Value = nomeAluno;
                mycommand.Parameters["@cidade_id_cidade"].Value = cidadeIdcidade;
                nReg = mycommand.ExecuteNonQuery();
                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public int Excluir()
        {
            int nReg = 0;
            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("DELETE FROM TBALUNO WHERE RA_ALUNO=@ra_aluno", FrmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@ra_aluno", SqlDbType.Int));
                mycommand.Parameters["@ra_aluno"].Value = Convert.ToInt16(raAluno);
                nReg = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nReg;
        }
    }
}
