using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionInfrastructure;

public class ModuleException:Exception,IModuleException
{
    public ModuleException(string _msg): base( _msg )
    {
        
    }
}
