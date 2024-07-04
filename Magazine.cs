using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace hw_11_07
{
    internal class Magazine
    {
        public string Name {  get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }

        public Magazine(string name, string author, int year, int pages)
        {
            Name = name;
            Author = author;
            Year = year;
            Pages = pages;
        }

        public override string ToString() => $"{Name}, {Author}, {Year}, {Pages}";


        public void Show()
        {
            Console.WriteLine(this);
        }

        public static void SerializedMagazine(List<Magazine> list, string filepath)
        {
            var option = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string jsonfile = JsonSerializer.Serialize(list,option);
            File.WriteAllText(filepath,jsonfile);
        }

        public static List<Magazine> DeserializeMagazine(string filepath)
        {
            string json = File.ReadAllText(filepath);
            return JsonSerializer.Deserialize<List<Magazine>>(json);
        }


    }
}
