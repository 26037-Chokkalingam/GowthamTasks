using System.Reflection;

namespace ReflectionLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type objType = typeof(SampleClass);
            object? obj = Activator.CreateInstance(objType); 

            SampleClass sampleClass = new SampleClass();
            var propertyDetails = objType.GetProperty("SampleDescription", BindingFlags.Instance | BindingFlags.NonPublic);
            propertyDetails.SetValue(obj, "New Description");
            propertyDetails.SetValue(sampleClass, "New Description");

            var methodDetails = objType.GetMethod("ChangeDescription", BindingFlags.Instance | BindingFlags.NonPublic);
            methodDetails.Invoke(obj, ["Changed Description"]);

            Console.ReadLine();
        }
    }
}
