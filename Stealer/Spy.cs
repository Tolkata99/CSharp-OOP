using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string investigatedClass, params string[] namesFieldInvestignate)
        {
            Type typeClass = Type.GetType(investigatedClass);
            FieldInfo[] classField = typeClass.GetFields(
            BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);

            StringBuilder sb = new StringBuilder();

            Object classInstance = Activator.CreateInstance(typeClass, new object[] { });

            sb.AppendLine($"Class under investigation: {investigatedClass}");

            foreach (FieldInfo field in classField.Where(f => namesFieldInvestignate.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return sb.ToString().Trim();
        }

        public string AnalyzeAcessModifiers(string investigatedClass)
        {
            Type typeClass = Type.GetType(investigatedClass);
            FieldInfo[] classFields = typeClass.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);
            MethodInfo[] classPublicMethods = typeClass.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            MethodInfo[] classNonPublicMethods = typeClass.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();

            foreach (var field in classFields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }
            foreach (var method in classNonPublicMethods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} have to be public!");
            }
            foreach (var method in classPublicMethods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} have to be private!");
            }

            return sb.ToString().Trim();
        }

        public string RevealPrivateMethods(string investignatedClass)
        {
            Type classType = Type.GetType(investignatedClass);
            MethodInfo[] methodInfo = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"All Private Methods of Class: {investignatedClass}");
            sb.AppendLine($"Base Class: {classType.BaseType.Name}");

            foreach (var method in methodInfo)
            {
                sb.AppendLine(method.Name);
            }



            return sb.ToString().Trim();
        }

        public string CollectGettersAndSetters(string investignatedClass)
        {
            Type classType = Type.GetType(investignatedClass);
            MethodInfo[] classMethod = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();

            foreach (var method in classMethod.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} will return {method.ReturnType}");
            }
            foreach (var method in classMethod.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }

            return sb.ToString().Trim();
        }

    }
}
