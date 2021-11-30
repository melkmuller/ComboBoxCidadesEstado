using ExemploComboBox.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ExemploComboBox.Controller
{
    public class CidadeController
    {
        public DataTable BuscarCidadePorIdEstado(int idEstado)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select * from Cidades where idEstado = @1", out retorno, "@1", idEstado);
                return retorno;
            }
        }
    }
}
