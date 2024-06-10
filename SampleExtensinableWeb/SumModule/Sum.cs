using ExtensionInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SumModule;

public class Sum : IModule
{
    public IEnumerable<Type> AcceptedTypes { get; set; } = new List<Type> { typeof(decimal) };
    public string ModuleName { get => "Sum Module"; }

    //public decimal Calculate<decimal>(params decimal[] args)
    //{
    //    decimal sum = 0;
    //    foreach (var arg in args)
    //    {
    //        sum += arg;
    //    }
    //    return sum;
    //}

    //public static IModule CreateInstance()
    //{
    //    return new Sum();
    //}

    public decimal Calculate<T>(params T[] args)
    {
        decimal result = 0;
        foreach (var arg in args)
        {
            result += Convert.ToDecimal(arg);
        }
        return result;
    }
}