namespace DependencyInversion{
    public class AccountCreator
    {
        private IAccountRepository _accountRepository;
        public AccountCreator(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        
        public void SaveAccount(AccountModel accountModel){
            _accountRepository.SaveAccount(new Account(accountModel));
        }
    }
}