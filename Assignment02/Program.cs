using System.Text;

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

        #region Question07
        //static void AddBonusPagesByRef(ref int pages)
        //{
        //    pages += 50;
        //}
        #endregion

        #region Question08
        //static void ReplaceArray(ref double[] prices)
        //{
        //    prices = new double [] { 10.0, 12.5, 15.0 };

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

            #region Question07
            //int pages = 400;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine(pages);
            // pages = 450 , as this is passing by reference [value type] so the parameter of the function is a reference to the original variable
            // any changes made to the parameter inside the function affect the original variable outside the function while in Q5 they were different copies
            #endregion

            #region Question08
            //double[] prices = { 25.5, 40.0};
            //ReplaceArray(ref prices);
            //Console.WriteLine(prices.Length);
            // prices.Length = 3 , as this is passing by reference [reference type]
            // so the parameter of the function is a reference to the original variable
            #endregion

            #region Question09
            //string title = "clean code";
            //string UpperTitle = title.ToUpper();
            //Console.WriteLine($"Title : {title}");
            //Console.WriteLine($"Upper Title:{UpperTitle}");
            #endregion

            #region Question10
            //string title = "Clean Code";
            //string title_2 = "Clean Code";
            //Console.WriteLine(ReferenceEquals(title, title_2));
            #endregion

            #region Question11
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book List");
            //sb.Append(" Updated");
            //Console.WriteLine(sb.ToString());
            #endregion
        }
    }
}
