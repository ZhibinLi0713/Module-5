using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLEncoder
{
    class Program
    {
        static bool repeat = true;
        static void Main(string[] args)
        {
            while (repeat == true)
            {
                string project_name = " ";
                string activity_name = " ";
                

                try
                {
                    Console.WriteLine("Enter the prject name： ");
                    project_name = Console.ReadLine();


                    Console.WriteLine("Enter the activity name： ");
                    activity_name = Console.ReadLine();

                    string url = "https://companyserver.com/content/" + project_name + "/files/" + activity_name + "/" + activity_name + "Report.pdf";

                    Console.WriteLine("\n");
                    Console.WriteLine(url);
                }
                catch
                {
                    Console.WriteLine("PLease enter vaild project and activity name.");
                }
                Console.WriteLine("\n");
                Console.WriteLine("Do you want another URL to encode? Enter N for quit.");
                char rp = Convert.ToChar(Console.ReadLine());
                if (rp == 'N')
                {
                    repeat = false ;
                }
            }
        }
    }
}
