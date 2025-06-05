using AutoMapper;
using InvoiceApi.DTOs;
using InvoiceApi.Models;

namespace InvoiceApi.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateInvoiceDto, Invoice>();
            CreateMap<Invoice, InvoiceDto>();
        }
    }
}
