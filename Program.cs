using System.ComponentModel.Design;

Console.WriteLine("Alireza mohammadi");
Console.WriteLine(" che kari anjam bedam?");
Console.WriteLine("1 miyangin nomre");

Console.WriteLine("2 adad fibonachi");
Console.WriteLine("3 factoriel adad");
Console.WriteLine("4 donbale mosalasi");

int soal;
soal = Convert.ToInt32(Console.ReadLine());

if (soal == 1) 
{

    int tedad = 0;
    double nomarat = 0;
    double zarib;
    double kol = 0;
    int yesorno;
    do
    {
        Console.WriteLine("nomre dars ra vared konid");
        double nomre = Convert.ToDouble(Console.ReadLine());
        nomarat += nomre;

        Console.WriteLine("chand vahedi ast?");
        int adad = Convert.ToInt32(Console.ReadLine());
        tedad += adad;

        zarib = adad * nomre;
        kol += zarib;
        Console.WriteLine("aya mayel be edame hastin? 1bale 2 kheyr");

        yesorno = Convert.ToInt32(Console.ReadLine());


    } while (yesorno == 1);
    Console.WriteLine("miyangin shoma:");
    Console.WriteLine(kol / tedad);
    Console.WriteLine(" tamam");
}

if (soal == 2)
{
    Console.WriteLine("adad chandom fibonachi ra namayesh daham?");

    int a = 0;
    int b = 1;
    int c = 0;
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(a);
    for (int i = 0; i < n-1; i++)
    {
        c = a + b;
        a = b;
        b = c;
        Console.WriteLine(c);
    }
    Console.WriteLine(" adad mored nazar shoma:");
    Console.WriteLine(c);
    Console.WriteLine("tamam");
}


if (soal == 3)
{
    Console.WriteLine(" factoriel adad chand?");

    int z = Convert.ToInt32(Console.ReadLine());
    int y = 1;
    for (int s = 1; s<= z; s++) 
    {
        y =y * s;
        
    }
    Console.WriteLine(y);
    Console.WriteLine("tamam ");
}






if (soal == 4)
{
    Console.WriteLine(" donbale mosalasi adad chand?");
    int j = Convert.ToInt32(Console.ReadLine());
    int v = 0;
    for (int m= 1; m<= j; m++)
    {
        v = v + m;

    }
    Console.WriteLine(v);
    Console.WriteLine("tamam");



}






    










