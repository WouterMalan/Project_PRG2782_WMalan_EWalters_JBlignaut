using Project_PRG2782_WMalan_EWalters_JBlignaut.Business_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRG2782_WMalan_EWalters_JBlignaut.Data_Layer
{
    internal interface IDataHandler_Student
    {
       

        DataTable displayStudent();
        
        DataTable studentSearch(int num);


        string updateStudent(int num, string Fname, string date, string gender, string phone, string address, string moduleCode, string image);



        string deleteStudent(int num);


        string addStudent(int num, string Fname, string date, string gender, string phone, string address, string moduleCode, string image);
      
    }
}
