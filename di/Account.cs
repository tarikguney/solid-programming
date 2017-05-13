namespace DependencyInversion{
    public class Account{
        public Account(){}
        public Account(AccountModel accountModel){
            this.FirstName = accountModel.FirstName;
            this.LastName = accountModel.LastName;
        }

        public string FirstName {get;set;}
        public string LastName {get;set;}
    }
}