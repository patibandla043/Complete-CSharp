using System;
class StrMethod{
    public static void Main(){
        int[] a={1,2,3,4,5,34,21,23};
        Console.WriteLine(a);
        Console.WriteLine("before clear:"+string.Join(",",a));
        Array.Clear(a,2,4);
        Console.WriteLine("after clear"+string.Join(",",a));
        int[] b = new int[3];
        Array.Copy(a,b,3);
        Console.WriteLine("Copied Array:"+string.Join(",",b));
        int[] c = new int[9];
        a.CopyTo(c,0);
        Console.WriteLine("Copyto Array:"+string.Join(",",c));
        int[] d={7,3,8,1,4,2,3,5};
        Console.WriteLine("first occurrence:"+Array.IndexOf(d,3));
        Console.WriteLine("last occurrence:"+Array.LastIndexOf(d,3));
        Array.Sort(d);
        Console.WriteLine("sorted:"+string.Join(",",d));
        Array.Resize(ref d,10);
        Console.WriteLine("resize:"+string.Join(",",d));
        Array.Reverse(d);
        Console.WriteLine("reverse:"+string.Join(",",d));
        Console.WriteLine("finding:"+Array.Find(d,element=>element>4));//finding a number which is bigger than the given number
        Console.WriteLine("finding:"+string.Join(",",Array.FindAll(d,element=>element>4)));
        Console.WriteLine("elements in the array");
        Array.ForEach(d,element=>Console.WriteLine(element));
        Console.WriteLine("dose 5 exist in arr:"+Array.Exists(d,elements=>elements==5));
        Console.WriteLine("dose elements are greater than 5:"+Array.TrueForAll(d,elements=>elements>=5));
    }
}