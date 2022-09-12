using System.Xml.Linq;

namespace Biblio_Clients
{
    public class Client
    {
        // Constructor
        public Client() { }
        public Client(int id, string name, string city)
        {
            Id = id;
            _name = name;
            City = city;

        }
        // Propriètés
        public int Id { get; set; } = 0;

        private string _name = "Undefined";
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException();
                _name = value;
            }
        }
        public string City { get; set; }
    }
}