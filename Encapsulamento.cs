using System;
using System.Globalization;

// encapsulamento impede que façam alteraçoes a nao ser utilizando metodos
// encapsulamento = public, private, protected , etc...

// pra trabalhar com metodos/atributos privativos no c#, tem que comecar o nome da variavel com _

// quero mostrar só o nome do atributo produto, mas ele é privativo, e agora?
// usar get e set, codigo logo abaixo do metodo construtor

class Encapsulamento{
    private string _nome;
    private double _preco;
    private int _quantidade;

    public Encapsulamento(string nome, double preco, int quantidade){
        this._nome = nome;
        this._preco = preco;
        this._quantidade = quantidade;
    }

    //acessando o atributo privativo _nome e retornando [get = retorna]
    // retorna só o nome

    public string getNome(){
        return _nome;
    }

    public double getPreco(){
        return _preco;
    }

    public int getQuantidade(){
        return _quantidade;
    }

    //acessando o atributo _nome e alterando [set = alterar]
    //podemos criar estruturas dentro dos gets e sets, ifs, switch e etc
    public void setNome(string nome){
        if(nome!=null && nome.Length > 0){ //se nome for diferente de vazio e tiver caracter maior que 0 [verificando com lenght]
            this._nome = nome;
        }
    }

    public double valorTotalEstoque(){
        return _preco * _quantidade;
    }

    public void adicionarProduto(int quantidade){
        this._quantidade += quantidade;
    }

    public void removerProduto(int quantidade){
        this._quantidade -= quantidade;
    }

    public override string ToString(){
        return _nome 
        + ", R$" 
        + _preco.ToString("F2", CultureInfo.InvariantCulture) 
        + ", " 
        + _quantidade
        + " unidades, Total: R$"
        + valorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
}