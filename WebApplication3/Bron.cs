using Microsoft.EntityFrameworkCore;

namespace WebApplication3
{
    public class Brons
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Number { get; set; }
        public DateOnly date { get; set; }
        public DateTime DateTime { get; set; }
    }
}
