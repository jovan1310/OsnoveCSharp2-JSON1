using Newtonsoft.Json;

namespace OsnoveCSharp2_JSON1
{

    public class Proizvod
    {
        public string ImeProizvoda { get; set;  }
        public decimal CenaProizvoda { get; set; }
        public List<string> OznakeProizvoda { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            // U promenljivoj jsonPodaciZaUpis je potrebno mapirati polja klase sa vrednostima.
            string jsonPodaciZaUpis = "{\"ImeProizvoda\": \"Laptop\", \"CenaProizvoda\": 859.57, \"OznakeProizvoda\": [\"Elektronika\",\"Racunari\"]}";
            // U promenljivoj proizvod1 , koja predstavlja nas proizvod - odnosno objekt, unosimo(upisujemo) mapirane vrednosti promenljive jsonPodaciZaUpis.
            Proizvod proizvod1 = JsonConvert.DeserializeObject<Proizvod>(jsonPodaciZaUpis);
            // Ispisujemo vrednosti naseg proizvoda, odnosno, objekta
            Console.WriteLine($"Proizvod: {proizvod1.ImeProizvoda}, Cena: {proizvod1.CenaProizvoda}, Oznaka: {string.Join(", ", proizvod1.OznakeProizvoda)}");
        }
    }
}
