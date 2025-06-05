using InvoiceApi.Models;

namespace InvoiceApi.Services
{
    public static class InvoiceService
    {
        private static readonly List<Invoice> _invoices = new();

        public static void AddInvoice(Invoice invoice)
        {
            _invoices.Add(invoice);
        }

        public static List<Invoice> GetInvoicesByCustomer(int customerId)
        {
            return _invoices
                .Where(i => i.CustomerId == customerId)
                .OrderBy(i => i.Date)
                .ToList();
        }
    }
}
