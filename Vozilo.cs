using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortiranjaj
{
    public class Vozilo
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int GodinaProizvodnje { get; set; }
        public int Kilometraza { get; set; }

        public Vozilo(string marka, string model, int godinaProizvodnje, int kilometraza)
        {
            Marka = marka;
            Model = model;
            GodinaProizvodnje = godinaProizvodnje;
            Kilometraza = kilometraza;
        }

        public override string ToString()
        {
            return $"{Marka} - {Model} - {GodinaProizvodnje} - {Kilometraza}";
        }
        private void SpremiVozila()
        {
            using (StreamWriter writer = new StreamWriter("vozila.txt"))
            {
                foreach (var vozilo in vozila)
                {
                    writer.WriteLine($"{vozilo.Marka},{vozilo.Model},{vozilo.GodinaProizvodnje},{vozilo.Kilometraza}");
                }
            }
        }

        private void UcitajVozila()
        {
            if (File.Exists("vozila.txt"))
            {
                using (StreamReader reader = new StreamReader("vozila.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var podaci = line.Split(',');
                        Vozilo vozilo = new Vozilo(podaci[0], podaci[1], int.Parse(podaci[2]), int.Parse(podaci[3]));
                        vozila.Add(vozilo);
                    }
                }
            }
        }
    }
}
