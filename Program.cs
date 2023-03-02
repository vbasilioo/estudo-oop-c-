class Program{
    static void Main(string[] args){
        Encapsulamento e = new Encapsulamento("TV", 500.00, 10);

        //chamando o metodo get da classe
        Console.WriteLine(e.getNome());

        //chamando o set da classe pra mudar o nome da TV pra TV gatona
        e.setNome("TV gatona");

        //verificando se foi alterado
        Console.WriteLine(e.getNome());
        Console.WriteLine(e.getPreco());
        Console.WriteLine(e.getQuantidade());
    }
}