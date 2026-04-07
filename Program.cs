using System.Xml.Schema;

namespace Class_0407_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Person p1=new Person(123,"我改過的名字");
            Console.WriteLine(p.name.ToString());
            Console.WriteLine(p1.name.ToString());
            student s1=new student(143,"a名字",100);
            Console.WriteLine(s1.name.ToString());
            Console.WriteLine(s1.studentInfo());
        }
    }


    class Person
    {
        public string name;
        public int id;
        

        public Person()
        {
            name = "預設名字";
        }
        public Person(int id,string name)
        {
            id = id;
            this.name=name;
        }
        public string Info()
        {
            return "person的Info編號:" + id + "姓名:" + name;
        }
    }
    

    class student : Person 
    {
        private int score;
        //static string name = "base帶入的參數必須要是子類別,不然就帶入或欄位";
        public student(int id,string name, int score): base(id,name)
        {
            score = score;
        }
        public int Grade
        {
            get
            {
                return score;
            }
        }
        public string studentInfo()
        {
            return "學生的新方法";
        }
        public string Info()
        {
            return "學生類別自己的Info";
        }
    }





}
