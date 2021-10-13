using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRG2782_WMalan_EWalters_JBlignaut.Business_Layer
{
    internal class Module:IComparable<Module>
    {
        string moduleCode, moduleName, moduleDescription, links;

        public Module(string moduleCode, string moduleName, string moduleDescription, string links)
        {
            this.ModuleCode = moduleCode;
            this.ModuleName = moduleName;
            this.ModuleDescription = moduleDescription;
            this.Links = links;
        }

        public string ModuleCode { get => moduleCode; set => moduleCode = value; }
        public string ModuleName { get => moduleName; set => moduleName = value; }
        public string ModuleDescription { get => moduleDescription; set => moduleDescription = value; }
        public string Links { get => links; set => links = value; }

        public int CompareTo(Module other)
        {
            return this.ModuleName.CompareTo(other.ModuleName);
        }
    }
}
