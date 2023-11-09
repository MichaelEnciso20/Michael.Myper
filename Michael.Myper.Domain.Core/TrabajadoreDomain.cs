using Michael.Myper.Domain.Entity;
using Michael.Myper.Domain.Interface;
using Michael.Myper.infrastructure.Interface;

namespace Michael.Myper.Domain.Core
{
    public class TrabajadoreDomain : ITrabajadoreDomain
    {
        private readonly ITrabajadoreRepository _trabajadoreRepository;
        public TrabajadoreDomain(ITrabajadoreRepository trabajadoreRepository)
        {
            _trabajadoreRepository = trabajadoreRepository;
        }

        public IEnumerable<Trabajadore> GetAll()
        {
            return _trabajadoreRepository.GetAll();
        }
        public Trabajadore Get(String Id)
        {
            return _trabajadoreRepository.Get(Id);
        }
        public bool Insert(Trabajadore trabajadore)
        {
            return _trabajadoreRepository.Insert(trabajadore);
        }
        public bool Update(Trabajadore trabajadore)
        {
            return _trabajadoreRepository.Update(trabajadore);
        }
        public bool Delete(String Id)
        {
            return _trabajadoreRepository.Delete(Id);
        }

       
    }
}
