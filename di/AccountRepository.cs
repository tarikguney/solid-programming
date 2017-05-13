namespace DependencyInversion
{
    public class AccountRepository: IAccountRepository
    {
        public void SaveAccount(Account account){}
        public Account GetAccount(int accountId){return null;}
    }
}