// See https://aka.ms/new-console-template for more information
using TestTask.Models;

MyList<int> list = [1, 2, 3, 4, 5];
//1.Добавление нового значения
list.Add(6);
list.Add(7);

foreach (var item in list)
{
    Console.WriteLine("Item = " + item.ToString());
}

//2.Получение значения 0 индекса
Console.WriteLine("Value by 0 index = " + list.GetValue(0));

//3.Получение кол-ва значении
Console.WriteLine("Count = " + list.Count);

//4.Удаление 1 индекса (с 0 начинается), получение кол-ва значении и перечисление всех
Console.WriteLine("Delete value by index 1");
list.RemoveItem(2);

Console.WriteLine("Count = " + list.Count);
foreach (var item in list)
{
    Console.WriteLine("Item = " + item.ToString());
}

//----------Дополнительно
//1-Цикл foreach работает
//2-LINQ запросы
var select = (from s in list
             where s == 2
             select s).FirstOrDefault();
Console.WriteLine("Select = " + select);
Console.WriteLine("Where = " + list.Where(x => x == 2).FirstOrDefault());

//3-расширяющий метод
Console.ReadLine();