using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudConsoleLibrary;

namespace Console_CRUD
{
   public  class Schoolreposconsume
    {
        SchoolRepostery reposting;
        public  Schoolreposconsume()
        {
            reposting = new SchoolRepostery();
        }
        public void Menudriven()
        {
            int option;
            do
            {
                Console.WriteLine("choose the any one option--->");
                Console.WriteLine("1.userinput");
                Console.WriteLine("2.UpdateData");
                Console.WriteLine("3.ShowAllData");
                Console.WriteLine("4.Delete");
                Console.WriteLine("5.Exit");

                Console.WriteLine("Enter the option");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        userinput();
                        break;
                    case 2:
                        UpdateData();
                        break;
                    case 3:
                        ShowAllData();
                        break;
                    case 4:
                        Delete();
                        break;
                }
            }
            while (option != 5);
        }
            public void userinput()
            {
                SchoolDetails repost = new SchoolDetails();
                Console.WriteLine("Enter the SchoolName");
                repost.SchoolName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the ContactNO");
                repost.ContactNo = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter the Email");
                repost.Email = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the Address");
                repost.Address = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the pincode");
                repost.Pincode = Convert.ToInt64(Console.ReadLine());

                reposting.SchoolLogin(repost);
            }
            public void UpdateData()
            {

            }
            public void ShowAllData()
            {

            }
            public void Delete()
            {

            }

        
    }
}
