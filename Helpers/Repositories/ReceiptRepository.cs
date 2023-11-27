using TestingRestAPI.Contexts;

namespace TestingRestAPI.Helpers.Repositories
{
    public class ReceiptRepository : Repo<Receipt>
    {
        
        public ReceiptRepository(PrintContext context) : base(context)
        {
        }

    }
}
