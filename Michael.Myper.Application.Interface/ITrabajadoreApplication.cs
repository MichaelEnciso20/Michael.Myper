using Michael.Myper.Application.DTO;
using Michael.Myper.Transversal.Common;

namespace Michael.Myper.Application.Interface
{
    public interface ITrabajadoreApplication
    {
        Response<IEnumerable<TrabajadoreDto>> GetAll();
        Response<TrabajadoreDto> Get(string Id);
        Response<bool> Insert(TrabajadoreDto trabajadoreDto);
        Response<bool> Update(TrabajadoreDto trabajadoreDto);
        Response<bool> Delete(string Id);
        
    }
}
