using AutoMapper;
using ProjetoCRM.API.Dtos.Cliente;
using ProjetoCRM.API.Models;

namespace ProjetoCRM.API
{
    //classe para criar o perfil do automapper
    public class AutoMapperProfile : Profile
    {
        //construtor
        public AutoMapperProfile()
        {
            CreateMap<Clientes, GetClientesDto>(); //Mapeia os getclientesdto baseado nos clientes
            CreateMap<AddClientesDto, Clientes>(); //Mapeia os clientes baseado no addclientesdto
        }
    }
}
