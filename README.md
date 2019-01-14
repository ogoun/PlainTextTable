# PlainTextTable
Table render for output to plaintext


    // Prepare dataset
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
    
    // Render options
    var opt = new TextTableRenderOptions();
    opt.Style = TextTableStyle.Borders;
    opt.MaxTableWidth = 80;
    
    // Render
    Console.WriteLine(TextTableRender.Render(ttd, opt));
