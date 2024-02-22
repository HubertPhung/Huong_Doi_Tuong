
Console.WriteLine("\n\n \t\t\t\t\t\t\tLIST UPGRADE\n\n");
//auto fill
int temp;
List<int> mang = new List<int>();
Console.Write("import length of array: ");
int n = int.Parse(Console.ReadLine());
RandomFill(mang, n);
//auto fill
printer(mang);


//remove elements
printer(mang);
Console.Write("\nfill in a value to be removed: ");
int vt = int.Parse(Console.ReadLine());
Console.WriteLine("\n\n\nafter remove elements: :  ");
List<int> remove = RemoveElements(mang, vt);
temp = 0;
foreach (int item in remove)
{
    Console.Write(item + "\t");
    temp++;
    if (temp % 11 == 0)
        Console.WriteLine();
}



//remove the first element
printer(mang);
Console.WriteLine("\n\n\nafter Remove the first elements:  ");
List<int> thefirstelements = RemoveTheFirstElements(mang);
temp = 0;
foreach (int item in thefirstelements)
{

    Console.Write(item + "\t");
    temp++;
    if (temp % 11 == 0)
        Console.WriteLine();
}


//remove the last element
printer(mang);
Console.WriteLine("\n\n\nafter Remove the last elements:  ");
List<int> thelasttelements = RemoveTheLastElements(mang);
temp = 0;
foreach (int item in thelasttelements)
{
    Console.Write(item + "\t");
    temp++;
    if (temp % 11 == 0)
        Console.WriteLine();
}


//remove all list
printer(mang);
Console.WriteLine("\n\n\nafter Remove All elements:  ");
List<int> removeall = RemoveAlltElements(mang);
foreach (int item in removeall)
{
    Console.Write(item + "\t");
}


//remove all elements greater than x
printer(mang);
Console.Write("\n\n\nfill in a element to Remove elements greater than x:  ");
int greaterthanx = int.Parse(Console.ReadLine());
List<int> greater = RemoveElementsGreaterThan2(mang, greaterthanx);
Console.WriteLine("\n\n\nafter Remove elements greater than x:  ");
temp = 0;
foreach (int item in greater)
{
    Console.Write(item + "\t");
    temp++;
    if (temp % 11 == 0)
        Console.WriteLine();
}


//remove all positive numberss
printer(mang);
Console.WriteLine("\n\n\nafter Remove all positive numbers:  ");
List<int> positivenumbers = RemoveAllThePositiveNumbers(mang);
temp = 0;
foreach (int item in positivenumbers)
{
    Console.Write(item + "\t");
    temp++;
    if (temp % 11 == 0)
        Console.WriteLine();
}



//remove all the even numberss
printer(mang);
Console.WriteLine("\n\n\nafter Remove all the even numbers:  ");
List<int> evennumber = RemoveAllTheEvenNumbers(mang);
temp = 0;
foreach (int item in evennumber)
{
    Console.Write(item + "\t");
    temp++;
    if (temp % 11 == 0)
        Console.WriteLine();
}

//remove all prime numbers
printer(mang);
Console.WriteLine("\n\n\nafter Remove all prime numbers:  ");
List<int> isprime = RemoveAllPrimeNumbers(mang);
temp = 0;
foreach (int item in isprime)
{
    Console.Write(item + "\t");
    temp++;
    if (temp % 11 == 0)
        Console.WriteLine();
}

//add a elements at vt in list
printer(mang);
Console.Write("\n\n\nfill in a location that added:  ");
int location = int.Parse(Console.ReadLine());
Console.Write("\n\n\nfill in a value that need to be added:  ");
int value = int.Parse(Console.ReadLine());
Console.WriteLine("\n\n\nList after replace:  ");
List<int> add = AddAElements(mang, location, value);
temp = 0;
foreach (int item in add)
{
    Console.Write(item + "\t");
    temp++;
    if (temp % 11 == 0)
        Console.WriteLine();
}


