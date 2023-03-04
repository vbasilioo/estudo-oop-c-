/*class String{

    // FUNCOES PARA MANIPULACAO DE STRING

    static void Main(string[] args){
        string original = "   abcde FGHIJ ABC abc DEFG   ";

        string s1 = original.ToUpper(); // converte todas para maiúscula
        string s2 = original.ToLower(); //convere todas para minuscula
        string s3 = original.Trim(); //apaga todos os espaços da string
        int n1 = original.IndexOf("BC"); //procurando pro BC dentro da string
        int n2 = original.LastIndexOf("bc"); //ultima vez que aparece 'bc'
        string s4 = original.Substring(10); //cortando a string a partir do indice 10
        string s5 = original.Substring(10, 4); //corta a string e escolhe quantos caracteres [aonde comecar cortar, qnts pegar]
        string s6 = original.Replace('a', 'x'); // troca todo o caracter 'a' pelo 'x'
        string s7 = original.Replace("abc", "xy"); //troca todos os 'abc' por 'xy' [nao precisa ser do msm tamanho a troca]
        // bool b1 = String.IsNullOrEmpty(original); // testa se a variavel ta vazia
        // bool b2 = String.IsNullOrWhiteSpace(original); //testa se a variavel é nula ou é um monte de espaço em branco

        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(s4);
        Console.WriteLine(s5);
        Console.WriteLine(s6);
        Console.WriteLine(s7);
    }
}*/