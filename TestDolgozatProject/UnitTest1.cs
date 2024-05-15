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
		//dolg létezik
		//lista létezik, lista üres
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
		//egymás után kettõt beleteszek és kettõ is benne van
		//hibát dob: 144, -2, 1.618, null
		// nullt és aranymetszést be se tudom írni, nem fordul le
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
		//mindenki megírta: igen, nem, üres halmaz
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