namespace Lab_4
{
    public class Liczby
    {
        protected int A;
        protected int B;
        protected int C;

        public Liczby()
        {
            A = 0;
            B = 0;
            C = 0;
        }

        public int Get_A()
        {
            return A;
        }

        public void Set_A(int liczba)
        {
            A = liczba;
        }

        public int Get_B()
        {
            return B;
        }

        public void Set_B(int liczba)
        {
            B = liczba;
        }

        public int Get_C()
        {
            return C;
        }

        public void Set_C(int liczba)
        {
            C = liczba;
        }
    }
}