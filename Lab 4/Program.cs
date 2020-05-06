namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Liczby L1 = new Liczby();
            Liczby L2 = new Liczby();

            L1.Set_A(3);
            L1.Set_B(4);
            L1.Set_C(5);

            L2.Set_A(5);
            L2.Set_B(12);
            L2.Set_C(13);

            Lepsze_Liczby LL1 = new Lepsze_Liczby();

            System.Console.WriteLine("Liczba L1: a = " + L1.Get_A() + ", b = " + L1.Get_B() + ", c = " + L1.Get_C());
            System.Console.WriteLine("Liczba L2: a = " + L2.Get_A() + ", b = " + L2.Get_B() + ", c = " + L2.Get_C());
            System.Console.WriteLine("Lepsza Liczba LL1: a = " + LL1.Get_A() + ", b = " + LL1.Get_B() + ", c = " +
                                     LL1.Get_C());

        }
    }
}
