using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndeksatorLecture
{
	internal class MultArray
	{
		private int[,] array;
		public int Rows { get; private set; }
		public int Cols { get; private set; }

		public MultArray(int rows, int cols)
		{
			Rows = rows;
			Cols = cols;
			array = new int[rows, cols];
		}

		public int this[int row, int col]
		{
			get { return array[row, col]; }
			set { array[row, col] = value; }
		}
	}
}
