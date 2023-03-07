////////////////////// ESTUDO DE HERANÇA
///////////////////// ORGANIZADO EM PASTAS DA MELHOR FORMA

using OOP.Entities;

namespace OOP{
    class Program{
        static void Main(string[] args){
           /* BusinessAccount ba = new BusinessAccount(8010, "Maria Clara", 100.0, 500.0);
            Console.WriteLine(ba.balance); */

            /*Accounts acc = new Accounts(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING

            Accounts acc1 = bacc; // recebe o BACC pq o ACC é uma classe mãe
            Accounts acc2 = new BusinessAccount(1003, "Bob", 0.0, 1000.0);
            Accounts acc3 = new SavingAccount(1004, "Ana", 0.0, 0.01);

            // DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount)acc2; // tem q fazer casting pq variavel ACC2 ta entrelaçada ao ACCOUNTS
            acc4.loan(100.0);

            if(acc3 is BusinessAccount){ // verificando se acc3 é instancia de bussinesaccount
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; // 'as' é uma outra forma de fazer casting
                acc5.loan(200.0);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingAccount){ // verificando se acc3 é instancia de savingaccount
                SavingAccount acc5 = (SavingAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }*/

            /////////// SOBREPOSIÇÃO, PALAVRAS: VIRTUAL, OVERRIDE E BASE
            Accounts cc1 = new Accounts(1001, "Alex", 500.0);
            Accounts cc2 = new SavingAccount(1002, "Maria", 1000.0, 0.01);

            cc1.Withdraw(10.0); // aq saca 10 reais e aplica o juros de 5
            cc2.Withdraw(10.0); // aq so saca 10 reais

            Console.WriteLine(cc1.balance);
            Console.WriteLine(cc2.balance);
        }
    }
}

//SOBREPOSIÇAÕ = implementacao de um metodo da superclasse numa subclasse
// para metodos comum (nao abstrato), palavra = virtual
// sobrescrever um metodo, palavra = override

//suponhamos que conta comum é cobrada taxa e na poupança nao, oq fazer?
// sobrescrever o metodo withdraw na subclasse SavingsAccounts
// na classe Accounts (conta comum) fica virtual
// na classe SavingsAccounts (poupança) fica override

// chamar a implementacao da superclasse usando a palavra - base
//suponhamos que a regra para sacar da poupança seja realizar o saque normalmente da superclasse (Account)
// e depois descontar mais 2 reais, utilizamso a base com isso (exemplo no SavingsAccount)