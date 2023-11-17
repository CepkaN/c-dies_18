using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_dies_18
{
    public class Orion:BPLA
    {
        public string Nome { get; set; }
        public double Lung { get; set; }
        public double ApAlare { get; set; }
        public double Mass { get; set; }
        public double VelDiCrociera { get; set; }
        public int Durar { get; set; }
        public double Corsoo { get; set; }

        public Coord coo;
        public List<Coord> COCS = new List<Coord>();
        public Orion() { }
        public Orion(string N,double L,double A,double M,double V,int D,int a=0,int b=0,int c=0) {
        Nome= N;Lung = L;ApAlare = A;Mass = M;VelDiCrociera = V;Durar = D; coo = Coordin(a,b,c);Corsoo = 0;
        }
        public override void Mostrare()
        {
            Console.WriteLine(" --- " + Nome + " ---" + "\n Длина : " + Lung + "\n Размах крыльев : " + ApAlare + "\n Масса : " + Mass + "\n Крейсерская скорость : " + VelDiCrociera + "\n Продолжительность полета : " + Durar + '\n');
        }
        public override Coord Coordin(int a, int b, int c)
        {            
            Coord CO = new Coord(a,b,c);
            COCS.Add(CO);
            return CO;
        }
        public override void ADDcocs(Coord cc)
        {
            COCS.Add(cc);
        }
        public override void Coordin()
        {
            Console.WriteLine("Введите новые координаты : 1 - ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите новые координаты : 2 - ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите новые координаты : 3 - ");
            int c = Convert.ToInt32(Console.ReadLine());
            Coord c1 = new Coord(a, b, c);
            ADDcocs(c1);
            coo = c1;
        }

        public override void Corso()
        {           
                double s = 0;
                for (int i = 1; i < COCS.Count; ++i)
                {
                    s = s + Math.Sqrt(Math.Pow(COCS[i].X - COCS[i - 1].X, 2) + Math.Pow(COCS[i].Y - COCS[i - 1].Y, 2) + Math.Pow(COCS[i].Z - COCS[i - 1].Z, 2));
                }
            Corsoo += s;
            Console.WriteLine(Nome + " Общий путь " + Corsoo);
        }
    }
}
