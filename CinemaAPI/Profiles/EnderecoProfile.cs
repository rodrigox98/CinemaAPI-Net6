using AutoMapper;
using CinemaAPI.Models;
using CinemaAPI.Models.DTO;
using CinemaAPI.Models.DTO.Endereco;

namespace CinemaAPI.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDTO, Endereco>();
            CreateMap<Endereco, ReadEnderecoDTO>();
        }
    }
}