//add the first elements in the list
printer(mang);
Console.Write("\n\n\nfill in a value that need to be added in the first of list:  ");
int value1 = int.Parse(Console.ReadLine());
Console.WriteLine("\n\n\nList after replace:  ");
List<int> FirstList = AddTheFirstElements(mang, value1);
temp = 0;
foreach (int item in FirstList)
{
    Console.Write(item + "\t");
    temp++;
    if (temp % 11 == 0)
        Console.WriteLine();
}

//add the last elements in the list
printer(mang);
Console.Write("\n\n\nfill in a value that need to be added in the last of list:  ");
int lastvalue = int.Parse(Console.ReadLine());
Console.WriteLine("\n\n\nList after replace:  ");
List<int> LastList = AddTheLastElements(mang, lastvalue);
temp = 0;
foreach (int item in LastList)
{
    Console.Write(item + "\t");
    temp++;
    if (temp % 11 == 0)
        Console.WriteLine();
}


//add a list of interger
printer(mang);
Console.Write("\n\n\nfill in a location that replace:  ");
int intergerlocation = int.Parse(Console.ReadLine());
Console.Write("\n\n\nfill in length of array:  ");
int length = int.Parse(Console.ReadLine());
List<int> inputarray = new List<int>();
for (int i = 1; i <= length; i++)
{
    Console.Write("value of array " + i + ":  ");
    inputarray.Add(int.Parse(Console.ReadLine()));
}

Console.WriteLine("\n\n\nList after replace:  ");
List<int> addarray = AddAListOfInterger(mang, intergerlocation, inputarray);
temp = 0;
foreach (int item in addarray)
{
    Console.Write(item + "\t");
    temp++;
    if (temp % 11 == 0)
        Console.WriteLine();
}


//add the first of list
printer(mang);
Console.Write("\n\n\nfill in length of array to replace at the first of list:  ");
int length1 = int.Parse(Console.ReadLine());
List<int> first = new List<int>();
for (int i = 1; i <= length1; i++)
{
    Console.Write("value of array " + i + ":  ");
    first.Add(int.Parse(Console.ReadLine()));
}
Console.WriteLine("\n\n\nList after replace:  ");
List<int> firstoflist = AddTheFirstOfList(mang, first);
temp = 0;
foreach (int item in firstoflist)
{
    Console.Write(item + "\t");
    temp++;
    if (temp % 11 == 0)
        Console.WriteLine();
}


//add the last of list
printer(mang);
Console.Write("\n\n\nfill in length of array:  ");
int length2 = int.Parse(Console.ReadLine());
Console.Write("\n\n\nfill in a array that need to be added to replace at the last of list:  ");
List<int> last = new List<int>();
for (int i = 1; i <= length2; i++)
{
    Console.Write("value of array " + i + ":  ");
    last.Add(int.Parse(Console.ReadLine()));
}
Console.WriteLine("\n\n\nList after replace:  ");
List<int> lastoflist = AddTheLastOfList(mang, last);
temp = 0;
foreach (int item in lastoflist)
{
    Console.Write(item + "\t");
    temp++;
    if (temp % 11 == 0)
        Console.WriteLine();
}

//reverse array
printer(mang);
List<int> reverse = ReverseArray(mang);
Console.WriteLine("\n\n\nList after reverse:  ");
temp = 0;
foreach (int item in reverse)
{
    Console.Write(item + "\t");
    temp++;
    if (temp % 11 == 0)
        Console.WriteLine();
}


//replace x to y
printer(mang);
Console.Write("\n\n\nfill in x that replace:  ");
int x = int.Parse(Console.ReadLine());
Console.Write("\n\n\nfill in y that replace:  ");
int y = int.Parse(Console.ReadLine());
List<int> replace = ReplaceElements(mang, x, y);
Console.WriteLine("\n\n\nList after replace:  ");
temp = 0;
foreach (int item in replace)
{
    Console.Write(item + "\t");
    temp++;
    if (temp % 11 == 0)
        Console.WriteLine();
}

