using Michael.Myper.Domain.Entity;

namespace Michael.Myper.Domain.Interface
{
    public interface ITrabajadoreDomain
    {
        IEnumerable<Trabajadore> GetAll();
        Trabajadore Get(string Id);
        bool Insert(Trabajadore trabajadore);
        bool Update(Trabajadore trabajadore);
        bool Delete(string Id);
    }
}
