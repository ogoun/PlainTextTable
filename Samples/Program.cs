using PlainTextTable;
using System;

namespace Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            var ttd = new TextTableData(4);
            ttd.SetColumnsHeaders(new[] { "№", "Name", "Country", "Points" });
            ttd.AppendRow(new[] { "1", "BOE Johannes Thingnes", "NOR", "542" });
            ttd.AppendRow(new[] { "2", "LOGINOV Alexander", "RUS", "412" });
            ttd.AppendRow(new[] { "3", "FOURCADE Martin", "FRA", "342" });
            ttd.AppendRow(new[] { "4", "DESTHIEUX Simon", "FRA", "336" });
            ttd.AppendRow(new[] { "5", "EDER Simon", "AUT", "328" });
            ttd.AppendRow(new[] { "6", "PEIFFER Arnd", "GER", "307" });
            ttd.AppendRow(new[] { "7", "GUIGONNAT Antonin", "FRA", "305" });
            ttd.AppendRow(new[] { "8", "DOLL Benedikt", "GER", "304" });
            ttd.AppendRow(new[] { "9", "EBERHARD Julian", "AUT", "298" });
            ttd.AppendRow(new[] { "10", "BOE Tarjei", "NOR", "298" });

            
            int option;
            while ((option = GetOption())!= -1)
            {
                Console.Clear();
                switch (option)
                {
                    case 1:
                        ShowBuiltinStyles(ttd);                        
                        break;
                    case 2:
                        PaddingsExample(ttd);
                        break;
                    case 3:
                        TableWidthExample(ttd);
                        break;
                    case 4:
                        CellWidthExample(ttd);
                        break;
                }
                Console.WriteLine("Press key to return");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static int GetOption()
        {
            Console.WriteLine("Select option number to show example, or press esc for exit");
            Console.WriteLine("1. Built-In styles");
            Console.WriteLine("2. Paddings");
            Console.WriteLine("3. Max table width");
            Console.WriteLine("4. Max cell width");
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape) return -1;
            return key.KeyChar - 48;
        }

        static void ShowBuiltinStyles(TextTableData ttd)
        {
            foreach (var style in Enum.GetValues(typeof(TextTableStyle)))
            {
                Console.WriteLine($"Style: {style}");
                var opt = new TextTableRenderOptions();
                opt.Style = (TextTableStyle)style;
                Console.WriteLine(TextTableRender.Render(ttd, opt));
            }
        }

        static void PaddingsExample(TextTableData ttd)
        {
            var opt = new TextTableRenderOptions();
            opt.Style = TextTableStyle.Borders;
            opt.PaddingBottom = 2;
            opt.PaddingLeft = 5;
            opt.PaddingRight = 5;
            opt.PaddingTop = 2;
            Console.WriteLine(TextTableRender.Render(ttd, opt));
        }

        static void TableWidthExample(TextTableData ttd)
        {
            var opt = new TextTableRenderOptions();
            opt.Style = TextTableStyle.Borders;
            opt.MaxTableWidth = 40;
            Console.WriteLine(TextTableRender.Render(ttd, opt));
        }

        static void CellWidthExample(TextTableData ttd)
        {
            var opt = new TextTableRenderOptions();
            opt.Style = TextTableStyle.Borders;
            opt.MaxCellWidth = 4;
            Console.WriteLine(TextTableRender.Render(ttd, opt));
        }
    }
}
