namespace Exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);


            string[] urls = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);


            ISmartPhone phone = new Smartphone();
            foreach (string phoneNumber in numbers)
            {
                if (numbers.Length == 10)
                {  
                    phone.Call(phoneNumber);
                }
                else
                {
                    StationaryPhone stationaryPhone = new StationaryPhone();
                    stationaryPhone.Call(phoneNumber);
                }
            }
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}