namespace Excursionistas.Models
{
    public class Variables
    {
       public class Elementos
        {
            public string Name { get; set; }
            public int Peso { get; set; }
            public int Calorias { get; set; }

        }

        public class GetCalculare
        {
            public List<Elementos> elementos;

            public List<Elementos> Elementos
            {
                get { return elementos; }
                set { elementos = value; }
            }
            public string Mensaje { get; set; }
            public int MaxCalorias { get; set; }
            public int MinPeso { get; set; }

        }
        
    }
}
