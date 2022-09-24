using System;

namespace Liberty.Core.Model
{
    public class Wheels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public float Hieght { get; set; }
        public float Width { get; set; }
        public float Tickness { get; set; }
        public DateTime CreateOn { get; set; }
        public int CreatedBy { get; set; }
    }
}
