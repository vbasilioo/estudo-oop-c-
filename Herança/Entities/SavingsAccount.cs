namespace OOP.Entities{
    class SavingAccount : Accounts{
        public double InterestRate { get; set; }

        public SavingAccount(int number, string holder, double balance, double interestRate)
        : base (number, holder, balance){
            this.InterestRate = interestRate;
        }

        public void UpdateBalance(){
            this.balance += balance * this.InterestRate;
        }

        /*public override void Withdraw(double amount){ // reescreve o método, tirando a taxa de 5.0 dele
            this.balance -= amount;
        }*/

        public override void Withdraw(double amount){ // rescreve o método, efetuando a cobrança da taxa de 5.0 + 2 reais
            base.Withdraw(amount);
            this.balance -= 2.0;
        }
    }
}