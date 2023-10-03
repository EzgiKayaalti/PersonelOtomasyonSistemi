namespace Entities
{
    public class IletisimBilgisi
    {
        public int PersonelId { get; set; } //bu aynı zamanda bu tablonun birincil anahtarı
        public string Eposta { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public Personel Personel { get; set; }
    }
}