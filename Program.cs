
using PrototypeDesignPattern;

Console.WriteLine("Prototype Desing Pattern");

IEmployee employee = new Employee();
employee.Display();

IEmployee clonedEmployee = employee.Clone();
clonedEmployee.Display();
