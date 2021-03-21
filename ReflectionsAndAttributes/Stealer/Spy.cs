using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
        {
            Type classType = Type.GetType(investigatedClass);
            FieldInfo[] classField = classType.GetFields(BindingFlags.Instance
                                                       | BindingFlags.Public
                                                       | BindingFlags.NonPublic
                                                       | BindingFlags.Static);
            StringBuilder sb = new StringBuilder();

            object clasInstance = Activator.CreateInstance(classType, new object[] { });

            sb.AppendLine($"Class under investigation: {investigatedClass}");

            foreach (FieldInfo field in classField.Where(f => requestedFields.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(clasInstance)}");
            }

            return sb.ToString().TrimEnd();

        }

        public string AnalyzeAccessModifiers(string investigatedClass)
        {
            Type classType = investigatedClass.GetType();


            FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance
                                                    | BindingFlags.Static
                                                    | BindingFlags.Public);
            MethodInfo[] classPublicMethod = classType.GetMethods(BindingFlags.Instance
                                                                | BindingFlags.Public);
            MethodInfo[] classNonMethodPublic = classType.GetMethods(BindingFlags.Instance
                                                                   | BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();

            foreach (FieldInfo field in classFields)
            {
                sb.AppendLine($"{field.Name} must be private!");

            }

            foreach (MethodInfo method in classPublicMethod.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} have to be public!");

            }

            foreach (MethodInfo method in classNonMethodPublic.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} have to be private");

            }

            return sb.ToString().TrimEnd();



        }
    }
}
