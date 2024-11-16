namespace Prototype
{
    public class PlaneCreator
    {
        public void Create()
        {
            var qatar = new Plane("Airbus A320", 450);

            var emirates = qatar.Clone();

            Console.WriteLine(emirates.Name); 
        }
    }
}
