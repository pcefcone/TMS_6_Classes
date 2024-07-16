using System.Threading.Channels;

internal class Program
{
    class Phone
    {
        string number;
        string model;
        float weight;

        public Phone()
        {
            number = "Unknown number";
            model = "Unknown model";
            weight = 0.0f;
        }
        public Phone(string Number, string model)
        {
            this.number = Number;
            this.model = model;
            weight = 0.0f;
        }

        public Phone(string Number, string model, float weight)
        {
            this.number = Number;
            this.model = model;
            this.weight = weight;
        }

        public void RecieveCall(string name)
        {
            Console.WriteLine($"{name} calls");
        }

        public string GetNumber()
        {
            return this.number;
        }
    }
    private static void Main(string[] args)
    {
        Phone phoneOne = new Phone();
        Phone phoneTwo = new Phone("+48012345678", "Apple", 170.25f);
        Phone phoneThree = new Phone("+48205305405", "Xiaomi");
        
        Console.WriteLine(phoneOne.GetNumber());
        Console.WriteLine(phoneTwo.GetNumber());
        Console.WriteLine(phoneThree.GetNumber());
        phoneTwo.RecieveCall("User112");
        phoneTwo.RecieveCall("User234");
        phoneTwo.RecieveCall("User354");

    }
}