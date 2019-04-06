using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moda_System.Classes
{
    public class ErrosDB
    {
        public string ErrorMessage { get; set; }
        public string PropertyName { get; set; }

        public ErrosDB(string _msgerro, string _propname)
        {
            ErrorMessage = _msgerro;
            PropertyName = _propname;
        }
    }
}
