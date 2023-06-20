namespace AdoNet.Web.Interfaces
{
    public interface ICRUD<T> where T : class
    {
       List<T> GetAll();
        T Get(int id);
        T Add(T entity);
        bool Update(T entity);
        bool Delete(int id);
    }
}
