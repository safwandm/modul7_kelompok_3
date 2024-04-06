using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_3
{
    public class glossaryBody
    {
        public glossary glossary { get; set; }

    }

    public class glossary
    {
        public GlossDiv GlossDiv { get; set; }
    }

    public class GlossDiv
    {
        public GlossList GlossList { get; set; }
    }

    public class GlossList
    {
        public GlossEntry GlossEntry { get; set; }
    }

    public class GlossEntry
    {
        public string id { get; set; }
        public string sortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abrev { get; set; }
        public GlossDef GlossDef {  get; set; }
        public string Glossee {  get; set; }
    }

    public class GlossDef
    {
        public string para { get; set; }
        public string GlossSeeAlso {  get; set; }
    }

    internal class GlossaryItem1302223119
    {
        public static void ReadJSON()
        {
            string filePath = "../../../jurnal7_3_1302223119.json";

            string json = File.ReadAllText(filePath);

            var data = JsonSerializer.Deserialize<glossaryBody>(json);

            GlossEntry entry = data.glossary.GlossDiv.GlossList.GlossEntry;

            Console.WriteLine($"[{entry.id}, {entry.sortAs}, {entry.GlossTerm}, {entry.Acronym}]");


        }
    }
}
