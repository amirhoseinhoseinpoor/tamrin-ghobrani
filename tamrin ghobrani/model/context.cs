namespace tamrin_ghobrani.model
{
    class Digikalacontext
    {
        private Digikala digikala;
        private string line;
        public List<Digikala> digikalas { get; }
        public Digikalacontext(string address)
        {
            digikalas = new List<Digikala>();
            using (StreamReader reader = new StreamReader(address))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    digikala = new Digikala();

                    digikala.ID_Order = Convert.ToInt32(line.Split(",")[0]);
                    digikala.ID_Customer = Convert.ToInt32(line.Split(",")[1]);
                    digikala.ID_Item = Convert.ToInt32(line.Split(",")[2]);
                    digikala.DateTime_CartFinalize = Convert.ToDateTime(line.Split(",")[3]);
                    digikala.Amount_Gross_Order = Convert.ToInt32(line.Split(",")[4].Replace(".0", ""));
                    digikala.city_name_fa = line.Split(",")[5];

                    digikalas.Add(digikala);

                }
            }
        }
    }
}
