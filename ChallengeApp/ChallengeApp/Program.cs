// My first App

//-Tablice i ich użycie

int[] grades = new int[365];
string[] dayOfWeeks = new string[7];
dayOfWeeks[0] = "Monday";
dayOfWeeks[1] = "Tuesday";
dayOfWeeks[2] = "Wednesday";
dayOfWeeks[3] = "Thursday";
dayOfWeeks[4] = "Friday";
dayOfWeeks[5] = "Saturday";
dayOfWeeks[6] = "Sunday";

//Console.WriteLine(dayOfWeeks[0]);

string[] dayOfWeeks2 = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

//Console.WriteLine(dayOfWeeks[dayOfWeeks.Count()-1]);

//-Pętla for
//-Połączenie tablic i pętli for

for (int i = 0; i < dayOfWeeks.Length; i++)
{
    //Console.WriteLine(dayOfWeeks[i]);
}

//-Listy

List<string> dayOfWeeks3 = new List<string>();
dayOfWeeks3.Add("Monday");
dayOfWeeks3.Add("Tuesday");
dayOfWeeks3.Add("Wednesday");
dayOfWeeks3.Add("Thursday");
dayOfWeeks3.Add("Friday");
dayOfWeeks3.Add("Saturday");
dayOfWeeks3.Add("Sunday");

for (int i = 0; i < dayOfWeeks3.Count; i++)
{
    //Console.WriteLine(dayOfWeeks3[i]);
}

//-Pętla foreach    
foreach (string day in dayOfWeeks3)
{
    //Console.WriteLine(day);
}

//-Zadanie Domowe

int number = 654646321;
string numberStr = number.ToString();
char[] letteres = numberStr.ToCharArray();

int[] numberCount = new int[10];


foreach (char num in letteres)
{
    for (int i = 0; i < 10; i++)
    {
        int numInt = num - '0';
        if (numInt == i) { numberCount[i] = numberCount[i] + 1; }
    }
}

Console.WriteLine("Wyniki dla liczby: " + numberStr);
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i +  " => " + numberCount[i]);
}