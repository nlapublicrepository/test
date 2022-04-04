using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace ProjetTest
{
	/// <summary>
	/// This test class cannot be modified.
	/// </summary>
	public class UnitTest
	{
		private List<string> aTestList;

		public UnitTest()
		{
			aTestList = new List<string>();
			aTestList.Add("one");
			aTestList.Add("two");
			aTestList.Add("three");
		}			

		/// <summary>
		/// First part: list management
		/// estimated time: 10 min		
		/// </summary>
		[Fact]
		public void ShouldConcatenateASimpleString()
		{
			String str = List.Concatenate(aTestList);
			Assert.Equal("one,two,three", str);
		}

		[Fact]
		public void ShouldRevertAList()
		{
			List<String> result = List.ReverseList(aTestList);
			Assert.Equal("three", result[0]);
			Assert.Equal("two", result[1]);
			Assert.Equal("one", result[2]);
		}

		[Fact]
		public void ShouldUppercaseContent()
		{
			List<String> result = List.ToUppercase(aTestList);
			Assert.Equal("ONE", result[0]);
			Assert.Equal("TWO", result[1]);
			Assert.Equal("THREE", result[2]);
		}

		[Fact]
		public void ShouldTestAll()
		{
			List<string> list = new List<string>();
			list.Add("one");
			list.Add("two");
			list.Add("three");
			list.Add("four");

			Assert.Equal("one,two,three,four", List.Concatenate(list));
			Assert.Equal("four,three,two,one", List.Concatenate(List.ReverseList(list)));
			Assert.Equal("FOUR,THREE,TWO,ONE", List.Concatenate(List.ToUppercase(List.ReverseList(list))));
		}


		/// <summary>
		/// Second part : Bug correction
		/// Estimated time : 3 minutes
		/// Objective : the following assert is not satisfied. 
		/// 				fix bug or bugs in order to have expected result
		/// </summary>
		[Fact]
		public void Factoriel()
		{
			Assert.Equal<int>(6, Bug.Fact(3));
			Assert.Equal<int>(24, Bug.Fact(4));
		}

		/// <summary>
		/// Third part : Algorithm- Determine the number of occurences of a number in a list.
		/// Estimative time: 7 minutes
		/// Objective : an array table contains a serie of numbers.
		/// 				Determine the number of occurences of a number
		/// Example : Given the following table :  { 2, 1, 1, 3 }
		///The method Number.OrdererCount must return the following dictionnary : {(1,2) , (2,1), (3,1)}
		/// </summary>
		[Fact]
		public void CountNumber()
		{
			int[] numbers = { 2, 3, 1, 12, 2, 3, 6, 6, 3 };

			IDictionary<int, int> result = Number.OrdererCount(numbers);

			Assert.Equal<int>(2, result[2]);
			Assert.Equal<int>(1, result[12]);
			Assert.Equal<int>(2, result[6]);
			Assert.Equal<int>(3, result[3]);
			Assert.Equal<int>(1, result[1]);

			IEnumerator enumer = result.Values.GetEnumerator();
			enumer.MoveNext();
			Assert.Equal<int>(1, (int)enumer.Current);
			enumer.MoveNext();
			Assert.Equal<int>(2, (int)enumer.Current);
		}

	}
}



