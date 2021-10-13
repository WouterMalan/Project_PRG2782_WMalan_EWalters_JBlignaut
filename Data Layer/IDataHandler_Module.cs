using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRG2782_WMalan_EWalters_JBlignaut.Data_Layer
{
    internal interface IDataHandler_Module
    {
        DataTable displayModule();
        DataTable moduleSearch(string mcode);


        string updateModule(string mcode, string mname, string desc, string res);



        string deleteModule(string mcode);


        string addModule(string mcode, string mname, string desc, string res);
    }
}
