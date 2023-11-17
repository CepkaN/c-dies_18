using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace c_dies_18
{
    public struct Coord { public double X, Y, Z; public Coord(int x1, int y1, int z1) { this.X = x1; this.Y = y1; this.Z = z1; } }
    [XmlInclude(typeof(Orion))]
    [XmlInclude(typeof(Dozor))]
    [XmlInclude(typeof(Granat))]
    public abstract class BPLA
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

        public virtual void Mostrare() { }
        public virtual Coord Coordin(int a, int b, int c) { return coo; }
        public virtual void Coordin() { }

        public virtual void ADDcocs(Coord cc) { }
   
        public virtual void Corso() { }


    }
}
