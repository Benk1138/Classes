using System;
namespace Classes
{
    public class Car
    {
        public Car()
        {
        }


        public Car(int Year, int Make, string, Model, string EngineNoise, string HonkNoise, string IsDriavable)
        {

            Year = Year;
            Make = Make;
            Model = Model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriavable = isDriavable;
        }





        Public int Year { get , set; }

            Public int Make {  get , set;  }
            Public string Model {  get , set; }
            Public string EngineNoise {  get , set; }
            Public string HonkNoise {  get , set; }
            Public bool IsDriavable {  get , sat; }

            public void MakeEngineNoise (string engineNoise)
        {
            Console.WriteLine($"This car goes {EngineNoise}");

            public void MakeHornNoise (string hornNoise)
            {
                Console.WriteLine($"The horn goes {hornNoise}");
            }
        }




    }
}

