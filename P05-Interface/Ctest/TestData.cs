using P05_Interface.ITest;

namespace P05_Interface.Ctest
{
    internal class TestData : InterfaceTest
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Display()
        {
            Console.WriteLine("You Id is" +  Id);
            Console.WriteLine("You Name is" +  Name);
        }

        public void Input()
        {
            Id = 2; 
            Name = "foo";
        }

       
    }
}
