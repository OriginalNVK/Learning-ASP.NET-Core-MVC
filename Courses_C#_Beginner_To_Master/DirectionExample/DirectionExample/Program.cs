using System;
using System.Collections;
using System.Collections.Generic;

namespace DirectionExample
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Dictionary<int, string> employees = new Dictionary<int, string>()
			//{
			//	{1, "Nguyen Van Khanh" },
			//	{3, "Nguyen Van Quoc" },
			//	{2, "Nguyen Van Phong" },
			//};

			//foreach (KeyValuePair<int, string> employee in employees)
			//{
			//	Console.WriteLine(employee.Key + ": " + employee.Value);
			//}

			//employees.Add(4, "Nguyen thi bich Phuong");
			//// employees.Remove(4);
			//bool v = employees.ContainsValue("Nguyen Van Khanh");
			//Console.WriteLine(v);

			//Dictionary<int, string>.KeyCollection keyEmployee = employees.Keys;
			//foreach (int x in keyEmployee)
			//{
			//	Console.WriteLine(x);
			//}

			// SortedList
			//SortedList<int, string> employees = new SortedList<int, string>()
			//{
			//	{1, "NVK" },
			//	{2, "NVQ" },
			//	{5, "NVV" },
			//	{4, "PTN" }
			//};

			//int x = employees.IndexOfKey(4);
			//Console.WriteLine(x);
			//int y = employees.IndexOfValue("NVK");
			//Console.WriteLine(y);

			//foreach(KeyValuePair<int, string> employee in employees)
			//{
			//	Console.WriteLine(employee.Key + ": " + employee.Value);
			//}

			// Hashtable
			Hashtable employees = new Hashtable()
			{
				{1, "VHPH" },
				{2, "NVK" },
				{"Hello", 5 },
			};
			//foreach(var item in employees.Keys)
			//{
			//	Console.WriteLine(item);
			//}
			//foreach(var item in employees.Values)
			//{
			//	Console.WriteLine(item);
			//}

			foreach(DictionaryEntry employee in employees)
			{
				Console.WriteLine(employee.Key + ": " + employee.Value);
			}
		}

	}
}
