using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    internal class PromosyonGonder
    {
        public void Gonder(PromosyonBuilder promosyonBuilder)
        {
            promosyonBuilder.SetCalisanProfili();
            promosyonBuilder.SetPromosyonNumarasi();
            promosyonBuilder.SetUrunAdi();
        }
    }
}
