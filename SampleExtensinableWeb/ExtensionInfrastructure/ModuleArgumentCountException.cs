using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionInfrastructure;

public class ModuleArgumentCountException:ModuleException
{
    public ModuleArgumentCountException(string _msg= "Wrong count of argument") :base(_msg)
    {

    }
}
