/*using System;
using System.Globalization;

class Program{
    static void Main(string[] args){
        Encapsulamento e = new Encapsulamento("TV", 500.00, 10);

        /* INICIO DO GET E SET RUIM

        //chamando o metodo get da classe
        Console.WriteLine(e.getNome());

        //chamando o set da classe pra mudar o nome da TV pra TV gatona
        e.setNome("TV gatona");

        //verificando se foi alterado
        Console.WriteLine(e.getNome());
        Console.WriteLine(e.getPreco());
        Console.WriteLine(e.getQuantidade());
        */

        /* inicio do get e set BOM

        e.Nome = "TV Gatona"; //value é o "TV gatona"
        Console.WriteLine(e.Nome);*/

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // NULLABlE = para declarar nulo para coisas que nao sao obrigatorias (metodos/parametros)
        //Nullable<double> x = null; // jeito mais dificil

        //double? x = null; // jeito facil, falando que variavel X é opcional
        //double? y = 10.0;

        //metodos do NULLABLE
        //Console.WriteLine(x.GetValueOrDefault()); //pega o valor da VARIAVEL X, se valor NAO EXISTIR, pega valor padrao (0)
        //Console.WriteLine(y.GetValueOrDefault()); //exibe valor 10 da variavel Y, ja que ele existe

        //Console.WriteLine(x.HasValue); //diz se dentro da variavel X, existe ou nao um valor || em X nao existe
        //Console.WriteLine(y.HasValue); // em Y existe

        //Console.WriteLine(x.Value); // pega o valor de X || vai quebrar o codigo, pq X nao tem valor
        //Console.WriteLine(y.Value);

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*vetores com classes

        int n = int.Parse(Console.ReadLine());
        Encapsulamento[] vetor = new Encapsulamento[n];

        for(int i=0;i<n;i++){
            //lendo dados
            string name = Console.ReadLine();
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vetor[i] = new Encapsulamento{ _nome = name, Preco = price }; // atribuindo essas variaveis ao meu metodo construtor
        }

        double sum = 0.0;
        for(int i=0;i<n;i++){
            sum+= vetor[i].Preco; //acessando o proce dentro do vetor da classe
        }

        double media = sum/n;
        Console.WriteLine("Preco medio = " + media.ToString("F2", CultureInfo.InvariantCulture));*/

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // REF E OUT

        //int a = 10;
        //Calculator.Triplicar(ref a); // TEM QUE USAR 'REF', porque se nao vai triplicar e o numero
        // vai ficar guardado em X lá do outro arquivo, com 'REF' ele mexe na variavel original
        //Console.WriteLine(a);

        //variavel passada por 'REF' deve ter sido iniciada [x=10], pelo 'OUT' nao
        // devem ser evitados

        /*int a = 10;
        int triple;
        Calculator.Triplicar(a, out triple); // a funcao executa e manda o resultado da TRIPLE
        // pq 'OUT' ta referenciando ela como variavel de saida
        Console.WriteLine(triple);*/

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // FOREACH

        /*string[] vetor = new string[] { "Maria", "Roberto", "Andre" };

        foreach(string obj in vetor){
            Console.WriteLine(obj);
        }


    }
}*/