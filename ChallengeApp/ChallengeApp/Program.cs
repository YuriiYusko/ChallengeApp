// My first App

//Dzień 6: Klasy i metody w klasie

using ChallengeApp;

User user0 = new User("Adam", "74794");
User user1 = new User("Yurii", "18303");
User user2 = new User("Mariana", "19452");
User user3 = new User("Zuzi", "853013");

user0.AddScore(5);
user0.AddScore(3);

Console.WriteLine(user0.Result);
var name = User.gameName;
Console.WriteLine(Math.PI);