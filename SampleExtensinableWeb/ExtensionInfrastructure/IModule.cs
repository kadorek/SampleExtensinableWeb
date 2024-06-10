using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionInfrastructure;

public interface IModule
{
    public string ModuleName { get;  }
    IEnumerable<Type> AcceptedTypes { get; set; } 
    Decimal Calculate<T>(params T[] args);
    //abstract static IModule CreateInstance();
}
