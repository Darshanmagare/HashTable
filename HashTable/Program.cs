using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
           Program obj2=new Program();
            obj2.HashTableMethod();
            Console.ReadKey();
        }
    }

    class Hashtable1
    {
        public void HashTableMethod();
        {
            HashT obj = new HashT();
            obj.Add("First","C#");
            obj.Add("Second",3);
            obj.Add("Third","C++");
            obj.Add("Fourth","Two");
            obj.Add("Fifth","One");


            Console.WriteLine("Keys and Vaules :");
            Printkeyandvalues(obj);

            Console.WriteLine("Value for key 'Second ' is  "+ obj["Second"]);

        }

    public void Printkeyandvalues(HashTable1 myList)
     {
        HashTable myEnnumnerator = mylist HashTable();
        while (myEnnumnerator.MoveNext())
        {
            Console.WriteLine("\t{0}:\t{1}", myEnnumnerator.Key, myEnnumnerator.Value);
        }
        Console.WriteLine();
      }

    
    }
}
