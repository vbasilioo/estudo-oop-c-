/*using OOP.Order;
using OOP.Entities.Enums;

class Enumeracoes{ //olhar dentro de Entities e dentro da Entities>Enums
    static void Main(string[] args){
        Order order = new Order(){
            id = 1080, // id da entrega
            moment = DateTime.Now, // pegando hora do computador
            status = OrderStatus.PendingPayment //usando o ENUM pra falar o status do pedido
        };

        Console.WriteLine(order);

        string txt = OrderStatus.PendingPayment.ToString(); //convertendo numero inteiro pra string
        Console.WriteLine(txt);
        OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // convertendo string em inteiro (usar o msm nome que ta no enums 'delivered', 'pendingpayment')
        Console.WriteLine(os);
    }
}*/