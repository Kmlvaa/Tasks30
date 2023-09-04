using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;

namespace Tasks30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] a = ints.Where(x=> x%2==0).ToArray();
            //var x = 
            //        from n in ints 
            //        where n % 2 == 0
            //        select n;
            //foreach(var i in x)
            //{
            //    Console.Write(i + " ");
            //} 

            //Task 2
            //int[] ints = { 1, -2, -3, 6, -12, 23, -23, 4, 12 };
            //var x = from n in ints
            //        where n > 0
            //        where n <= 11
            //        select n;
            //foreach(var i in x)
            //{
            //    Console.Write(i + " ");
            //}

            //Task 3
            //int[] ints = { 3, 5, 8, 7, 9 };
            //var x = from num in ints
            //        let square = num * num
            //        select new{ num, square };
            //foreach (var i in x)
            //{
            //    Console.WriteLine(i);
            //}

            //Task 4
            //int[] ints = { 3, 5, 7, 8, 8, 7 ,3, 9, 8 };
            //var x = from num in ints 
            //        group num by num into y
            //        select y;
            //foreach (var i in x)
            //{
            //    Console.WriteLine($"Number {i.Key} appears {i.Count()} times");
            //}

            //Task 5
            //string st = "hello";
            //var x = from chars in st
            //        group chars by chars into numOfChars
            //        select numOfChars;
            //foreach (var i in x)
            //{
            //    Console.WriteLine($"Character {i.Key}: {i.Count()} times");
            //}
            //Task 6
            //string[] weekdays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            //var x = from day in weekdays
            //        select day; 
            //foreach (var day in weekdays)
            //{
            //    Console.WriteLine(day);
            //}

            //Task 7
            //int[] ints = { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
            //var x = from num in ints
            //        group num by num into y
            //        select y;
            //foreach (var i in x)
            //{
            //    Console.WriteLine($"N: {i.Key}   N*F:{i.Key * i.Count()}   F: {i.Count()}");
            //}

            //Task 8
            //string[] st = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "EW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            //char start = char.Parse(Console.ReadLine()!);
            //string startwith = start.ToString().ToUpper();
            //char end = char.Parse(Console.ReadLine()!);
            //string endwith = end.ToString().ToUpper();
            //var chars = from ch in st
            //            where ch.StartsWith(startwith)
            //            where ch.EndsWith(endwith)
            //            select ch;
            //foreach (var ch in chars)
            //{
            //    Console.WriteLine($"The city starting with {startwith} and ending with {endwith} is: {ch}");
            //}

            //Task 9
            //List<int> list = new List<int> { 55, 200, 740, 76, 230, 482, 95 };

            //List<int> newList = list.FindAll(x => x > 80);
            //Console.WriteLine("The numbers greater than 80 are: ");
            //foreach (var num in newList)
            //{
            //    Console.WriteLine(num);
            //}

            //task 10
            //List<int> list = new List<int>();
            //Console.Write("Input the number of members on the List: ");
            //int nums = int.Parse(Console.ReadLine()!);
            //for (int i = 0; i < nums; i++)
            //{
            //    Console.Write($"Member {i}: ");
            //    int num = int.Parse(Console.ReadLine()!);
            //    list.Add(num);
            //}
            //Console.Write("Input the value above you want to display the members of the List: ");
            //int value = int.Parse(Console.ReadLine()!);
            //List<int> newlist = list.FindAll(x => x > value);
            //Console.WriteLine($"The numbers greater than {value} are: ");
            //foreach (var n in newlist)
            //{
            //    Console.WriteLine(n);
            //}

            //Task 11
            // Console.Write("Input the member count: ");
            // int num = int.Parse(Console.ReadLine()!);

            // List<int> list = new List<int>();
            // Console.WriteLine("The members of the list are: ");
            // for (int i = 0; i < num; i++)
            // {
            //     int member = Convert.ToInt32(Console.ReadLine());
            //     list.Add(member);
            // }
            // Console.Write("How many records you want to display? : ");
            // int displayCount = int.Parse(Console.ReadLine()!);

            // List<int> newList = list.OrderByDescending(x => x).ToList();

            // Console.WriteLine("The top 3 records from the list are: ");
            //foreach (int item in newList.Take(displayCount))
            // {
            //     Console.WriteLine(item);
            // }

            //Task 12
            //Console.Write("Input the string: ");
            //string str= Console.ReadLine()!;

            //string[] split = str.Split(" ");
            //var upperCase = split.Where(x => string.Equals(x,x.ToUpper(), StringComparison.Ordinal));

            //Console.WriteLine("The UPPER CASE words are: ");
            //foreach (var x in upperCase)
            //{
            //    Console.WriteLine(x);
            //}

            //Task 13
            //Console.Write("Input number of strings to store in the array: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();
            //string[] arr = new string[num];
            //Console.WriteLine($"Input {num} strings for the array: ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Element[{i}]: ");
            //    arr[i] = Console.ReadLine()!;
            //}
            //Console.WriteLine();
            //Console.WriteLine("Here is the string below created with elements of the above array: ");
            //string str = string.Join(", ", arr); 
            //Console.WriteLine(str);

            //Task 15
            //Console.WriteLine("The files are: ");
            //string[] strings = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };
            //Console.WriteLine("Here is the group of extension of the files: ");
            //var group = strings.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
            //         .GroupBy(z => z, (ext, count) => new
            //         {
            //             Extension = ext,
            //             Count = count.Count()
            //         });
            //foreach (var st in group)
            //{
            //    Console.WriteLine($"{st.Count} File(s) with {st.Extension}Extension");
            //}

            //Task 16
            //string[] files = Directory.GetFiles("C:\\Users\\User\\Desktop\\Banksistem");
            //var fileSize = files.Select(file => new FileInfo(file).Length).Average();

            //fileSize = Math.Round(fileSize / 10, 1);
            //Console.WriteLine($"The Average file size is {fileSize} MB");

            //Task 17
            //List<string> chars = new List<string> { "m","o","n","g","o" };
            //Console.WriteLine("Here is the list of items: ");
            //foreach (var c in chars) Console.WriteLine("Char: " + c);
            //string ch = Console.ReadLine()!;
            //string value = chars.FirstOrDefault(x => x == ch);
            //chars.Remove(value);
            //Console.WriteLine("Here is the list after removing the item 'o' from the list: ");
            //foreach (var c in chars) Console.WriteLine("Char: " + c);

            //Task1 18
            //List<string> chars = new List<string> { "m", "o", "n", "g", "s" };
            //Console.WriteLine("Here is the list of items: ");
            //foreach (var c in chars) Console.WriteLine("Char: " + c);
            //Console.Write("Enter char: ");
            //string ch = Console.ReadLine()!;
            //chars.Remove(chars.FirstOrDefault(x => x == ch)!);
            //Console.WriteLine($"Here is the list after removing the item {ch} from the list: ");
            //foreach (var c in chars) Console.WriteLine("Char: " + c);

            //Task 19
            //List<string> list = new List<string> { "a","b","c","a","d","a"};
            //Console.WriteLine("Here is the list of items: ");
            //foreach (var c in list) Console.WriteLine("Char: " + c);
            //Console.Write("Enter char: ");
            //string ch = Console.ReadLine()!;
            //list.RemoveAll(c => c == ch);
            //Console.WriteLine($"Here is the list after removing the item {ch} from the list: ");
            //foreach (var c in list) Console.WriteLine("Char: " + c);

            //Task 20
            //List<string> list = new List<string> { "a", "b", "c", "a", "d", "a" };
            //Console.WriteLine("Here is the list of items: ");
            //foreach (var c in list) Console.WriteLine("Char: " + c);
            //Console.Write("Enter char: ");
            //string ch = Console.ReadLine()!;
            //int index = list.IndexOf(ch);
            //list.RemoveAt(index);
            //Console.WriteLine($"Here is the list after removing item index {ch} from the list: ");
            //foreach (var c in list) Console.WriteLine("Char: " + c);

            //Task 21
            //List<string> list = new List<string> { "a", "b", "c", "a", "d", "a" };
            //Console.WriteLine("Here is the list of items: ");
            //foreach (var c in list) Console.WriteLine("Char: " + c);
            //Console.Write("Enter item index to start with: ");
            //int index = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter count of items you want to remove: ");
            //int count = Convert.ToInt32(Console.ReadLine());
            //list.RemoveRange(index, count);

            //Console.WriteLine($"Here is the list after removing the {count} items starting from the item index {index} from the list: ");
            //foreach (var c in list) Console.WriteLine("Char: " + c);

            //Task 22
            //Console.WriteLine("Input number of strings to store in the array: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //string[] arr = new string[num];
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Element[{i}]: ");
            //    string str = Console.ReadLine()!;
            //    arr[i] = str;
            //}
            //Console.Write("Input the minimum length of the item you want to find: ");
            //int min = Convert.ToInt32(Console.ReadLine());
            //var stArr = arr.Where(m => m.Length >= min).ToArray();
            //Console.WriteLine($"The items of minimum {min} characters are: "); 
            //foreach(var i in stArr)
            //{
            //    Console.WriteLine(i);
            //}

            //Task 23
            //string[] strings = { "X", "Y" };
            //int[] ints = { 1, 2, 3, 4, 5 };
            //var cartesian = from str in strings
            //                from integer in ints
            //                select new { str, integer };
            //foreach (var c in cartesian)
            //{
            //    Console.WriteLine(c);
            //}

            //Task 24
            //string[] strings = { "X", "Y" };
            //int[] ints = { 1, 2 };
            //string[] colors = { "Green", "Orange" };
            //var cartesian = strings.SelectMany(x => ints.SelectMany(y => colors.Select(z => x + " - " + y + " - " + z)));
            //foreach (var c in cartesian)
            //{
            //    Console.WriteLine("{ " + c + " }");
            //}

            //Task 25 26 27
            // List<Item> itemlist = new List<Item>
            // {
            //new Item { ItemId = 1, Name = "Biscuit  " },
            //new Item { ItemId = 2, Name = "Chocolate" },
            //new Item { ItemId = 3, Name = "Butter   " },
            //new Item { ItemId = 4, Name = "Brade    " },
            //new Item { ItemId = 5, Name = "Honey    " }
            // };

            // List<Purchase> purchlist = new List<Purchase>
            // {
            //new Purchase {  Id = 3,  Quantity = 800 },
            //new Purchase {  Id = 2,  Quantity = 650 },
            //new Purchase {  Id = 3,  Quantity = 900 },
            //new Purchase {  Id = 4,  Quantity = 700 },
            //new Purchase {  Id = 3,  Quantity = 900 },
            //new Purchase {  Id = 4,  Quantity = 650 },
            //new Purchase {  Id = 1,  Quantity = 458 }
            // };
            // Console.WriteLine("Here is the list after joining: ");

            //var innerJoin = from item in itemlist
            //                join purch in purchlist on item.ItemId equals purch.Id
            //                select new
            //                {
            //                    id = item.ItemId,
            //                    name = item.Name,
            //                    quantity = purch.Quantity
            //                };
            // TASK 26
            //var innerJoin = from item in itemlist
            //                join purch in purchlist on item.ItemId equals purch.Id
            //                into a
            //                from b in a.DefaultIfEmpty(new Purchase())
            //                select new
            //                {
            //                    id = item.ItemId,
            //                    name = item.Name,
            //                    quantity = b.Quantity
            //                };
            //TASK 27
            //var innerJoin = from purch in purchlist
            //                join item in itemlist on purch.Id equals item.ItemId
            //                into a from b in a.DefaultIfEmpty()
            //                select new
            //                {
            //                    id = b.ItemId,
            //                    name = b.Name,
            //                    quantity = purch.Quantity
            //                };
            //Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
            //Console.WriteLine("-------------------------------------------------");
            //foreach (var data in innerJoin)
            //{
            //    Console.WriteLine(data.id + "\t\t" + data.name + "\t\t" + data.quantity);
            //}

            //Task 28
            //string[] list = { "PARIS","ROME","lONDON","ZURICH","ABU DHABI","NAIROBI","AMSTERDAM","NEW DEHLI","CALIFORNIA"};

            //var arr = list.OrderBy(a => a.Length).ThenBy(x => x);
            //foreach( var i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            //Task 30
            //List<Item> list = new List<Item>
            //{
            //    new Item() {ItemId = 1, Name = "Bisquit"},
            //    new Item() {ItemId = 2, Name = "Honey"},
            //    new Item() {ItemId = 3, Name = "Butter"},
            //    new Item() {ItemId = 4, Name = "Brade"},
            //    new Item() {ItemId = 5, Name = "Honey"},
            //    new Item() {ItemId = 6, Name = "Bisquit"}
            //};
            //var list2 = from item in list
            //             select item.Name;
            //list2 = list2.Distinct().OrderBy(x => x);
            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
    public class Item
        {
            public int ItemId { get; set; }
            public string Name { get; set; }
        }
        public class Purchase
        {
            public int Id { get; set; }
            public int Quantity { get; set; }
        }
}