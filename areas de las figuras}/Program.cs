using areas_de_las_figuras_;

Console.WriteLine("of which figure do you want to know the area  (1) square   (2) triangle  (3) exit  ");
int r = int.Parse(Console.ReadLine());

while (r != 3)
{


    //triangule
    basee s1 = new basee(4);

    //square
    height s2 = new height (5, 6);



    if (r == 1)
    {
        basee.PrintMessage();
        Console.WriteLine(s1.Getarea(s1));
        Console.WriteLine(s1.ToString());
        Console.ReadLine();
        Console.Clear();

    }
    else if (r == 2)
    {
        height.PrintMessage();
        Console.WriteLine(s2.Getarea(s2));
        Console.WriteLine(s2.ToString());
        Console.ReadLine();
        Console.Clear();
    }


    Console.WriteLine("of which figure do you want to know the area  (1) square   (2) triangle  (3) exit  ");
    r = int.Parse(Console.ReadLine());

}



