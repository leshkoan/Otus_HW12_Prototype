using Otus_HW12_Prototype;

var cat = new Cat("Васька", 3, "Рыжий");
var dog = new Dog("Барбос", 5, "Чау-чау");

var cat2 = cat.MyClone();
var dog2 = dog.MyClone();

Console.WriteLine("Клонирование завершено!");

Console.WriteLine($"Кот №1: кличка - {cat.name}, возраст - {cat.age}, окрас - {cat.color}");
Console.WriteLine($"Клон кота: кличка - {cat2.name}, возраст - {cat2.age}, окрас - {cat2.color}");

Console.WriteLine($"Пёс №1: кличка - {dog.name}, возраст - {dog.age}, порода - {dog.breed}");
Console.WriteLine($"Клон пса: кличка - {dog2.name}, возраст - {dog2.age}, порода - {dog2.breed}");