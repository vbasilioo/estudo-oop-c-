//polimorfismo

//variaveis od mesmo tipo mais generico possam apontar para objetos
// de tipos especificos diferentes

/*

ex:

Account acc1 = new Account(1001, "alex", 500.0);
Account acc2 = new SavingsAccount(1002, "Ana", 500.0, 0.01);

acc1.Withdraw(10.0);
acc2.Withdraw(10.0);

*/