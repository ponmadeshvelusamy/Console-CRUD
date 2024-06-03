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
        SchoolDetails obj = new SchoolDetails();
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
                Console.WriteLine("1.Schoolsignup");
                Console.WriteLine("2.ShowAllData");
                Console.WriteLine("3.UserEdit");
                Console.WriteLine("4.Delete");
                Console.WriteLine("5.Exit");

                Console.WriteLine("Enter the option");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Signup();
                        break;
                    case 2:
                        ShowAllData();
                        break;
                    case 3:
                        UserEdit();
                        break;
                    case 4:
                        Delete();
                        break;
                }
            }
            while (option != 5);
        }
            public void Signup()
            {
                Console.WriteLine("Enter the SchoolName");
                obj.SchoolName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the ContactNO");
                obj.ContactNo = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter the Email");
                obj.Email = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the Address");
                obj.Address = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the pincode");
                obj.Pincode = Convert.ToInt64(Console.ReadLine());

                 reposting.Schoolsignup(obj);
            }
            public void ShowAllData()
            {
            var Showall = reposting.Showall();
            if (Showall == null || Showall.Count() == 0)
            {
                Console.WriteLine("No Records Found");
                return;
            }

            Console.WriteLine($"|{"SchoolName"}    |{"ContactNo"}    |{"Email"} |{"Address"} |{"Pincode"}");

            foreach (var Datas in Showall)
            {
                Console.WriteLine($"|{Datas.SchoolName}       |{Datas.ContactNo}       |{Datas.Email}  |{Datas.Address} |{Datas.Pincode}");
            }
            return;


            }
        public void UserEdit()
        {
            Console.WriteLine("Enter the SchoolID");
            var newSchoolID = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the your New ContactNo");
            var NewContactNo = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the Email");
            var UserEmail = Console.ReadLine();
            reposting.EditorUpdate(newSchoolID,NewContactNo, UserEmail);


        }
        public void Delete()
            {
            Console.WriteLine("Enter the SchoolID");
            var NewSchoolID =Convert.ToInt64(Console.ReadLine());
            reposting.DeleteDetails(NewSchoolID);
        }

   }

        
}

