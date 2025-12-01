namespace CSharpConsole.Lab
{
    public abstract class IPhone
    {
        public abstract void DisplayFeature();
    }

    public class IPhone15 : IPhone
    {
        public string Model;
        public string OS;
        public int Camera;

        public IPhone15(string _Model, string _OS, int _Camera)
        {
            this.Model = _Model;
            this.OS = _OS;
            this.Camera = _Camera;
        }

        public override void DisplayFeature()
        {
            Console.WriteLine($"Model = {this.Model} \nOS = {this.OS} \nCamera = {this.Camera} MegaPixel");
        }
    }
    internal class ApplePhone
    {
        static void Main(string[] args)
        {
            IPhone15 i15 = new IPhone15("iPhone15", "iOS", 14);
            i15.DisplayFeature();
        }
    }
}
