using System;

namespace Liberty.Core.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public Color Color { get; set; }
        public Engine Engine { get; set; }
        public Lighting Lighting { get; set; }
        public Seat Seat { get; set; }
        public Wheels Wheels { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Status { get; set; }

    }
}
