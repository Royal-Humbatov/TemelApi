namespace TemelApi.Repositories
{
    public interface GenericRepositories<T> where T : class
    {
        void Insert (T entity); 
        void Update (T entity); 
        void Delete (T entity); 
        List<T> GetAllList ();
        T GetById (int id);
    }
}
