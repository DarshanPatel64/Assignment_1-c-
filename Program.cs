using System;
namespace demos
{
    public class Program{

        static void methodCalled(object sender, string functionName){
            Console.WriteLine("{0} method called",functionName);
        }
        static void Main(string[] args){
            int id = 0;
            string name = "";
            string department = "";
            Employee emp;
            
            try{
                Console.WriteLine("Enter ID: ");
                id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Name: ");
                name = Console.ReadLine();
                if(String.IsNullOrEmpty(name)){
                    throw new ArgumentException("Name can't be empty");
                }

                Console.WriteLine("Enter Department Name: ");
                department = Console.ReadLine();
                if(String.IsNullOrEmpty(department)){
                    throw new ArgumentException("Department Name can't be empty");
                }
                emp = new Employee(id,name,department);
                emp.getDetailsCalled += methodCalled;
                Console.WriteLine("ID: {0}",emp.getId());
                Console.WriteLine("Name:{0}",emp.getName());
                Console.WriteLine("Department Name:{0}",emp.getDepartmentName());
                emp.update(22);
                System.Console.WriteLine(emp.getId());


            }catch(Exception e){
                Console.WriteLine(e.ToString());
            }
            
        }
    
    }
}