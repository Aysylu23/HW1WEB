﻿using AutoMapper;
using HW1WEB.Contracts.Requests;
using HW1WEB.Contracts.Responses;
using HW1WEB.Models;

namespace HW1WEB.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Product, ProductResponse>(MemberList.Destination).ReverseMap();
            CreateMap<Product, ProductDeleteResponse>(MemberList.Destination).ReverseMap();
            CreateMap<Product, ProductUpdateRequest>(MemberList.Destination).ReverseMap();
            CreateMap<Product, ProductDeleteRequest>(MemberList.Destination).ReverseMap();
            CreateMap<Product, ProductCreateRequest>(MemberList.Destination).ReverseMap();
        }

         
    }
}
