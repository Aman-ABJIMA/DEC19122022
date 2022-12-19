using Storage_App.Data;
using Storage_App.NewFolder;
using Storage_App.repositories;
using System;
namespace Stroage_App
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new SqlRepository<Employee>(new StorageAppDbContext());
            IWriteRepository<Manager> repo = new SqlRepository<Employee>(new StorageAppDbContext());
            AddManagers(employeeRepository);
            AddEmployees(employeeRepository);
            repo.Add(new Manager());

            GetEmployeeById(employeeRepository);

            WriteAllToConsole(employeeRepository);

            

            var orginationRepository = new ListRepository<Organization>();
            AddOrganization(orginationRepository);
            WriteAllToConsole(employeeRepository);
        }

        private static void AddManagers(IWriteRepository<Manager> managerRepository)
        {
            managerRepository.Add(new Manager { Fullname = "Dileep Kumar" });
            managerRepository.Add(new Manager { Fullname = "Sulochana Choudhary" });
            managerRepository.Save();
        }

        private static void WriteAllToConsole(IReadRepository<IEntity> employeeRepository)
        {
            var items = employeeRepository.GetAll();
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            
        }

        private static void GetEmployeeById(IRepository<Employee> employeeRepository)
        {
            var employee = employeeRepository.GetById(1);
            Console.WriteLine("Employee with ID:1 \n{0}", employee);
        }

        private static void AddEmployees(IRepository<Employee> employeeRepository)
        {
            employeeRepository.Add(new Employee { Fullname = "AMAN SINGH" });
            employeeRepository.Add(new Employee { Fullname = "KULDEEP SINGH" });
            employeeRepository.Add(new Employee { Fullname = "Ishanshi" });
            employeeRepository.Save();
        }

        private static void WriteAllToConsole(SqlRepository<Employee> employeeRepository)
        {
            var items = employeeRepository.GetAll();
            foreach(var item in items)
            {
                Console.WriteLine(item);
            }
        }

       

        private static void AddOrganization(ListRepository<Organization> orginationRepository)
        {
            orginationRepository.Add(new Organization { Name = "ABJIMA" });
            orginationRepository.Add(new Organization { Name = "AITCS" });
            orginationRepository.Save();

        }

      

       
    }

    
}