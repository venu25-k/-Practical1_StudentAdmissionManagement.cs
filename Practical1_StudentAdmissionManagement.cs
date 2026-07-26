using System;

namespace LAB1
{
    class Student
    {
        public string name;
        public int age;
        public int phoneno;
        public string dob;
        public string flatno;        
        public string area;
        public string city;
        public int MARKS_10;
        public int Percentage_12;
        public string mail;
       
        public void studentdetails()
        {
            Console.Write("Enter Name:");
            name = Convert.ToString((Console.ReadLine()));
            Console.Write("Enter Age:");
            age = Convert.ToInt32((Console.ReadLine()));
            Console.Write("Enter StudentDOB (DD-MM-YYYY):");
            dob = Convert.ToString((Console.ReadLine()));
            Console.Write("Enter Student phone number:");
            phoneno = Convert.ToInt32((Console.ReadLine()));
            Console.Write("Enter Email Address:");
            mail = Convert.ToString((Console.ReadLine()));
            Console.Write("Enter House No:");
            flatno = Convert.ToString((Console.ReadLine()));
            Console.Write("Enter Area Name:");
            area = Convert.ToString((Console.ReadLine()));
            Console.Write("Enter City:");
            city = Convert.ToString((Console.ReadLine()));
            Console.Write("Enter SSC percentage:");
            MARKS_10 = Convert.ToInt32((Console.ReadLine()));
            Console.Write("Enter HSC percentage :");
            Percentage_12 = Convert.ToInt32((Console.ReadLine()));

        }

        public void display()
        {
            Console.WriteLine("----------Student Details----------");
            Console.Write("Name:"+ name);
            Console.WriteLine();
            Console.Write("Age:"+ age);
            Console.WriteLine();
            Console.Write("Date Of Birth:" + dob);
            Console.WriteLine();
            Console.Write("phone number:"+phoneno);
            Console.WriteLine();
            Console.WriteLine("Email:"+mail);
            Console.WriteLine();
            Console.WriteLine("Address:"+flatno+","+area+","+city);
            Console.WriteLine();
            Console.Write("10th marks:"+MARKS_10);
            Console.WriteLine();
            Console.Write("12th mpc percentage:"+Percentage_12);

        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            Student s1=new Student();
            s1.studentdetails();
            s1.display();
            Console.ReadKey();
        }
    }
}