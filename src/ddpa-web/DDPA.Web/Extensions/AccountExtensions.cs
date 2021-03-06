﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DDPA.Web.Controllers;
using DDPA.Web.Models;
using DDPA.DTO;
using DDPA.SQL.Entities;

namespace DDPA.Web.Extensions
{
    public static class AccountExtensions
    {
        public static IMapper GetMapper(this AccountController account)
        {
            return (new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ExtendedIdentityUser, UserViewModel>();
                cfg.CreateMap<ExtendedIdentityUser, UpdateUserViewModel>();
                cfg.CreateMap<AddUserDTO, AddUserViewModel>();
                cfg.CreateMap<AddUserViewModel, AddUserDTO>();

            })).CreateMapper();
        }
    }
}
