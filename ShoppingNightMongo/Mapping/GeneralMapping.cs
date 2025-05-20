﻿using AutoMapper;
using ShoppingNightMongo.Dtos.CategoryDtos;
using ShoppingNightMongo.Dtos.CustomerDtos;
using ShoppingNightMongo.Dtos.ProductDtos;
using ShoppingNightMongo.Entities;

namespace ShoppingNightMongo.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category, CreateCategoryDto>().ReverseMap(); // Dto nesnesini Category e çeviriyor.
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryByIdDto>().ReverseMap();

            CreateMap<Customer, CreateCustomerDto>().ReverseMap();
            CreateMap<Customer, ResultCustomerDto>().ReverseMap();
            CreateMap<Customer, UpdateCustomerDto>().ReverseMap();
            CreateMap<Customer, GetCustomerByIdDto>().ReverseMap();

            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetProductByIdDto>().ReverseMap();
        }
    }
}
