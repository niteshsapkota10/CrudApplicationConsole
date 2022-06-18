using CrudApplicationConsole;

namespace CrudApplicationConsole
{
    class EmployeeController
    {
        public EmployeeModel AddEmployeeDetail()
        {
            Console.WriteLine("Enter Id for Employee :: ");
            int eid=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name for Employee :: ");
            string name=Console.ReadLine(); 
            Console.WriteLine("Enter Address for Employee :: ");
            string address=Console.ReadLine();
            EmployeeModel e1=new EmployeeModel();
            e1.Id=eid;
            e1.Name=name;
            e1.Address=address;
            return e1;
        }

        public void DisplayEmployeeDetail(List<EmployeeModel> employees1)
        {
            foreach(EmployeeModel employee in employees1)
            {
                Console.WriteLine("");
                Console.WriteLine("Id :: {0}, Name :: {1}, Address :: {2} ",employee.Id,employee.Name,employee.Address);
            }
        }

        public List<EmployeeModel> UpdateEmployee(int id,List<EmployeeModel> employeeModels)
        {
            foreach(EmployeeModel e in employeeModels)
            {
                if (e.Id == id)
                {
                    Console.WriteLine("Enter new Name :: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter new Address :: ");
                    string addresss = Console.ReadLine();
                    e.Name = name;
                    e.Address = addresss;
                    return employeeModels;
                }
            }
            return null;
        }

        public List<EmployeeModel> deleteEmployee(int id,List<EmployeeModel> employees)
        {
            foreach(EmployeeModel e in employees)
            {
                if (e.Id == id)
                {
                    employees.Remove(e);
                    Console.WriteLine("Removed Successfully !!! ");
                    return employees;
                }
            }
            return null;
        }

    }
}
