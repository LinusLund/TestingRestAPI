using Microsoft.EntityFrameworkCore;
using TestingRestAPI.Contexts;
using TestingRestAPI.Interfaces;

namespace TestingRestAPI.Helpers.Services
{
    public class ReceiptService : IReceiptService
    {
        private readonly PrintContext context;

        public ReceiptService(PrintContext _context)
        {
            context = _context;
        }


        public async Task<Receipt?> CreateReceiptAsync(Receipt receipt)
        {
            context.Receipts.Add(receipt);
            await context.SaveChangesAsync();
            return receipt;
        }



        public async Task<List<Receipt>> GetAllReceiptsAsync()
        {
            var receipts = await context.Receipts.ToListAsync();
            return receipts;
        }

        public async Task<Receipt?> GetSingleReceiptAsync(int id)
        {
            var singleReceipt = await context.Receipts.FindAsync(id);
            if (singleReceipt == null)
                return null;

            return singleReceipt;
        }

        
    }
}

