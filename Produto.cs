using System;
using System.Globalization;

class Produto{

    public string nome;
    public double preco;
    public int quantidade;

    public double valorTotal(){
        return preco*quantidade;
    }

    public void adicionarProdutos(int quantidade){
        this.quantidade += quantidade;
    }

    public void removerProdutos(int quantidade){
        this.quantidade -= quantidade;
    }

    public override string ToString(){
        return nome 
        + ", R$" 
        + preco.ToString("F2", CultureInfo.InvariantCulture) 
        + ", " 
        + quantidade
        + " unidades, Total: R$"
        + valorTotal().ToString("F2", CultureInfo.InvariantCulture);
    }
}

// "F2" sao casas decimais