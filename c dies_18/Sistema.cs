using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace c_dies_18
{
    public delegate void Peremeshenie();
    public class Sistema
    {
        public List<BPLA> APR { get; set; }
        public event Peremeshenie Pre;
        public Sistema()
        {
            APR= new List<BPLA>();
        }
        public void AddBPLA(BPLA B)
        {
            APR.Add(B);
            Console.WriteLine(" Добавлен БПЛА " + B.Nome);
        }
        public void Reumovere(BPLA B)
        {
            APR.Remove(B);
            Console.WriteLine(" Удалён БПЛА ");
        }
        public void Mostr()
        {
            int a = 0;
            foreach(var R in APR)
            {
                Console.Write(++a);
                R.Mostrare();
            }
        }
        public void IzCor()
        {
            Console.WriteLine(" Выберите БПЛА : ");
            Mostr();
            Console.WriteLine(" Введите номер БПЛА : ");
            int d = Convert.ToInt32(Console.ReadLine());
            --d;
            APR[d].Coordin();
            Console.WriteLine(" Координаты записаны ");
            APR[d].Corso();
            
            Pre += Sistema_Pre;
        }

        private void Sistema_Pre()
        {
            throw new NotImplementedException();
        }
        public void Via()
        {
            foreach (var R in APR)
            {
                R.Corso();
            }
        }
        public void JZap()
        {
            string str = "C:\\Users\\C - 6\\Documents\\Чепурина\\c dies_18\\c dies_18\\aaa.json";
            string json = JsonConvert.SerializeObject(APR);
            System.IO.File.WriteAllText(str, json);
            string json1 = File.ReadAllText(str);
            Console.WriteLine(json1);


        }
        public void XML()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<BPLA>));

            string xml1 = "C:\\Users\\C - 6\\Documents\\Чепурина\\c dies_18\\c dies_18\\bbb.xml";
            using (FileStream fs = new FileStream(xml1, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, APR);

                Console.WriteLine("Object has been serialized");
            }
        }
    }
}
