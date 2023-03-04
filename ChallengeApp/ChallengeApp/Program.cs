// My first App

String name = "Ewa";
bool isWoman = true;
int age = 31;

if (!isWoman){
    if (age < 18){
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
    else{
        Console.WriteLine("Pełnoletni mężczyzna");
    }
}
else if (age < 30){
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else{
    Console.WriteLine(name + ", lat " + age);
}
