using Domain;

namespace Repository.Interface
{
    public interface IConfigRepository
    {
        BankConfig GetConfig();
    }
}