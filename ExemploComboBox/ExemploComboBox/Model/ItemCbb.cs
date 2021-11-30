using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploComboBox.Model
{
    public class ItemCbb
    {
        public int Id { get; set; }
        public string Texto { get; set; }

        public ItemCbb(int id, string texto)
        {
            Id = id;
            Texto = texto;
        }

        public override string ToString()
        {
            return Texto;
        }
    }  
}
