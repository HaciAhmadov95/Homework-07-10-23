Task1



namespace ConsoleApp1
{
    internal class Car
    {
        public int speed;
        public string colour;
        public string vin;

        public string Vin
        {


            get
            {
                if (speed > 450)
                {
                    return vin;
                }


                return null; ;
            }

            set
            {

                vin = value;

            }


        }

    }
}
