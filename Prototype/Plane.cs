namespace Prototype
{
    public class Plane : IPlane
    {
        public int Capacity { get; set; }

        public string Name { get; set; }

        public Plane(string field, int capacity)
        {
            Name = field;
            Capacity = capacity;
        }

        public Plane Clone()
        {
            return new Plane(this.Name, this.Capacity);
        }
    }
}
