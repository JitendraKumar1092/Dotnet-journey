// See https://aka.ms/new-console-template for more information
// list
using System.Collections;

class CollectionsDemo
{

    public static void Main(string[] args)
    {
        //         // List<int> ls = new List<int>();
        //         List<string> sl = new List<string>();
        //         sl.Add("Python");
        //         sl.Add("Java");
        //         sl.Insert(1, "c#");
        //         // for (int i = 0; i < 10; i++)
        //         // {
        //         //     ls.Add(i);
        //         // }
        //         for (int i = 0; i < sl.Count; i++)
        //         {
        //             Console.WriteLine(sl[i]);
        //         }

        //         string[] arr = sl.ToArray();
        //         foreach (var i in arr)
        //             Console.WriteLine("{0}", i);
        //  ArrayList student = new ArrayList();
        //  student.Add(5);
        //  student.Add("heheh");
        //  foreach(var i in student)
        //  Console.WriteLine("{0}" ,i);
        stk obj = new stk();
        // obj.stackDemo();
        QueueDemo demo = new QueueDemo();
        // demo.queueDemo();

        HT hst = new HT();
        // hst.ht();
        Files fl = new Files();
        fl.Filehandling();

    }
}