///////////////////////////////////////////////////////////////
static void RandomFill(List<int> mang, int n)
{

    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        mang.Add(random.Next(-100, 101));
    }
}

static void printer(List<int> mang)
{
    Console.Write("\n------------------------------------------------------------------------");
    Console.WriteLine("\n\nTHIS ISTHE ARRAY");
    int temp = 0;
    List<int> array = new List<int>(mang);
    foreach (int item in array)
    {
        Console.Write(item + "\t");
        temp++;
        if (temp % 11 == 0)
        {
            Console.Write("\n");
        }
    }
    Console.Write("\n------------------------------------------------------------------------\n");
}

static List<int> RemoveElements(List<int> mang, int vt)
{
    List<int> array = new List<int>(mang);
    array.Remove(vt);
    return array;
}

static List<int> RemoveTheFirstElements(List<int> mang)
{
    List<int> array = new List<int>(mang);
    array.RemoveAt(0);
    return array;
}

static List<int> RemoveTheLastElements(List<int> mang)
{
    List<int> array = new List<int>(mang);
    array.RemoveAt(array.Count - 1);
    return array;
}

static List<int> RemoveAlltElements(List<int> mang)
{
    List<int> array = new List<int>(mang);
    array.Clear();
    return array;
}

static List<int> RemoveElementsGreaterThan2(List<int> mang, int greater)
{
    List<int> array = new List<int>(mang);
    array.RemoveAll(x => x > greater);
    return array;
}

static List<int> RemoveAllThePositiveNumbers(List<int> mang)
{
    List<int> array = new List<int>(mang);
    array.RemoveAll(x => x > 0);
    return array;
}

static List<int> RemoveAllTheEvenNumbers(List<int> mang)
{
    List<int> array = new List<int>(mang);
    array.RemoveAll(x => x % 2 == 0);
    return array;
}

static bool IsPrime(int prime)
{
    if (prime <= 1)
        return false;
    if (prime <= 3)
        return true;
    if (prime % 2 == 0)
        return false;
    int i = 5;
    while (i * i <= prime)
    {
        if (prime % i == 0 || prime % (i + 2) == 0)
            return false;
        i += 6;
    }
    return true;
}

static List<int> RemoveAllPrimeNumbers(List<int> mang)
{
    List<int> array = new List<int>(mang);
    array.RemoveAll(IsPrime);
    return array;
}

static List<int> AddAElements(List<int> mang, int vt, int addelement)
{
    List<int> array = new List<int>(mang);
    array.Insert(vt, addelement);
    return array;
}

static List<int> AddTheFirstElements(List<int> mang, int addelement)
{
    List<int> array = new List<int>(mang);
    array.Insert(0, addelement);
    return array;
}

static List<int> AddTheLastElements(List<int> mang, int addelement)
{
    List<int> array = new List<int>(mang);
    array.Insert(array.Count, addelement);
    return array;
}

static List<int> AddAListOfInterger(List<int> mang, int location, List<int> inputarray)
{
    List<int> array = new List<int>(mang);
    array.InsertRange(location, inputarray);
    return array;
}


static List<int> AddTheFirstOfList(List<int> mang, List<int> inputarray)
{
    List<int> array = new List<int>(mang);
    array.InsertRange(0, inputarray);
    return array;
}

static List<int> AddTheLastOfList(List<int> mang, List<int> inputarray)
{
    List<int> array = new List<int>(mang);
    array.InsertRange(array.Count - 1, inputarray);
    return array;
}

static List<int> ReverseArray(List<int> mang)
{
    List<int> array = new List<int>(mang);
    array.Reverse();
    return array;
}


static List<int> ReplaceElements(List<int> mang, int x, int y)
{
    List<int> array = new List<int>(mang);
    for (int i = 0; i < array.Count; i++)
    {
        if (array[i] == x)
        {
            array[i] = y;
        }
    }
    return array;
}