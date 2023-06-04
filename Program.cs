
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;


//Разработайте систему для управления животным приютом.
//В вашем приюте могут находиться различные виды животных, такие как кошки, собаки, птицы и рептилии.
//Каждое животное имеет уникальный идентификатор, кличку и возраст.

//Требования:

//Создайте интерфейс IAnimal, который содержит следующие методы:

//void MakeSound(), который будет выводить звук, издаваемый животным.
//string GetInfo(), который будет возвращать информацию о животном в виде строки.
//Создайте абстрактный класс Animal, реализующий интерфейс IAnimal. В этом классе определите следующие общие свойства:

//Уникальный идентификатор животного.
//Кличку животного.
//Возраст животного.
//Создайте классы Cat, Dog, Bird и Reptile, наследующиеся от класса Animal. Каждый из этих классов должен реализовывать методы интерфейса IAnimal в соответствии с особенностями соответствующего вида животного.

//Создайте класс AnimalShelter, который будет содержать список животных в приюте. Реализуйте следующие методы:

//void AddAnimal(Animal animal), для добавления животного в приют.
//void RemoveAnimal(Animal animal), для удаления животного из приюта.
//void PrintAnimals(), для вывода информации о всех животных в приюте.
//Создайте программу, которая демонстрирует работу вашей системы управления животным приютом. Программа должна содержать меню с возможностью добавления и удаления животных, а также просмотра информации о животных.


using animal_shelter;

Animal_Shelter shelter = new Animal_Shelter();

while (true)
{
    Console.WriteLine("1 Просмотр всех имеющихся животных");
    Console.WriteLine("2 Добавить кота или кошку");
    Console.WriteLine("3 Удалить кота или кошку:");
    Console.WriteLine("4 Добавить собаку");
    Console.WriteLine("5 Удалить собаку");
    Console.WriteLine("6 Добавить рептилию");
    Console.WriteLine("7 Удалить рептилию");
    Console.WriteLine("0 Выход");

    int number = Convert.ToInt32(Console.ReadLine());

    switch (number)
    {
        case 0:
            Console.WriteLine("Вы нажали ноль. Программа завершается.");
            return;
        case 1:
            shelter.Print_Cat();
            shelter.Print_Dog();
            shelter.Print_reptile();
            break;
        case 2:
            Console.WriteLine("Введите имя");
            string Name = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ID");
            int ID = Convert.ToInt32(Console.ReadLine());
            shelter.Add_Cat(Name, age, ID);
            break;
        case 3:
            Console.WriteLine("Введите ID животного");
            int ID2 = Convert.ToInt32(Console.ReadLine());
            shelter.Remove_Cat(ID2);
            break;
        case 4:
            Console.WriteLine("Введите имя");
            string Name1 = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            int age1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ID");
            int ID1 = Convert.ToInt32(Console.ReadLine());
            shelter.Add_Dog(Name1, age1, ID1);
            break;
        case 5:
            Console.WriteLine("Введите ID животного");
            int ID3 = Convert.ToInt32(Console.ReadLine());
            shelter.Remove_Dog(ID3);
            break;
        case 6:
            Console.WriteLine("Введите имя");
            string Name2 = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            int age2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ID");
            int ID4 = Convert.ToInt32(Console.ReadLine());
            shelter.Add_reptile(Name2, age2, ID4);
            break;
        case 7:
            Console.WriteLine("Введите ID животного");
            int ID5 = Convert.ToInt32(Console.ReadLine());
            shelter.Remove_reptile(ID5);
            break;
        default:
            Console.WriteLine("Вы ввели некорректное число.");
            break;
    }
}

Console.WriteLine("Программа завершена.");
Console.ReadLine();
