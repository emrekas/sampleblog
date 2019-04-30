using System.Reflection;
namespace SampleBlog.Application
{
    public class AssemblyIdentifier
    {
        public static Assembly Get() =>
            typeof(AssemblyIdentifier).GetTypeInfo().Assembly;
    }
}
