using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    abstract class PromosyonBuilder
    {
        protected Promosyon promosyon { get; set; }
        public Promosyon Promosyon {
            get {
                return promosyon;
            }
        }

        public abstract void SetUrunAdi();
        public abstract void SetPromosyonNumarasi();
        public abstract void SetCalisanProfili();
    }
}
