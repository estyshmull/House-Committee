using AutoMapper;
using newHouseCommittee.Entities;
using Solid.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Biulding, BiuldingDTOs>().ReverseMap();
            CreateMap<Payment, PaymentDTOs>().ReverseMap();
            CreateMap<Tenant, TenantDTOs>().ReverseMap();
        }
    }
}
