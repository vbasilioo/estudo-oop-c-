using System;
using System.Globalization;

// encapsulamento impede que façam alteraçoes a nao ser utilizando metodos
// encapsulamento = public, private, protected , etc...

// pra trabalhar com metodos/atributos privativos no c#, tem que comecar o nome da variavel com _

// quero mostrar só o nome do atributo produto, mas ele é privativo, e agora?
// usar get e set, codigo logo abaixo do metodo construtor

class Encapsulamento{
    private string _nome;
    private int _quantidade;

    //AUTO PROPRIEDADES (usado direto no atributo) -> podia ser aplicado pra _quantidade tbm
    // nao precisa do _ quando for usar auto propriedade
    //serve para declarar propriedades que nao necessitam de uma logica particular na operacao de get e set
    // get = retorna o nome |||| private set = ngm pode alterar o preco
    public double Preco{ get; private set; }

    public Encapsulamento(string nome, double preco, int quantidade){
        this._nome = nome;
        this.Preco = preco;
        this._quantidade = quantidade;
    }

    //acessando o atributo privativo _nome e retornando [get = retorna]
    // retorna só o nome

    /*public string getNome(){
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
    }*/

    // ---------------------------- MELHOR FORMA DE FAZER 'GET' E 'SET'
    // value = como se fosse o parametro recebido entre (), mas usa-se a palavra chave 'value'
    // nome dessa 'public string nome' se chama propriedade, como qlq um que tiver get e set dentro
    public string Nome{
        get{ return _nome; }
        set{  
            if(value != null && value.Length > 0){ //se nome for diferente de vazio e tiver caracter maior que 0 [verificando com lenght]
                this._nome = value;
            }
        }
    }

    public int Quantidade{
        get{ return _quantidade; }
    }

    public double valorTotalEstoque(){
        return Preco * _quantidade;
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
        + Preco.ToString("F2", CultureInfo.InvariantCulture) 
        + ", " 
        + _quantidade
        + " unidades, Total: R$"
        + valorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
}

//ordem pra construir a classe

// classe
// atributos privados
// auto propriedades
// construtores
// propriedades customizadas
// metodos

//MODIFICADORES DE ACESSO [pesquisar]