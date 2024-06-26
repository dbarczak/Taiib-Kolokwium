using KolokwiumDB.Models;

namespace KolokwiumDB.DTOs
{
    public class KeyboardResponse
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public Rodzaj Rodzaj { get; set; }
    }
}
