using Storage_App.NewFolder;

namespace Storage_App.repositories
{

    public interface IWriteRepository<in T>
    {
        void Add(T item);
        void Remove(T item);

        void Save();
    }
    public interface IReadRepository<out T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
    public interface IRepository<T>:IReadRepository<T>,IWriteRepository<T> where T : IEntity
    {
      
      
    }
    //public class ISuperRepository : IRepository<Employee>  //Inherit generic interface to non generic interface 
    //{
    //    public void Add(Employee item)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IEnumerable<Employee> GetAll()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Employee GetById(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Remove(Employee item)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Save()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}