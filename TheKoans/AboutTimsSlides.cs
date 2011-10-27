using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KoanHelpers;

namespace TheKoans
{
    public class AboutTimsSlides
    {
        public static void Run()
        {
            Program program = new Program();
            //helloWorld(args);
            //program.readKey();
            //program.arrays();
            //program.controlStructures();
            //program.classes();
            //program.useGetterAndSetter();
            //program.useIndexer();
            program.parameters();

        }
    }
    class A {
    public int field = 5;
    }
    class B : A { }
    public interface NamedItem
    {
        // Property declaration
        string Name
        {
            get;
        }

        // Method declaration
        int getLections();
    }

    class Student : NamedItem
    {
        private string _firstName = "";
        private string _lastname = "";

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (value.Length < 5)
                    throw new ArgumentException();
                _firstName = value;
            }
        }

        public string Name
        {
            get
            {
                return _firstName + " " + _lastname;
            }
        }
        public int getLections() { return 0; }
    }
    public class Student2
    {
        private double _grade; 
        string[] lessons = new string[10];
        public string this[uint index]
        {
            get
            {
                if (index < 0 || index >= lessons.Length)
                    throw new ArgumentOutOfRangeException();
                return lessons[index];
            }
            set
            {
                if (index < 0 || index >= lessons.Length)
                    throw new ArgumentOutOfRangeException();
                lessons[index] = value;
            }
        }
         public void addGrade(Grade grade) {
            grade.Date = DateTime.Now;
            
        }
         public void modifyGrade(double grade) {
             _grade = grade;
             grade = 1.3; //
         }
         public void modifyGrade(ref double grade)
         {
             _grade = grade;
             grade = 0.0; //
         }
    }
    class TimePeriod
    {
        private double _seconds;
        public double Seconds
        {
            get { return _seconds; }
            set { _seconds = value; }
        }
    }
   public class Grade {
        private double _grade = 0;
        private string _class = "";
        private DateTime _date ;
        public double TheGrade {
            get {return _grade;}
            set {_grade = value;}
        }
        public string Clazz {
            get {return _class;}
            set {_class = value;}
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public Grade(double grade, string clazz) {
            _grade = grade;
            _class = clazz;
            _date = new DateTime(2010, 1, 18);
        }

        
    }

    class Program
    {
          static public void helloWorld(string[] args)
        {
            Console.Out.WriteLine("Hallo");
            for (int i = 0; i < args.Length; i++)
            {
                Console.Out.WriteLine("argument no" + i + ": " + args[i]);
            }
          
        }
        public void controlStructures() {
            int j = 3;
            // Control Structures
            if (j == 3)
            {
                Console.Out.WriteLine("j == 3 is true");
            }
        }
        public void arrays() {
            int length = 33;
            int[] values = new int[length];
            for (int i = 0; i < length; i++) { 
                values[i] = i;
            } 
             for (int i = 0; i < length; i++) 
           
            Console.Out.WriteLine(values[i]);
        }
        public void types()
        {
        }
        public void classes() {
            A a = new A();
            B b = new B();
            Console.Out.WriteLine("b.field: "+b.field);
        }


        public void useGetterAndSetter()
        {
            Student student = new Student();
            student.FirstName = "Barbara";
            Console.Out.WriteLine("student.Name: "+student.Name);
        }
        public void useIndexer(){
            Student2 student = new Student2();
            student[0] = "Programming";
            student[1] = "Ruby on Rails";
            Console.Out.WriteLine("second class: "+student[1]);
        }
        public void parameters() {
            Student2 student = new Student2();
            // call by value 
            double simpleGrade = 3.2;
            student.modifyGrade(simpleGrade);
            Assert.assertThat("simpleGrade should still be the same", simpleGrade == 3.2);
            student.modifyGrade(ref simpleGrade);
            Assert.assertThat("simpleGrade has now changed",simpleGrade == 0.0);
            Grade grade = new Grade(1.3, "programming");
            DateTime dateTimeBefore = grade.Date;
            student.addGrade(grade);
            Assert.assertThat("the date in grade has changed", grade.Date != dateTimeBefore);
        }
        public void readKey() {
            char c = Console.ReadKey().KeyChar;
            Console.Out.WriteLine("\nread: " + c);
        }
       
    }
}
