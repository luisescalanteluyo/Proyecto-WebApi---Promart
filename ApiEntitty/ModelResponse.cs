using System;
using System.Collections.Generic;
using System.Text;

namespace ApiEntitty
{
    public class ModelResponse
    {
        public bool bEstado { get; set; }
        public int iCodigo { get; set; }
        public string sRpta { get; set; }
        //public DataTable dt = new DataTable();
        public object obj { get; set; }
    }
}
