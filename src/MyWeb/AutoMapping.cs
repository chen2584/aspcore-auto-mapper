using AutoMapper;

public class AutoMapperPrifile : Profile
{
    public AutoMapperPrifile()
    {
        CreateMap<User, UserDTO>(); // means you want to map from User to UserDTO
    }
}