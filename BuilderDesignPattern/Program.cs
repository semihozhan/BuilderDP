using BuilderDesignPattern;

PromosyonBuilder promosyon = new TechConcreateBuilder();
PromosyonGonder PromosyonGonder = new PromosyonGonder();
PromosyonGonder.Gonder(promosyon);
promosyon.Promosyon.ToString();


PromosyonBuilder promosyonik = new IKConcreateBuilder();
PromosyonGonder PromosyonGonderik = new PromosyonGonder();
PromosyonGonderik.Gonder(promosyonik);
promosyonik.Promosyon.ToString();