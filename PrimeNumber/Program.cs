using System;

namespace PrimeNumber
{
//class Array
//	{
//		public void Myarray()
//		{
//			Console.WriteLine("enter the length of your array");
//			int a = Convert.ToInt32(Console.ReadLine());
//			int[] myarray = new int[a];
//			for (int i = 0; i < a; i++)
//			{ myarray[i] = Convert.ToInt32(Console.ReadLine());
//				int m = myarray[i]/2;
//			for (int y = 2; y <=m; y++)
//				{
//					if (myarray[i] % y != 0) {
//						Console.WriteLine("is a prime number")
//	 ;
//					}
//				}
//			}

			

//		}
//	}
public class Array
	{
		
		public int Myarray(int[]val,int n)
		{
			for (int i = 0; i < val.Length; i++)
			{
				int k = 0;
				for (int c = 2; c < val[i]; c++)
				{
					if (val[i] % c == 0)
					{
						k = 1;
						break;
					}

					if (k == 0)
					{
						 n = val[i];

					}
					
				}
	
			}
			return n ;  
		}
	}
	class Program
	{

		static void Main(string[] args)
		{
			int[] val = { 3, 5, 7, 8,  6 };
			int n = 0;
			Array me = new Array();
			foreach (var item in val)
			{
				int ans=me.Myarray(val, n) * item;
				Console.WriteLine(ans);
			}
			

		}
	}
}
