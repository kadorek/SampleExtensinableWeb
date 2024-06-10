using ExtensionInfrastructure;
using System.Reflection;

namespace SampleExtensinableWeb.Services;

public class ModuleService
{
    private readonly IHttpContextAccessor accessor;
    private readonly IWebHostEnvironment env;

    public ModuleService(IHttpContextAccessor _accessor, IWebHostEnvironment _env)
    {
        accessor = _accessor;
        env = _env;
    }


    public IEnumerable<IModule> GetModules()
    {

        //var assembllyInfo=Assembly.LoadFile(env.ContentRootPath + "\\modules\\SumModule.dll");
        var files = GetAllFileNames();
        List<IModule> modules = new();
        foreach (var file in files)
        {
            var assembllyInfo = Assembly.LoadFile(file);
            var types = assembllyInfo.GetTypes();
            foreach (var type in types)
            {
                if (type.GetInterface("IModule") != null)
                {
                    var module = (IModule)Activator.CreateInstance(type);
                    modules.Add(module);
                    Console.WriteLine(module.ModuleName);
                }
            }
        }


        return modules;

    }


    private List<string> GetAllFileNames()
    {
        var path = env.WebRootPath + "\\modules";
        return Directory.GetFiles(path,"*.dll").ToList();
    }


}
