namespace DependencyInversion
{
    public interface IAccountRepository
    {
        void SaveAccount(Account account);
        Account GetAccount(int accountId); 
    }
}