using System.Collections;
class HT
{
    public void ht()
    {
        // create a hashtable
        Hashtable myTable = new Hashtable();
        myTable.Add("name", "jeet");
        myTable.Add("Roll", 90);
        myTable.Add(1, 2);
        foreach (var i in myTable.Keys)
        {
            Console.WriteLine($"key : {i} , Value {myTable[i]}");
        }
        foreach (DictionaryEntry obj in myTable)
        {
            Console.WriteLine($"{obj.Key}  {obj.Value}");
        }
    }
}