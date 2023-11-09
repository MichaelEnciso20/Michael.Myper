using Michael.Myper.Domain.Entity;

namespace Michael.Myper.infrastructure.Interface
{
    public interface ITrabajadoreRepository
    {
        IEnumerable<Trabajadore> GetAll();
        Trabajadore Get(string Id);
        bool Insert(Trabajadore trabajadore);
        bool Update(Trabajadore trabajadore);
        bool Delete(string Id);
        
    }
}
