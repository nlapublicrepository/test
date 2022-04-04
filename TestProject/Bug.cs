
namespace ProjetTest
{
	public class Bug
	{
		public static int result = 1;

		/// <summary>
		/// Computes the factorial of the number n passed as parameter.
		/// In mathematics, the factorial of a natural number n, is noted n!,
		/// "factorial of n" or "factorial n", is the product of strictly positive integers less than or equal to n.	
		/// La notation n! a été introduite en 1808 par Christian Kramp. 
		/// Examples:
		/// 3! = 3x2x1 = 6
		/// 4! = 4x3x2x1 = 24 
		public static int Fact(int n)
		{
			for (int i = n; i > 0; i--)
			{
				result *= i;
			}
			return result;
		}

	}
}
