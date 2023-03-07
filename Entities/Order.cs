using OOP.Entities.Enums;

namespace OOP.Order{
    class Order{
        public int id { get; set; }
        public DateTime moment { get; set; }
        public OrderStatus status { get; set; }

        public override string ToString(){
            return id + ", " + moment + ", " + status;
        }
    }
}