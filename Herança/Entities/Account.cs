namespace OOP.Entities{
    class Accounts{
        public int number { get; private set; }
        public string holder { get; private set; }
        public double balance { get; protected set; } // protected diz q so pode ser acessado pela classe ou subclasse
        // nesse caso, so pode ser acessado pelo Account ou pelo BusinessAccount

        public Accounts(int number, string holder, double balance){
            this.number = number;
            this.holder = holder;
            this.balance = balance;
        }

        public virtual void Withdraw(double amount){
            this.balance -= amount + 5.0; // saca da conta e aplica o desconto de 5.0
        }

        public void Deposit(double amount){
            this.balance += amount;
        }
    }
}