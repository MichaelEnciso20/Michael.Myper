using Michael.Myper.Domain.Entity;
using Michael.Myper.infrastructure.Date;
using Michael.Myper.infrastructure.Interface;
using Microsoft.EntityFrameworkCore;

namespace Michael.Myper.infrastructure.Repository
{
    public class TrabajadoreRepository : ITrabajadoreRepository
    {
        private readonly TrabajadoresPruebaContext _context;

        public TrabajadoreRepository(TrabajadoresPruebaContext context)
        {
            _context = context;
        }

        public IEnumerable<Trabajadore> GetAll()
        {
            var workersList = _context.Trabajadores.FromSqlRaw("EXECUTE ListaTrabajadores").ToList();
            return workersList;
        }

        public Trabajadore Get(string Id)
        {
            return _context.Trabajadores.Find(int.Parse(Id));
        }

        public bool Insert(Trabajadore trabajadore)
        {
            _context.Trabajadores.Add(trabajadore);
            var result =  _context.SaveChanges();
            return result > 0;
        }

        public bool Update(Trabajadore trabajadore)
        {
            _context.Entry(trabajadore).State = EntityState.Modified;
            var result = _context.SaveChanges();
            return result > 0;
        }

        public bool Delete(string Id)
        {
            var trabajadore = _context.Trabajadores.Find(int.Parse(Id));
            if (trabajadore != null)
            {
                _context.Trabajadores.Remove(trabajadore);
                var result = _context.SaveChanges();
                return result > 0;
            }
            return false; 
        }

      
    }
}
