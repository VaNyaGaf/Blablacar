﻿using AutoMapper;
using Blablacar.Domain.Core;

namespace Blablacar.Infrastructure.Data
{
    public class BusinessProfile : Profile
    {
        public BusinessProfile()
        {
            CreateMap<CustomerDto, Customer>().ReverseMap();

            CreateMap<DriverDto, Driver>().ReverseMap();

            CreateMap<Trip, TripDto>().ReverseMap();
        }
    }
}
