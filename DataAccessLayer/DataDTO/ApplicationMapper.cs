﻿using AutoMapper;
using DataAccessLayer.Entities;

namespace DataAccessLayer.DataDTO
{
    public class ApplicationMapper:Profile
    {
        public ApplicationMapper()
        {
            CreateMap<CustomerDTO, Customer>()
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Phone));

            CreateMap<Customer, CustomerDTO>()
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.PhoneNumber));
        }
    }
}
