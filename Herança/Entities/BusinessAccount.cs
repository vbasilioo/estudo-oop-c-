namespace OOP.Entities{
    class BusinessAccount : Accounts{
        public double loanLimit { get; set; }

        // : base = aproveitando consturtor da clase pra nao ter q atribuir todos os parametros no construtor dessa classe dnv
        // atribui apenas o novo atributo, q é o loanLimit
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance){
            this.loanLimit = loanLimit;
        }

        public void loan(double amount){
            if(amount <= loanLimit){ // verificando se empréstimo é menor q limite
                this.balance += amount;
            }
        }
    }
}