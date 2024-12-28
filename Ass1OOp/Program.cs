using Assignment;

namespace Ass1OOp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question 01

            //WeekDays weekDays;

            //for (int i = 0; i < 7; i++)
            //{
            //    weekDays = (WeekDays)i;
            //    Console.WriteLine(weekDays);
            //}

            #endregion


            #region Question 02

            //Seas_on season;

            //Console.Write("Enter Your Season: ");
            //Enum.TryParse<Seas_on>(Console.ReadLine(), out season);

            //if (season == Seas_on.Spring)
            //    Console.WriteLine($"Month Range is: March to May");

            //else if (season == Seas_on.Summer)
            //    Console.WriteLine($"Month Range is: June to August");

            //else if (season == Seas_on.Autumn)
            //    Console.WriteLine($"Month Range is: September to November");

            //else if (season == Seas_on.Winter)
            //    Console.WriteLine($"Month Range is: December to February");

            //else
            //    Console.WriteLine("Wrong Season");

            #endregion

            #region Question 03

            //Permissions P1= Permissions.Write;

            //// Add Permission
            //P1 |= Permissions.Read;

            //// Remove Permission
            //P1 &= ~(Permissions.Read);

            //// Check Permission
            //bool isExist;

            //isExist = ((P1 & Permissions.Execute) == Permissions.Execute) ? true : false;

            //Console.WriteLine(isExist);

            #endregion


            #region Question 04

            //Console.Write("Enter your Color: ");
            //string? color=Console.ReadLine();

            //Colors col;

            //Enum.TryParse<Colors>(color, out col);

            //if(col != 0)
            //    Console.Write("Primary Color ");
            //else
            //    Console.Write("Not a Primary Color ");

            #endregion
        }
    }
}
