using Entities;
using System.Threading.Tasks;

namespace Data
{
    public interface IInvoiceRepository
    {
        void AddInvoice(Invoice invoice);
        Invoice GetInvoice();

    }
}
