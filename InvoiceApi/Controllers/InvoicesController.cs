using Microsoft.AspNetCore.Mvc;
using InvoiceApi.DTOs;
using InvoiceApi.Models;
using InvoiceApi.Services;
using AutoMapper;

namespace InvoiceApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InvoicesController : ControllerBase
{
    private readonly IMapper _mapper;

    public InvoicesController(IMapper mapper)
    {
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult CreateInvoice([FromBody] CreateInvoiceDto invoiceDto)
    {
        if (invoiceDto.Total <= 0)
            return BadRequest("Total debe ser mayor a cero.");

        if (invoiceDto.Date > DateTime.Now)
            return BadRequest("La fecha no puede ser futura.");

        var invoice = _mapper.Map<Invoice>(invoiceDto);
        InvoiceService.AddInvoice(invoice);

        return Ok("Factura guardada correctamente.");
    }

    [HttpGet("{customerId}")]
    public ActionResult<List<InvoiceDto>> GetInvoices(int customerId)
    {
        var invoices = InvoiceService.GetInvoicesByCustomer(customerId);
        var result = _mapper.Map<List<InvoiceDto>>(invoices);
        return Ok(result);
    }
}