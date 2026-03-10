using System.IO;

namespace CS246Team1Project.Models
{
    public class AddressModel
    {
        public int Id {  get; set; }
        public string Street {  get; set; } = string.Empty;

        public string City { get; set; } = string.Empty ;

        public int Zipcode { get; set; }

        public string Country { get; set; } = string.Empty;

        public string FullAddress
        {
            get
            {
                return $"{Street}, {City}, {Zipcode}, {Country}";
            }
        }

    }
}
