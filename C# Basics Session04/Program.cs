namespace C__Basics_Session04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            //double[] priceArray = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(priceArray[1]);
            #endregion

            #region question 2
            //int[,] shelfCopies =
            //{
            //    {3,5 },
            //    {1,4 }
            //};
            //Console.WriteLine(shelfCopies[1, 0]);
            #endregion

            #region question 3

            //string title = "c#";
            //PrintWelcomeMessage(title);

            //void PrintWelcomeMessage(string title)
            //{
            //    Console.WriteLine($"Book title: {title}");
            //}

            #endregion

            #region question 4
            //int pages = 400;

            //AddBonusPages(pages);
            //void AddBonusPages(int pages) {
            //    pages += 50;

            //    Console.WriteLine(pages);//here it gonna be 450 coase 400+50
            //}

            //Console.WriteLine(pages); //here it gonna be 400 because we send pages by value not reference
            #endregion

            #region question 5 
            //double[] prices = { 25.5, 40.0 };

            //ApplyDiscount(ref prices);

            //void ApplyDiscount(ref double [] prices)
            //{
            //    prices[0] -= 5;
            //}
            //Console.WriteLine(prices[0]); //here it gonna be 20.5 because array is reference type 
            #endregion

            #region question 6
            //int pages = 400;

            //AddBonusPages(ref pages);
            //void AddBonusPages(ref int  pages )
            //{
            //    pages += 50;

            //}

            //Console.WriteLine(pages); //here it gonna be 450 because we send pages by ref 
            #endregion

            #region question 7
            //double[] prices = { 25.5, 40.0 };

            //ReplaceArray(ref prices);

            //void ReplaceArray(ref double[] arr)
            //{
            //    arr = new double[] { 10.0, 12.5, 15.0 };
            //}
            //Console.WriteLine(prices.Length); //here it gonna be 3 because we send array by ref and we replace it with new array

            #endregion

            #region question 8


            //bool TryGetPrice(string title, out double price)
            //{
            //    if (title == "clean code")
            //    {
            //        price = 25.5;
            //        return true;
            //    }
            //    else
            //    {
            //        price = 0;
            //        return false;
            //    }
            //}

            //if(TryGetPrice("clean code", out double price))
            //{
            //    Console.WriteLine($"Price: {price}");
            //}
            //else
            //{
            //    Console.WriteLine("Book not found.");
            //}

            #endregion

            #region question 9

            //PrintBookInfo("C#"); 
            //PrintBookInfo("Java", 200);

            //void PrintBookInfo(string title, int pages = 300)
            //{
            //    Console.WriteLine($"Book title: {title}, Pages: {pages}");
            //}
            #endregion

            #region question 10

            //PrintBookInfo(pages:200,title:"Java");

            //void PrintBookInfo(string title, int pages = 300)
            //{
            //    Console.WriteLine($"Book title: {title}, Pages: {pages}");
            //}
            #endregion

            #region question 11

            //PrintAllTitles("C#", "Java", "c++");

            //void PrintAllTitles(params string[] titles)
            //{
            //    int cnt = 1;
            //    foreach (string title in titles)
            //    {
            //        Console.WriteLine($"title {cnt}: {title}");
            //        cnt++;
            //    }  
            //}
            #endregion

        }
    }
}
