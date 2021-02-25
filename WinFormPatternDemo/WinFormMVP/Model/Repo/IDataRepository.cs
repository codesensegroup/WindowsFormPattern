namespace WinFormMVP.Model.Repo
{
    public interface IDataRepository<T>
    {
        bool Create(T obj);

        string Read(T obj);
        
        bool Upadate(T obj);

        bool Delete(T obj);
    }
}
