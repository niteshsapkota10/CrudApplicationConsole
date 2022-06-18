// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using CrudApplicationConsole;

List<EmployeeModel> employees = new List<EmployeeModel>(); 

EmployeeController employeeController=new EmployeeController();

for (int i = 0; i < 3; i++)
{
    EmployeeModel employeeModel = employeeController.AddEmployeeDetail();
    employees.Add(employeeModel);
}

employeeController.DisplayEmployeeDetail(employees);

Console.WriteLine("Enter Id to Update :: ");
int updateId=int.Parse(Console.ReadLine());

employees= employeeController.UpdateEmployee(updateId,employees);
employeeController.DisplayEmployeeDetail(employees);


Console.WriteLine("Enter Id to Remove :: ");
int deleteId=int.Parse(Console.ReadLine());
employees = employeeController.deleteEmployee(deleteId, employees);

employeeController.DisplayEmployeeDetail(employees);



