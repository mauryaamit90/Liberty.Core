using System;

namespace Liberty.Core.Model
{
    public class Seat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Color Color { get; set; }
        public DateTime CreateOn { get; set; }
        public int CreatedBy { get; set; }
    }
}
