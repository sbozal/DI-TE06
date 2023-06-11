using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Clientes
{
    public class ClienteDTO
    {
        private string customerID;
        private string companyName;
        private string city;
        private string country;
        private double importe;

        public ClienteDTO() { }

        public ClienteDTO(string customerID, string companyName, string city, string country, double importe)
        {
            this.CustomerID = customerID;
            this.CompanyName = companyName;
            this.City = city;
            this.Country = country;
            this.Importe = importe;
        }

        public string CustomerID { get => customerID; set => customerID = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }
        public double Importe { get => importe; set => importe = value; }
    }
}
