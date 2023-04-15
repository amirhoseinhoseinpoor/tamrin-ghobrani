using tamrin_ghobrani.model;

namespace opreations
{
    class Digikalaopreations
    {
        List<Digikala> digikalas;
        public Digikalaopreations(List<Digikala> digikalas)
        {
            this.digikalas = digikalas;
        }
        public static bool isodd(int ID_Customer)
        {
            int odd = ID_Customer;
            string address2 = @"E:\odd.csv";
            StreamWriter writer = new StreamWriter(address2);
            if (ID_Customer % 2 != 0)
            {
                writer.WriteLine(ID_Customer);
                return true;
            }
            else return false;
        }
        public static bool isprime(int ID_Customer)
        {
            string address3 = @"E:\odd.csv";
            if (ID_Customer <= 1)
                return false;
            for (int i = 2; i < ID_Customer; i++)
            {
                if (ID_Customer % i == 0)
                    return false;
            }
            StreamWriter writer = new StreamWriter(address3 + "-" + ID_Customer);
            return true;
        }
        public static bool mirror(int ID_Customer)
        {
            string address4 = @"E:\odd.csv";
            int reversnumber = 0;
            int numberasli = ID_Customer;
            while (ID_Customer > 0)
            {
                int digit = ID_Customer % 10;
                reversnumber = (reversnumber * 10) + digit;
                ID_Customer /= 10;
            }
            return numberasli == reversnumber;
        }
    }
}
