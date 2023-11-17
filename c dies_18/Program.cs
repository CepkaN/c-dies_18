namespace c_dies_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dozor doz = new Dozor(" Дозор-100 ", 3.0, 5.4, 95, 120, 10);
            Granat gra = new Granat(" Гранат-4 ", 2.6, 3.2, 30, 90, 6);
            Orion or = new Orion(" Орион-Э ", 8, 16.3, 1000, 120, 24);
            Sistema STM = new Sistema();
            STM.AddBPLA(doz);
            STM.AddBPLA(gra);
            STM.AddBPLA(or);
            STM.Mostr();
            doz.coo = doz.Coordin(23, 34, 2);
            gra.coo=gra.Coordin(23, 2, 3);
            or.coo=or.Coordin(9, 8, 6);
            STM.Via();
            //STM.IzCor();
            //STM.JZap();
            STM.XML();
        }
    }
}