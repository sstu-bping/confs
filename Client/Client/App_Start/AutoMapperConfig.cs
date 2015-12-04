using AutoMapper;
using Client.Entities;
using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Client.App_Start
{
    public class AutoMapperConfig
    {
        public static void ConfigMap()
        {
            Mapper.CreateMap<LoginModel, User>(MemberList.Source);
            Mapper.CreateMap<User, LoginModel>(MemberList.Destination);

            Mapper.CreateMap<RegistrationModel, User>(MemberList.Source);
            Mapper.CreateMap<User, RegistrationModel>(MemberList.Destination);

            Mapper.AssertConfigurationIsValid();
        }
    }
}