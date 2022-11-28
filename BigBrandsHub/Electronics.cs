namespace BigBrandsHub
{
    internal partial class Run
    {
        List<Gadgets> gadgets = new List<Gadgets>();


        public void DisplayAllGadgets()
        {

            gadgets.Add(new Gadgets("Hp", "1111", 230000));
            gadgets.Add(new Gadgets("Dell", "2222", 330000));
            gadgets.Add(new Gadgets("Macbook", "3333", 270000));
            gadgets.Add(new Gadgets("iPhone", "4444", 170000));
            gadgets.Add(new Gadgets("Samsung", "5555", 190000));
            gadgets.Add(new Gadgets("Lenovo", "6666", 100000));
            gadgets.Add(new Gadgets("Speaker", "7777", 90000));
            gadgets.Add(new Gadgets("iWatch", "8888", 15000));


            Console.WriteLine($"{{0, -15}}{{1, -15}}{{2, 0}}", "Laptop Brand", "Laptop ID", "Laptop Price");
            foreach (Gadgets gadget in gadgets)
            {

                Console.WriteLine($"{{0, -15}}{{1, -15}}{{2, 0}}", gadget.Brand, gadget.ID, gadget.Price);
            }
        }
        public void BuyAGadget()
        {
            DisplayAllGadgets();
        }

        public void Start()
        {
            Console.WriteLine("Here's a list of our available laptops and their prices. Please do make a choice");
            DisplayAllGadgets();

            Console.WriteLine("Please select the ID of the Laptop that you are interested in");
            string iD = Console.ReadLine();

            gadget = gadgets.FirstOrDefault<Gadgets>(a => a.ID == iD);
            if (gadget.ID != iD)
            {
                Console.WriteLine("Laptop not available. Please select available laptop");
            }
            else
            {
                Console.WriteLine($"Your selected laptop is: {gadget.Brand} {gadget.Price}");
                Console.WriteLine("Please Select a payment plan");

                Init();
            }
        }
    }
}
