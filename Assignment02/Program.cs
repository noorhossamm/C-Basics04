namespace Assignment02
{
    internal class Program
    {
        #region Question03
        //static void PrintWelcomeMessage()
        //{
        //    Console.WriteLine("Welcome to the Library!");
        //}
        #endregion

        #region Question04
        //static void PrintBookTitle(string title)
        //{
        //    Console.WriteLine($"Book title :{title}");
        //}
        #endregion

        #region Question05
        //static void AddBonusPages(int pages)
        //{
        //    pages += 50;
        //}

        #endregion

        #region Question06
        //static void ApplyDiscount(double[] prices)
        //{
        //    prices[0] -= 5;
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Question01
            //1--------------------
            //double[] prices = {25.5 , 40.0 , 33.75};
            //Console.WriteLine(prices[1]);
            #endregion

            #region Question02
            ////2--------------------
            //int[,] shelfCopies =
            //{
            //    {3,5} ,
            //    {1,4}  
            //};
            //Console.WriteLine(shelfCopies[1, 0]);
            #endregion

            #region Question03
            //3--------------------
            //PrintWelcomeMessage();
            #endregion

            #region Question04
            //PrintBookTitle("Clean Code");
            #endregion

            #region Question05
            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages);
            // pages = 400 , as this is passing by value [value type] so parameters of function make a copy of the value and any changes made to the parameter inside the function do not affect the original variable outside the function.
            #endregion

            #region Question06
            //double[] prices = {25.5 , 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);
            // prices[0] = 20.5 , as this is passing by value [reference type]
            // different copies of value(original and parameter) but both point to the same place in heap , a change in one causes the change in the other

            #endregion
        }
    }
}
