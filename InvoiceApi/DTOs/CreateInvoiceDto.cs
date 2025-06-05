namespace InvoiceApi.DTOs
{
    public class CreateInvoiceDto
    {
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
    }
}
