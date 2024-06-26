namespace KolokwiumDB.Models
{
    public enum Rodzaj
    {
        Membranowa = 0,
        Nożycowa = 1,
        Mechaniczna = 2,
        Optyczna = 3,
        Hybrydowa = 4
    }
    public class Keyboard
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public Rodzaj Rodzaj { get; set; }
    }
}
