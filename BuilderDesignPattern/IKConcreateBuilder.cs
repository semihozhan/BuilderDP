using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    internal class IKConcreateBuilder : PromosyonBuilder
    {
        public IKConcreateBuilder()
        {
            promosyon = new Promosyon();
        }
        public override void SetCalisanProfili()
        {
            promosyon.CalisanProfili = "IK";
        }

        public override void SetPromosyonNumarasi()
        {
            promosyon.PromosyonNumarasi = 1215;
        }

        public override void SetUrunAdi()
        {
            promosyon.UrunAdi = "Masa Lambası";
        }
    }
}
