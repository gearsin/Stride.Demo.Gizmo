using Stride.Core.Reflection;

namespace Dynamo
{
    public class Installer
    {
        [Stride.Core.ModuleInitializer]
        public static void Init()
        {
            var categories = new string[] { "assets" };
            AssemblyRegistry.Register(typeof(Installer).Assembly, categories);
        }
    }
}
