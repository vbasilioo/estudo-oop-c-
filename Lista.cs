using System;
using System.Collections.Generic;

class Lista{

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //estudando lista

    //classe = list
    //namespace = System.Collections.Generic

    //vantagens = tamanho da lista é variavel / facilidade em realizar inserções e deleções
    //desvantagens = acesso sequencial aos elementos [se precisar do elemento 5000, vai ter q percorrer do 0 ao 5000]

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    // COMANDOS 

    // INSERIR ELEMENTO NA LISTA = Add, Insert
    // TAMANHO DA LISTA = Count
    // ENCONTRAR 1º E ÚLTIMO ELEMENTO DA LISTA QUE SATISFAÇA UM PREDICADO: list.Find, list.FindLast
    // FILTRAR A LISTA COM BASE EM UM PREDICADO: list.FindAll
    // REMOVER ELEMENTOS DA LISTA: Remove, RemoveAll, RemoveAt, RemoveRange

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    static void Main(string[] args){
        //List <nome da lista> nome;
        //List<string> list;

        List<string> list = new List<string>(); //iniciando uma lista vazia
        list.Add("Maria"); //Add adiciona no final da lista
        list.Add("Joao");
        list.Add("Bob");
        list.Add("Ana");
        list.Add("Jorge");
        list.Add("Amanda");
        list.Add("Mah");

        list.Insert(2, "Joana"); //Insert adiciona na posicao, [posicao, nome/numero/etc]
        
        foreach(string obj in list){
            Console.WriteLine(obj);
        }

        Console.WriteLine(list.Count); //mostra o tamanho da lista

        ///////// pesquisando
        
        string s1 = list.Find(x => x[0] == 'A'); //procurando primeira pessoa com 'A' na lista, expressao dentro do colchetes é expressao lambda
        Console.WriteLine("Primeira pessoa encontrada com a letra 'A': " + s1);

        string s2 = list.FindLast(x => x[0] == 'A');
        Console.WriteLine("Última pessoa com encontrada com a letra 'A': " + s2);

        ////////// posicoes

        int pos1 = list.FindIndex(x => x[0] == 'A');
        Console.WriteLine("Posicao da primeira pessoa que comeca com a letra'A': " + pos1);

        int pos2 = list.FindLastIndex(x => x[0] == 'A');
        Console.WriteLine("Posicao da última pessoa que comeca com a letra 'A': " + pos2);

        //////// filtrando

        List<string> resultado = list.FindAll(x => x.Length == 3);
        Console.WriteLine();
        
        foreach(string obj in resultado){
            Console.WriteLine(obj);
        }

        /////// removendo

        list.Remove("Jorge");
        Console.WriteLine();
        foreach(string obj in list){
            Console.WriteLine(obj);
        }

        //remove todo q comeca com a letra 'A'
        list.RemoveAll(x => x[0] == 'A');
        Console.WriteLine();
        foreach(string obj in list){
            Console.WriteLine(obj);
        }

        //removendo pela posicao
        list.RemoveAt(2);
        Console.WriteLine();
        foreach(string obj in list){
            Console.WriteLine(obj);
        }

        //removendo elementos de uma faixa
        list.RemoveRange(2, 2); // a partir da posicao 2, quero remover 2 elementos [posicao, elemento]
        Console.WriteLine();
        foreach(string obj in list){
            Console.WriteLine(obj);
        }
    }

}