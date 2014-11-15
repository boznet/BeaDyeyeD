namespace boznet.Beady_Eyed.Test
{
	public interface ICalculator
	{
		int Add(int addme, int andMe);
		int Subtract(int subtractMe, int andMe);
	}

	public class Calculator : ICalculator
	{
		public int Add(int addme, int andMe)
		{
			return addme + andMe;
		}

		public int Subtract(int subtractMe, int andMe)
		{
			return subtractMe - andMe;
		}
	}
}