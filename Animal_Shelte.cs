using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal_shelter
{
    class Animal_Shelter
    {
        public Cat[] arr_cat;
        public Dog[] arr_dog;
        public Reptile[] arr_reptile;

        public Animal_Shelter()
        {
            arr_cat = new Cat[3];
            arr_dog = new Dog[3];
            arr_reptile = new Reptile[3];

            PrintAnimals();

        }
        public void PrintAnimals()
        {
            arr_cat[0] = new Cat("Нюша", 3, 1);
            arr_cat[1] = new Cat("Барсик", 2, 2);
            arr_cat[2] = new Cat("Мурка", 1, 3);

            arr_dog[0] = new Dog("Дюра", 1, 1);
            arr_dog[1] = new Dog("Лаки", 3, 2);
            arr_dog[2] = new Dog("Лиза", 3, 3);

            arr_reptile[0] = new Reptile("Люба", 3, 1);
            arr_reptile[1] = new Reptile("Лиза", 4, 2);
            arr_reptile[2] = new Reptile("Кеша", 7, 3);
        }

        public void Print_Cat()
        {
            Console.WriteLine("Список котов");
            for (int i = 0; i < arr_cat.Length; i++)
            {
                Console.WriteLine(arr_cat[i].GetInfo());
            }
        }
        public void Print_Dog()
        {
            Console.WriteLine("Список собак");
            for (int i = 0; i < arr_dog.Length; i++)
            {
                Console.WriteLine(arr_dog[i].GetInfo());
            }
        }
        public void Print_reptile()
        {
            Console.WriteLine("Список рептилий");
            for (int i = 0; i < arr_reptile.Length; i++)
            {
                Console.WriteLine(arr_reptile[i].GetInfo());
            }
        }
        public void Add_Cat(string Name, int age, int id)
        {

            if (arr_cat == null)
            {
                arr_cat = new Cat[0];
            }


            Cat[] newArr = new Cat[arr_cat.Length + 1];

            Array.Copy(arr_cat, newArr, arr_cat.Length);

            Cat newElement = new Cat(Name, age, id);
            newArr[arr_cat.Length] = newElement;

            arr_cat = newArr;

            Console.WriteLine("Животное успешно добавленно");
            for (int i = 0; i < arr_cat.Length; i++)
            {
                Console.WriteLine(arr_cat[i].GetInfo());
            }
        }
        public void Add_Dog(string Name, int age, int id)
        {

            if (arr_dog == null)
            {
                arr_dog = new Dog[0];
            }

            Dog[] newArr = new Dog[arr_dog.Length + 1];

            Array.Copy(arr_dog, newArr, arr_dog.Length);

            Dog newElement = new Dog(Name, age, id);

            newArr[arr_dog.Length] = newElement;

            arr_dog = newArr;

            Console.WriteLine("Животное успешно добавленно");
            for (int i = 0; i < arr_cat.Length; i++)
            {
                Console.WriteLine(arr_cat[i].GetInfo());
            }
        }
        public void Add_reptile(string Name, int age, int id)
        {

            if (arr_reptile == null)
            {
                arr_reptile = new Reptile[0];
            }
            Reptile[] newArr = new Reptile[arr_reptile.Length + 1];


            Array.Copy(arr_reptile, newArr, arr_reptile.Length);


            Reptile newElement = new Reptile(Name, age, id);

            newArr[arr_reptile.Length] = newElement;


            arr_reptile = newArr;

            Console.WriteLine("Животное успешно добавленно");
            for (int i = 0; i < arr_reptile.Length; i++)
            {
                Console.WriteLine(arr_reptile[i].GetInfo());
            }
        }

        public void Remove_Cat(int id)
        {

            if (arr_cat != null)
            {

                int indexToRemove = -1;
                for (int i = 0; i < arr_cat.Length; i++)
                {
                    if (arr_cat[i].ID == id)
                    {
                        indexToRemove = i;
                        break;
                    }
                }
                if (indexToRemove >= 0)
                {

                    Cat[] newArr = new Cat[arr_cat.Length - 1];

                    Array.Copy(arr_cat, newArr, indexToRemove);


                    Array.Copy(arr_cat, indexToRemove + 1, newArr, indexToRemove, arr_cat.Length - indexToRemove - 1);
                    arr_cat = newArr;

                    Console.WriteLine("Животное успешно удалено.");
                    for (int i = 0; i < arr_cat.Length; i++)
                    {
                        Console.WriteLine(arr_cat[i].GetInfo());
                    }
                }
                else
                {
                    Console.WriteLine("Животное с указанным id не найден.");
                }
            }
        }

        public void Remove_Dog(int id)
        {
            if (arr_dog != null)
            {

                int indexToRemove = -1;
                for (int i = 0; i < arr_dog.Length; i++)
                {
                    if (arr_dog[i].ID == id)
                    {
                        indexToRemove = i;
                        break;
                    }
                }

                if (indexToRemove >= 0)
                {

                    Dog[] newArr = new Dog[arr_dog.Length - 1];

                    Array.Copy(arr_dog, newArr, indexToRemove);

                    Array.Copy(arr_dog, indexToRemove + 1, newArr, indexToRemove, arr_dog.Length - indexToRemove - 1);

                    arr_dog = newArr;

                    Console.WriteLine("Животное успешно удалено.");
                    for (int i = 0; i < arr_dog.Length; i++)
                    {
                        Console.WriteLine(arr_dog[i].GetInfo());
                    }
                }
                else
                {
                    Console.WriteLine("Животное с указанным id не найден.");
                }
            }

        }

        public void Remove_reptile(int id)
        {
            if (arr_reptile != null)
            {
                int indexToRemove = -1;
                for (int i = 0; i < arr_reptile.Length; i++)
                {
                    if (arr_reptile[i].ID == id)
                    {
                        indexToRemove = i;
                        break;
                    }
                }
                if (indexToRemove >= 0)
                {

                    Reptile[] newArr = new Reptile[arr_reptile.Length - 1];

                    Array.Copy(arr_reptile, newArr, indexToRemove);

                    Array.Copy(arr_reptile, indexToRemove + 1, newArr, indexToRemove, arr_reptile.Length - indexToRemove - 1);

                    arr_reptile = newArr;

                    Console.WriteLine("Животное успешно удалено.");
                    for (int i = 0; i < arr_reptile.Length; i++)
                    {
                        Console.WriteLine(arr_reptile[i].GetInfo());
                    }
                }
                else
                {
                    Console.WriteLine("Животное с указанным id не найден.");
                }
            }

        }

    }
}
