using ExemploComboBox.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ExemploComboBox.Controller
{
    class EstadoController
    {
        public DataTable BuscarTodosEstados()
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using(banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select * from Estado", out retorno);

                return retorno;
            }
        }

       
        
    }
}
