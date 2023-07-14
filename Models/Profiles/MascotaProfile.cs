using AutoMapper;
using BE_Veterinaria.Models.DTO;

namespace BE_Veterinaria.Models.Profiles
{
    public class MascotaProfile : Profile
    {
        public MascotaProfile()
        {
            CreateMap<Mascota, MascotaDTO>();
            CreateMap<MascotaDTO, Mascota>();

        }
    }
}
