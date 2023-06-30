namespace LastDayWhereYouCanStillCross
{
	internal class LastDayWhereYouCanStillCross
	{
		private bool IsCanCross(int row, int col, int days, int[][] cells)
		{
			int directions = 4;
			int[,] grid = new int[row, col];
			for (int day = 0; day < days; ++day)
			{
				grid[cells[day][0] - 1, cells[day][1] - 1] = 1;
			}
			int[] deltaR = new int[] { 0, -1, 0, 1 };
			int[] deltaC = new int[] { -1, 0, 1, 0 };
			Queue<(int, int)> queue = new();
			for (int c = 0; c < col; ++c)
			{
				if (grid[0, c] == 0)
				{
					queue.Enqueue((0, c));
					grid[0, c] = 1;
				}
			}
			while(queue.Count > 0)
			{
				(int, int) cell = queue.Dequeue();
				for (int dir = 0; dir < directions; ++dir)
				{
					int newR = cell.Item1 + deltaR[dir];
					int newC = cell.Item2 + deltaC[dir];
					if (newR >= 0 && newR < row && newC >= 0 && newC < col && grid[newR, newC] != 1)
					{
						if (newR == row - 1)
						{
							return true;
						}
						queue.Enqueue((newR, newC));
						grid[newR, newC] = 1;
					}
				}
			}
			return false;
		}

		public int LatestDayToCross(int row, int col, int[][] cells)
		{
			int leftDays = 1;
			int rightDays = row * col;
			while(leftDays < rightDays)
			{
				int middleDays = leftDays + (rightDays - leftDays) / 2;
				if (IsCanCross(row, col, middleDays, cells))
				{
					leftDays = middleDays + 1;
				}
				else
				{
					rightDays = middleDays;
				}
			}
			return rightDays - 1;
		}
	}
}
