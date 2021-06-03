using Domain;

namespace Repository.Interface
{
    public interface ITransactionRepository
    {
        void CreateTransaction(BankTransaction trans);
    }
}