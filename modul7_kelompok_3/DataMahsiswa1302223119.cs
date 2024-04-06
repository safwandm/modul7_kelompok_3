using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_3
{
    public class Data
    {
        public member[] members { get; set; }

    }

    public class member
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }
    internal class DataMahasiswa1302223119
    {
        public static void ReadJSON()
        {
            string filePath = "../../../jurnal7_2_1302223119.json";

            string json = File.ReadAllText(filePath);

            var data = JsonSerializer.Deserialize<Data>(json);

            Console.WriteLine("Team member list");
            foreach (member member in data.members)
            {
                Console.WriteLine($"{member.nim} {member.firstName + " " + member.lastName} ({member.age} {member.gender})");

            }

        }
    }
}
