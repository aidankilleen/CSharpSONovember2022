namespace ObjectInvestigation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Object Investigation");

            Message m = new Message(
                "Test Message",
                "This is a test message");

            m.Display();

            Message m2 = new Message(
                "M2",
                "this is m2");
            m2.Display();

            Message[] messages = new Message[5];
            messages[0] = new Message("M3", "this is m3");

            int[] list = { 1, 2, 3, 4 };

            Message[] messageList =
            {
                new Message ("M1", "this is m1", 99),
                new Message ("M2", "this is m2", 99),
                new Message ("M3", "this is m3", 99),
                new Message ("M4", "this is m4", 99)
            };

            foreach (Message msg in messageList)
            {
                msg.Display();
            }

            Message blank = new Message();

            blank.Display();

            blank.NumberOfDays = -999;

            Console.WriteLine(blank.NumberOfDays);



            //blank.setNumberOfDays(-9999);

            //Console.WriteLine(blank.getNumberOfDays());
        }
    }
}