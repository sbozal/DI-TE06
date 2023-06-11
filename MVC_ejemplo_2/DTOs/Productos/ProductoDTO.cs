using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Productos
{
    public class ProductoDTO
    {
        private int productID;
        private string productName;
        private int categoryID;
        private double unitPrice;
        private int stock;

        public ProductoDTO()
        {

        }

        public ProductoDTO(int productID, string productName, int categoryID, double unitPrice, int stock)
        {
            this.ProductID = productID;
            this.ProductName = productName;
            this.CategoryID = categoryID;
            this.UnitPrice = unitPrice;
            this.Stock = stock;
        }

        public int ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}