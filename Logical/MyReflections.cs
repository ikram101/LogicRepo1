using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Logical
{
    public class MyReflections
    {

        ////public static Employee GetColl(string str = "EmployeeID=102,EmpName=SYED")
        ////{
        ////    Employee emp = new Employee();

        ////    string[] inputFields = str.Split(",".ToCharArray());


        ////    foreach (string field in inputFields)
        ////    {

        ////        string fieldName = field.Substring(0, field.IndexOf("="));

        ////        string fv = field.Substring(field.IndexOf("=") + 1);

        ////        PropertyInfo propertyInfo = emp.GetType().GetProperty(fieldName);

        ////        var fv1 = Convert.ChangeType(fv, propertyInfo.PropertyType);

        ////        propertyInfo.SetValue(emp, fv, null);

        ////    }

        ////    return emp;
        ////}


        //////Reflection sample   
        ////public void ReflectionSamples()

        ////{
        ////    Employee emp = new Employee();

        ////    Type type = typeof(Employee);

        ////    PropertyInfo[] prop = type.GetProperties();

        ////    MethodInfo[] methods = type.GetMethods();

        ////    //ConstructorInfo[] constructor = type.GetConstructor();\

        ////    //FieldInfo[] fields = type.GetField("Hello"); ;

        ////    // PropertyInfo propertyInfo = emp.GetType().GetProperty();
        ////}
    }
}
