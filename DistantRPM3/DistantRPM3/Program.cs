using System;
using System.Reflection; // не забудьте подключить пространство имен

class Program
{
    static void Main()
    {
        Type type = typeof(ConsoleKeyInfo);
        Console.WriteLine($"Методы класса {type.Name}:");
        foreach (MethodInfo method in type.GetMethods())
        {
            Console.WriteLine($"Название: {method.Name}");
            Console.WriteLine($"IsAbstract: {method.IsAbstract}");
            Console.WriteLine($"IsFamily: {method.IsFamily}");
            Console.WriteLine($"IsFamilyAndAssembly: {method.IsFamilyAndAssembly}");
            Console.WriteLine($"IsFamilyOrAssembly: {method.IsFamilyOrAssembly}");
            Console.WriteLine($"IsAssembly: {method.IsAssembly}");
            Console.WriteLine($"IsPrivate: {method.IsPrivate}");
            Console.WriteLine($"IsPublic: {method.IsPublic}");
            Console.WriteLine($"IsConstructor: {method.IsConstructor}");
            Console.WriteLine($"IsStatic: {method.IsStatic}");
            Console.WriteLine($"IsVirtual: {method.IsVirtual}");
            Console.WriteLine($"ReturnType: {method.ReturnType.FullName}");
            Console.WriteLine();
        }

        Console.WriteLine($"Конструкторы класса {type.Name}:");
        foreach (ConstructorInfo constructor in type.GetConstructors())
        {
            Console.WriteLine($"IsFamily: {constructor.IsFamily}");
            Console.WriteLine($"IsFamilyAndAssembly: {constructor.IsFamilyAndAssembly}");
            Console.WriteLine($"IsFamilyOrAssembly: {constructor.IsFamilyOrAssembly}");
            Console.WriteLine($"IsAssembly: {constructor.IsAssembly}");
            Console.WriteLine($"IsPrivate: {constructor.IsPrivate}");
            Console.WriteLine($"IsPublic: {constructor.IsPublic}");
            Console.WriteLine();
        }

        Console.WriteLine($"Поля класса {type.Name}:");
        foreach (FieldInfo field in type.GetFields())
        {
            Console.WriteLine($"Название: {field.Name}");
            Console.WriteLine($"IsFamily: {field.IsFamily}");
            Console.WriteLine($"IsFamilyAndAssembly: {field.IsFamilyAndAssembly}");
            Console.WriteLine($"IsFamilyOrAssembly: {field.IsFamilyOrAssembly}");
            Console.WriteLine($"IsAssembly: {field.IsAssembly}");
            Console.WriteLine($"IsPrivate: {field.IsPrivate}");
            Console.WriteLine($"IsPublic: {field.IsPublic}");
            Console.WriteLine($"IsStatic: {field.IsStatic}");
            Console.WriteLine();
        }

        Console.WriteLine($"Свойства класса {type.Name}:");
        foreach (PropertyInfo property in type.GetProperties())
        {
            Console.WriteLine($"Название: {property.Name}");
            Console.WriteLine($"Attributes: {property.Attributes}");
            Console.WriteLine($"CanRead: {property.CanRead}");
            Console.WriteLine($"CanWrite: {property.CanWrite}");
            Console.WriteLine($"GetMethod: {property.GetMethod}");
            Console.WriteLine($"SetMethod: {property.SetMethod}");
            Console.WriteLine($"PropertyType: {property.PropertyType.FullName}");
            Console.WriteLine();
        }
    }
}