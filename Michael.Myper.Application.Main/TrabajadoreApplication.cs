using AutoMapper;
using Michael.Myper.Application.DTO;
using Michael.Myper.Application.Interface;
using Michael.Myper.Domain.Entity;
using Michael.Myper.Domain.Interface;
using Michael.Myper.Transversal.Common;

namespace Michael.Myper.Application.Main
{
    public class TrabajadoreApplication : ITrabajadoreApplication
    {
        private readonly ITrabajadoreDomain _trabajadoreDomain;
        private readonly IMapper _mapper;
        public TrabajadoreApplication(ITrabajadoreDomain trabajadoreDomain, IMapper mapper)
        {
            _trabajadoreDomain = trabajadoreDomain;
            _mapper = mapper;
        }

        public Response<IEnumerable<TrabajadoreDto>> GetAll()
        {
            var response = new Response<IEnumerable<TrabajadoreDto>>();
            try
            {
                var workers = _trabajadoreDomain.GetAll();
                response.Data = _mapper.Map<IEnumerable<TrabajadoreDto>>(workers);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public Response<TrabajadoreDto> Get(string Id)
        {
            var response = new Response<TrabajadoreDto>();
            try
            {
                var workers = _trabajadoreDomain.Get(Id);
                response.Data = _mapper.Map<TrabajadoreDto>(workers);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public Response<bool> Insert(TrabajadoreDto trabajadoreDto)
        {
            var response = new Response<bool>();
            try
            {
                var workers = _mapper.Map<Trabajadore>(trabajadoreDto);
                response.Data = _trabajadoreDomain.Insert(workers);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro Exitoso!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public Response<bool> Update(TrabajadoreDto trabajadoreDto)
        {
            var response = new Response<bool>();
            try
            {
                var workers = _mapper.Map<Trabajadore>(trabajadoreDto);
                response.Data = _trabajadoreDomain.Update(workers);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualización Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public Response<bool> Delete(string Id)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = _trabajadoreDomain.Delete(Id);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminación Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
      
    }
}
