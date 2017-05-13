namespace DependencyInversion{
    public class AccountVerifier
    {
        // Composition
        private AccountRepository _accountRepository = new AccountRepository();

        public bool VerifyAccount(int accountId){
            return _accountRepository.GetAccount(accountId) == null;
        }
    }
}