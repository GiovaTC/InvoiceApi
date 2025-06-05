namespace InvoiceApi.DTOs
{
    public class InvoiceDto
    {
        public int InvoiceId { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
    }
}

