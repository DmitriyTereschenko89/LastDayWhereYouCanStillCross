namespace LastDayWhereYouCanStillCross
{
	internal class Program
	{
		static void Main(string[] args)
		{
			LastDayWhereYouCanStillCross lastDayWhereYouCanStillCross = new();
            Console.WriteLine(lastDayWhereYouCanStillCross.LatestDayToCross(2, 2, new int[][] 
			{
				new int[] { 1, 1 }, 
				new int[] { 2, 1 }, 
				new int[] { 1, 2 }, 
				new int[] { 2, 2 } 
			}));
			Console.WriteLine(lastDayWhereYouCanStillCross.LatestDayToCross(2, 2, new int[][]
			{
				new int[] { 1, 1 },
				new int[] { 1, 2 },
				new int[] { 2, 1 },
				new int[] { 2, 2 }
			}));
			Console.WriteLine(lastDayWhereYouCanStillCross.LatestDayToCross(3, 3, new int[][]
			{
				new int[] { 1, 2 },
				new int[] { 2, 1 },
				new int[] { 3, 3 },
				new int[] { 2, 2 },
				new int[] { 1, 1 },
				new int[] { 1, 3 },
				new int[] { 2, 3 },
				new int[] { 3, 2 },
				new int[] { 3, 1 }
			}));
		}
	}
}