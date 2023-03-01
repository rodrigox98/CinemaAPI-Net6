using AutoMapper;
using CinemaAPI.Context;
using CinemaAPI.Models;
using CinemaAPI.Models.DTO.Endereco;

namespace CinemaAPI.Service
{
    public class EnderecoService 
    {
        private IMapper _mapper;
        private CinemaContext _context;

       public EnderecoService(IMapper mapper, CinemaContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public ReadEnderecoDTO CriarEndereco(CreateEnderecoDTO enderecoDTO)
        {
            Endereco endereco = _mapper.Map<Endereco>(enderecoDTO);
            _context.Add(endereco);
            _context.SaveChanges();
            return _mapper.Map<ReadEnderecoDTO>(endereco);
        }

        public List<ReadEnderecoDTO> ReceberEnderecos()
        {
            List<Endereco> enderecos = _context.Enderecos.ToList();
            List<ReadEnderecoDTO> enderecosDTO = _mapper.Map<List<ReadEnderecoDTO>>(enderecos);

            return enderecosDTO;
        }
    }
}
