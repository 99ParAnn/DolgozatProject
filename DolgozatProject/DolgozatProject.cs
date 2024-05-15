namespace DolgozatProject
{
	public class Dolgozat
	{
		List<int> pontok;
		public List<int> Pontok { get => pontok; set => pontok = value; }

		public Dolgozat()
		{
			pontok = new List<int>();
		}
		public void PontFelvesz(int x)
		{
			if (x>=-1 && x<=100)
			{
				pontok.Add(x);
			}
			else
			{
				throw new ArgumentException();
			}
		}
		public bool MindenkiMegirta()
		{
			return !(pontok.Contains(-1));
		}
		public int Bukas()
		{
			throw new NotImplementedException();
		}
		public int Elegseges()
		{
			throw new NotImplementedException();
		}
		public int Kozepes()
		{
			throw new NotImplementedException();
		}
		public int Jo() { throw new NotImplementedException();}
		public int Jeles() { throw new NotImplementedException(); }
		public bool Gyanus() { throw new NotImplementedException(); }
		public bool Ervenytelen() { throw new NotImplementedException(); }
	}
}