using System;
using System.Collections.Generic;

namespace ListExample
{
	internal class Program
	{
		static void Main()
		{
			List<int> myList = new List<int>(10) { 
			10, 20, 30};

			myList.Add(40);

			//List<int> otherList = new List<int>() { 50, 60, 70};

			////myList.AddRange(otherList);

			//myList.Insert(1, 100);
			//myList.InsertRange(0, otherList);

			//foreach (int item in myList)
			//{
			//	Console.WriteLine(item);	
			//}	

			// Remove value 30
			// myList.Remove(30);

			// Remove at index 2
			// myList.RemoveAt(2);

			// Remove Range
			// myList.RemoveRange(2, 1);

			// Remove All
			// myList.RemoveAll(n => n > 20 && n <= 30);

			// Clear;
			myList.Clear();
			myList.Add(100);
			myList.Add(200);

			//for(int i = 0; i < myList.Count; i++)
			//{
			//	Console.WriteLine(myList[i]);
			//}

			int element = myList.Find(n => n >= 30);
			Console.WriteLine(element);

			int elementIndex = myList.FindIndex(n => n >= 30);
			Console.WriteLine(elementIndex);
	
			int lastElement = myList.FindLast(n => n >= 30);
			Console.WriteLine(lastElement);

			int lastElementIndex = myList.FindLastIndex(n => n >= 30);
			Console.WriteLine(lastElementIndex);

			List<int> listElement = myList.FindAll(n => n >= 30);
			listElement.ForEach(n => Console.WriteLine(n));
		}
	}
}