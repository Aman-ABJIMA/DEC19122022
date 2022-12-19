using Microsoft.EntityFrameworkCore;
using Storage_App.NewFolder;
namespace Storage_App.repositories
{
    public class SqlRepository<T> : IRepository<T> where T : EntityBase, IEntity
    {

        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;


        public SqlRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public void Add(T item)
        {
            _dbSet.Add(item);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
        public void Remove(T item)
        {
            _dbSet.Remove(item);
        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet.OrderBy(item=>item.Id).ToList();
        }

    }

}
