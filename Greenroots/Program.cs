// Produkt 1
int produkt1Id = 1;
string produkt1Navn = "Bambus tandbørste";
string produkt1Kategori = "Bad";
double produkt1Pris = 39.0;
string produkt1Miljømærke = "Svanemærket";
int produkt1AntalSolgt = 243;

// Produkt 2
int produkt2Id = 2;
string produkt2Navn = "Genanvendelig kaffefilter";
string produkt2Kategori = "Køkken";
double produkt2Pris = 129.0;
string produkt2Miljømærke = "Ingen";
int produkt2AntalSolgt = 214;

// Produkt 3
int produkt3Id = 3;
string produkt3Navn = "Økologisk gødning";
string produkt3Kategori = "Have";
double produkt3Pris = 29.0;
string produkt3Miljømærke = "Ingen";
int produkt3AntalSolgt = 423;

// Produkt 4
int produkt4Id = 4;
string produkt4Navn = "Bambus sengebord";
string produkt4Kategori = "Soveværelse";
double produkt4Pris = 800.99;
string produkt4Miljømærke = "Ingen";
int produkt4AntalSolgt = 32;

// Produkt 5
int produkt5Id = 5;
string produkt5Navn = "Sæbe";
string produkt5Kategori = "Bad";
double produkt5Pris = 30.99;
string produkt5Miljømærke = "Svanemærket";
int produkt5AntalSolgt = 2300;

// Opgave 2
// Beregner omsætning for et produkt ud fra prisen og mængde solgt.
double BeregnOmsætning(double pris, int antalSolgt)
{
    return pris * antalSolgt;
}

// Opgave 3
// Kategoriserer omsætningen i 3 forskellige kategorier: lav, mellem og høj.
string KategoriserOmsætning(double omsætning)
{
    if (omsætning < 10000)
    {
        return "Lav omsætning";
    }
    else if (omsætning >= 10000 || omsætning <= 50000)
    {
        return "Mellem omsætning";
    }
    else if (omsætning > 50000)
    {
        return "Høj omsætning";
    }
    else
    {
        return "ERROR!";
    }
}

// Opgave 4
// Simulering af 7 dage og derefter behandling af dataen.
void databehandling()
{
    int antalDage = 7;
    double totalOmsætning = 0;

    for (int dagNr = 1; dagNr <= antalDage; dagNr++)
    {
        // Simuler varierende dagligt salg ved hjælp af dagsnummeret
        int produkt1DagligtSalg = produkt1AntalSolgt / antalDage + (dagNr % 3);
        int produkt2DagligtSalg = produkt2AntalSolgt / antalDage + (dagNr % 3);
        int produkt3DagligtSalg = produkt3AntalSolgt / antalDage + (dagNr % 3);
        int produkt4DagligtSalg = produkt4AntalSolgt / antalDage + (dagNr % 3);
        int produkt5DagligtSalg = produkt5AntalSolgt / antalDage + (dagNr % 3);
        

        // Beregn dagens omsætning.
        double dagensOmsætning1 = BeregnOmsætning(produkt1Pris, produkt1DagligtSalg);
        double dagensOmsætning2 = BeregnOmsætning(produkt2Pris, produkt2DagligtSalg);
        double dagensOmsætning3 = BeregnOmsætning(produkt3Pris, produkt3DagligtSalg);
        double dagensOmsætning4 = BeregnOmsætning(produkt4Pris, produkt4DagligtSalg);
        double dagensOmsætning5 = BeregnOmsætning(produkt5Pris, produkt5DagligtSalg);

        // Tilføj til totalOmsætning
        totalOmsætning = dagensOmsætning1 + dagensOmsætning2 + dagensOmsætning3 + dagensOmsætning4 + dagensOmsætning5;

        // Udskriv dagens statistik
        Console.WriteLine("Dag: " + dagNr + ".");

        Console.WriteLine("Produkt 1. Antal solgt: " + produkt1DagligtSalg + ". Omsætning: " + dagensOmsætning1);
        Console.WriteLine("Produkt 2. Antal solgt: " + produkt2DagligtSalg + ". Omsætning: " + dagensOmsætning2);
        Console.WriteLine("Produkt 3. Antal solgt: " + produkt3DagligtSalg + ". Omsætning: " + dagensOmsætning3);
        Console.WriteLine("Produkt 4. Antal solgt: " + produkt4DagligtSalg + ". Omsætning: " + dagensOmsætning4);
        Console.WriteLine("Produkt 5. Antal solgt: " + produkt5DagligtSalg + ". Omsætning: " + dagensOmsætning5);

        Console.WriteLine("Total omsætning for dagen: " + totalOmsætning);
    }
}


// Console
Console.WriteLine("Give input in console.");
Console.WriteLine("1. print all products");
Console.WriteLine("2. Beregn omsætning for produkter.");
Console.WriteLine("3. Kategoriser produkter efter omsætning.");
Console.WriteLine("4. Databehandling.");
string inputAction = Console.ReadLine();

