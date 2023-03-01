using System;
using System.Globalization;

namespace OOP{
    class Program{
        static void Main(string[] args){
            Produto produto = new Produto();
            Console.WriteLine("Nome: ");
            produto.nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            produto.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade no estoque: ");
            produto.quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);
            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionado no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto.adicionarProdutos(qte);
            Console.WriteLine("Dados atualizados: " + produto);
            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto.removerProdutos(qte);
            Console.WriteLine("Dados atualizados: " + produto);
        }
    }
}

// GetType = retorna o tipo do objeto
// Equals = compara se o objeto e´igual ao outro
// GetHashCode = retorna o codigo hash do objeto

// ToString = converte o objeto para string [usar para retornar todos os dados de um objeto]
//usando ToString com o objeto 'produto', retorna todos os dados que inseri nele

// CultureInfo.InvariatnCulture = formata a saída de numeros, considerando . e ,
// sem ele, se inserirmos um preco: 300.00, fica como 30000,00
// com ele, 300.00 fica 300.00