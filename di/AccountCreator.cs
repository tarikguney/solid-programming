namespace DependencyInversion{
    public class AccountCreator
    {
        // Composition
        private AccountRepository _accountRepository = new AccountRepository();

        public void SaveAccount(AccountModel accountModel){
            _accountRepository.SaveAccount(new Account(accountModel));
        }
    }
}