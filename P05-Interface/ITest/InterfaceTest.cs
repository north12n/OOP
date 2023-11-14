namespace P05_Interface.ITest
{
    public interface InterfaceTest
    {
        //ใส่สิ่งที่จะทำ ชื่อเมธอด
        int Id { get; set; }
        string Name { get; set;  }
        void Input();
        void Display();
    }
}
