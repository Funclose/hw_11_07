namespace hw_11_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Magazine> magazines = new List<Magazine>()
            {
                new Magazine("Lana","gracy",1954,144),
                new Magazine("micro","Lasav",1977,190),
                new Magazine("something","Linkol",2003,155),
                new Magazine("usualy","osaber",1855,1242),
                new Magazine("already","ghsdg",2000,115)
            };

            string filepath = @".\myfile.json";
            Console.WriteLine("список журналов");
            foreach (var magazine in magazines)
            {
                magazine.Show();
            }

            Magazine.SerializedMagazine(magazines, filepath);
           
            var desserialize = Magazine.DeserializeMagazine(filepath);
            foreach (var magazine in desserialize)
            {
                magazine.Show();
            }
        }
    }
}
