using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    internal class TechConcreateBuilder : PromosyonBuilder
    {
        public TechConcreateBuilder()
        {
            promosyon = new Promosyon();
        }
        public override void SetCalisanProfili()
        {
            promosyon.CalisanProfili = "Development";
        }

        public override void SetPromosyonNumarasi()
        {
            promosyon.PromosyonNumarasi = 1214;
        }

        public override void SetUrunAdi()
        {
            promosyon.UrunAdi = "Laptop";
        }
    }
}
