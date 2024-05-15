namespace TestDolgozatProject
{
	public class Tests
	{
		Dolgozat d;

		[SetUp]
		public void Setup()
		{
			d = new Dolgozat();
		}
		//1: konstruktor
		//dolg l�tezik
		//lista l�tezik, lista �res
		[Test]
		public void Konstr_DolgLetezik()
		{
			Assert.That(d is not null);

		}
		[Test]
		public void Konstr_ListaLetezik()
		{
			Assert.That(d.Pontok is not null);

		}
		[Test]
		public void Konstr_ListaUres()
		{
			Assert.That(d.Pontok.Count == 0);
		}

		//beleteszem, benne van: -1, 0, 100, 42
		//egym�s ut�n kett�t beleteszek �s kett� is benne van
		//hib�t dob: 144, -2, 1.618, null
		// nullt �s aranymetsz�st be se tudom �rni, nem fordul le
		[Test]
		public void Felvesz_hibas1()
		{
			Assert.Throws<ArgumentException>(() => d.PontFelvesz(-2));
		}
		[Test]
		public void Felvesz_hibas2()
		{
			Assert.Throws<ArgumentException>(() => d.PontFelvesz(144));
		}
		[Test]
		public void Felvesz_egyet()
		{
			d.PontFelvesz(42);
			bool feltetel = d.Pontok.Count() == 1 && d.Pontok[0] == 42;
			Assert.That(feltetel);
		}
		[Test]
		public void Felvesz_tobbet()
		{
			d.PontFelvesz(42);
			d.PontFelvesz(-1);
			d.PontFelvesz(100);
			bool feltetel = d.Pontok.Count() == 3 && d.Pontok[0] == 42;
			feltetel = feltetel && d.Pontok[1] == -1;
			feltetel = feltetel && d.Pontok[2] == 100;
			Assert.That(feltetel);
		}
		//mindenki meg�rta: igen, nem, �res halmaz
		[Test]
		public void Megirtak_nincsdiak()
		{
			Assert.That(d.MindenkiMegirta);
		}
		[Test]
		public void Megirtak_mindenki()
		{

			d.PontFelvesz(42);
			d.PontFelvesz(0);
			d.PontFelvesz(100);
			Assert.That(d.MindenkiMegirta());
		}
		[Test]
		public void Megirtak_nemmindenki()
		{
			d.PontFelvesz(42);
			d.PontFelvesz(-1);
			d.PontFelvesz(100);
			Assert.That(!d.MindenkiMegirta());


		}
	}
}