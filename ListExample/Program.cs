using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Ajay",
                Gender = "Male",
                Salary = 1000000
             };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Rao",
                Gender = "Male",
                Salary = 1000000
             };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Kunjoor",
                Gender = "Male",
                Salary = 1000000
             };

            //Creating a List of Employees
            List<Employee> listEmployees = new List<Employee>();
            listEmployees.Add(emp1);
            listEmployees.Add(emp2);
            listEmployees.Add(emp3);

            //use Contains method to check if employee exist or not
            if (listEmployees.Contains(emp2))
            {
                Console.WriteLine($"Employee Exists : {emp2.Name}");
            }
            else
            {
                Console.WriteLine("Employee does not exist!");
            }
            Console.WriteLine("---------------------------------");
            // Use Exists method when you want to check if an item exists or not
            // in the list based on a condition
            if (listEmployees.Exists(x => x.Name.StartsWith("A")))
            {
                Console.WriteLine("List contains Employees whose name starts with A");
            }
            else
            {
                Console.WriteLine("List does not contain Employee whose name starts with A");
            }
            Console.WriteLine("-----------------------------------");
            // Use Find() method, if you want to searche an element by a conditions 
            Employee emp = listEmployees.Find(employee => employee.Gender == "Male");
            Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}",
            emp.ID, emp.Name, emp.Gender, emp.Salary);
            Console.WriteLine("");
            // Use FindLast() method when you want to searche an item by a conditions
            // and returns the Last matching item from the list
            Employee lastMatchEmp = listEmployees.FindLast(employee => employee.Gender == "Male");
            Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}",
            lastMatchEmp.ID, lastMatchEmp.Name, lastMatchEmp.Gender, lastMatchEmp.Salary);
            Console.WriteLine("");
            // Use FindAll() method when you want to return all the items that
            // matches the conditions
            List<Employee> filteredEmployees = listEmployees.FindAll(employee => employee.Gender == "Male");
            foreach (Employee femp in filteredEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}",
                femp.ID, femp.Name, femp.Gender, femp.Salary);
            }
            Console.WriteLine("");
            // Use FindIndex() method when you want to return the index of the first item
            // by a condition
            Console.WriteLine("Index of the first matching employee object whose Gender is Male = " +
            listEmployees.FindIndex(employee => employee.Gender == "Male"));
            Console.WriteLine("");
            // Use FindLastIndex() method when you want to return the index of the last item 
            // by a condition
            Console.WriteLine("Index of the Last matching employee object whose Gender is Male = " +
            listEmployees.FindLastIndex(employee => employee.Gender == "Male"));
            Console.ReadKey();




        }
    }
}
