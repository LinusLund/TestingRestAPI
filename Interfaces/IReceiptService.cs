namespace TestingRestAPI.Interfaces
{
    public interface IReceiptService
    {
        Task<List<Receipt>> GetAllReceiptsAsync();

        Task<Receipt?> GetSingleReceiptAsync(int id);

        Task<Receipt>? CreateReceiptAsync(Receipt receipts);

       
    }
}
