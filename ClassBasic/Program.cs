using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Math
    {

    }
    internal class Program234
    {
        static void Main(string[] args)
        {
            //Math.abs(-3);

            OtherClass oc = new OtherClass();

            Console.WriteLine("Hello World!");


            List<Student> list = new List<Student>()
            {
                new Student() {name="김무명", grade=1},
                new Student() {name="이무명", grade=2},
                new Student() {name="박무명", grade=3},
                new Student() {name="최무명", grade=4},
                new Student() {name="서무명", grade=1},
                new Student() {name="양무명", grade=2}
            };
            /*Student s = new Student ();
            s.name = "무명";
            s.grade = 1;
            list.Add (s);*/

            //list.Add(new Student() { name="무명", grade=1});
            //list.Add(new Student() { grade = 1, name ="무명"});

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");
            /*
                        foreach (var item in list)
                        {
                            if (item.grade > 1)
                            {
                                list.Remove(item);
                            }
                        }
            */
            /*
            for (int i =0; i < list.Count; i++)
            {
                if (list[i].grade > 1)
                {
                    list.Remove(list[i]);
                } 
            } //밀림 // 역FOR문으로 해결할 수 있음
            */
            for(int i = list.Count-1; i >= 0;i--)
            {
                if (list[i].grade > 1)
                {
                    list.Remove(list[i]);
                }
            }
            
            foreach (var item in list) 
            {
                Console.WriteLine(item);
            }
        }
    }
}