// Print all products i console
if (inputAction == "1")
{
    Console.WriteLine("Produkt 1 | ID:" + produkt1Id + ". Navn: " + produkt1Navn + ". Kategori: " + produkt1Kategori + ". Miljømærke: " + produkt1Miljømærke + ". Antal solgt: " + produkt1AntalSolgt);
    Console.WriteLine("Produkt 2 | ID:" + produkt2Id + ". Navn: " + produkt2Navn + ". Kategori: " + produkt2Kategori + ". Miljømærke: " + produkt2Miljømærke + ". Antal solgt: " + produkt2AntalSolgt);
    Console.WriteLine("Produkt 3 | ID:" + produkt3Id + ". Navn: " + produkt3Navn + ". Kategori: " + produkt3Kategori + ". Miljømærke: " + produkt3Miljømærke + ". Antal solgt: " + produkt3AntalSolgt);
    Console.WriteLine("Produkt 4 | ID:" + produkt4Id + ". Navn: " + produkt4Navn + ". Kategori: " + produkt4Kategori + ". Miljømærke: " + produkt4Miljømærke + ". Antal solgt: " + produkt4AntalSolgt);
    Console.WriteLine("Produkt 5 | ID:" + produkt5Id + ". Navn: " + produkt5Navn + ". Kategori: " + produkt5Kategori + ". Miljømærke: " + produkt5Miljømærke + ". Antal solgt: " + produkt5AntalSolgt);
}
// Console for at beregne omsætningen for individuelle produkter.
else if (inputAction == "2")
{
    Console.WriteLine("What products?: ");
    Console.WriteLine("1. Product 1.");
    Console.WriteLine("2. Product 2.");
    Console.WriteLine("3. Product 3.");
    Console.WriteLine("4. Product 4.");
    Console.WriteLine("5. Product 5.");

    string inputAction2 = Console.ReadLine();

    if (inputAction2 == "1")
    {
        double result = BeregnOmsætning(produkt1Pris, produkt1AntalSolgt);
        Console.WriteLine("Product 1: " + result + " dkk.");
    }
    if (inputAction2 == "2")
    {
        double result = BeregnOmsætning(produkt2Pris, produkt2AntalSolgt);
        Console.WriteLine("Product 2: " + result + " dkk.");
    }
    if (inputAction2 == "3")
    {
        double result = BeregnOmsætning(produkt3Pris, produkt3AntalSolgt);
        Console.WriteLine("Product 3: " + result + " dkk.");
    }
    if (inputAction2 == "4")
    {
        double result = BeregnOmsætning(produkt4Pris, produkt4AntalSolgt);
        Console.WriteLine("Product 4: " + result + " dkk.");
    }
    if (inputAction2 == "5")
    {
        double result = BeregnOmsætning(produkt5Pris, produkt5AntalSolgt);
        Console.WriteLine("Product 5: " + result + " dkk.");
    }
}
// Console for at kategorisere produkter ud fra omsætningen.
else if (inputAction == "3")
{
    Console.WriteLine("What products?: ");
    Console.WriteLine("1. Product 1.");
    Console.WriteLine("2. Product 2.");
    Console.WriteLine("3. Product 3.");
    Console.WriteLine("4. Product 4.");
    Console.WriteLine("5. Product 5.");

    string inputAction3 = Console.ReadLine();

    if (inputAction3 == "1")
    {
        double result = BeregnOmsætning(produkt1Pris, produkt1AntalSolgt);
        string kategori = KategoriserOmsætning(result);
        Console.WriteLine("Product 1 har en omsætning på: " + result + " dkk. og er derved i kategorien: " + kategori);
    }
    if (inputAction3 == "2")
    {
        double result = BeregnOmsætning(produkt2Pris, produkt2AntalSolgt);
        string kategori = KategoriserOmsætning(result);
        Console.WriteLine("Product 2 har en omsætning på: " + result + " dkk. og er derved i kategorien: " + kategori);
    }
    if (inputAction3 == "3")
    {
        double result = BeregnOmsætning(produkt3Pris, produkt3AntalSolgt);
        string kategori = KategoriserOmsætning(result);
        Console.WriteLine("Product 3 har en omsætning på: " + result + " dkk. og er derved i kategorien: " + kategori);
    }
    if (inputAction3 == "4")
    {
        double result = BeregnOmsætning(produkt4Pris, produkt4AntalSolgt);
        string kategori = KategoriserOmsætning(result);
        Console.WriteLine("Product 4 har en omsætning på: " + result + " dkk. og er derved i kategorien: " + kategori);
    }
    if (inputAction3 == "5")
    {
        double result = BeregnOmsætning(produkt5Pris, produkt5AntalSolgt);
        string kategori = KategoriserOmsætning(result);
        Console.WriteLine("Product 5 har en omsætning på: " + result + " dkk. og er derved i kategorien: " + kategori);
    }

}
// Console for databehandling
else if (inputAction == "4")
{
    databehandling();
}