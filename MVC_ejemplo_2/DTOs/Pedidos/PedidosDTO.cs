using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Pedidos
{
    public class PedidosDTO
    {
        private int orderId;
        private string customerId;
        private int employeeId;
        private DateTime orderDate;
        private DateTime shippedDate;
        private decimal freight;
        private string shipAddress;


        public PedidosDTO() { }

        public PedidosDTO(int orderId, string customerId, int employeeId, DateTime orderDate, DateTime shippedDate, decimal freight, string shipAddress)
        {
            this.orderId = orderId;
            this.customerId = customerId;
            this.employeeId = employeeId;
            this.orderDate = orderDate;
            this.shippedDate = shippedDate;
            this.freight = freight;
            this.shipAddress = shipAddress;
        }

        public int OrderId { get => orderId; set => orderId = value; }
        public string CustomerId { get => customerId; set => customerId = value; }
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public DateTime ShippedDate { get => shippedDate; set => shippedDate = value; }
        public decimal Freight { get => freight; set => freight = value; }
        public string ShipAddress { get => shipAddress; set => shipAddress = value; }
    }
}
