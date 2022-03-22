using VMK_L2022_03_15_Exceptions;

void SomeFun()
{
    StreamReader? sr = null;
    int a = -1;
    try
    {
        sr = new StreamReader("somefile.txt");
        Console.WriteLine("Файл открыт");
        var data = sr.ReadLine();
        var ln = data?.Length ?? 0;
        a = int.Parse(data ?? "0");
    }
    catch (FileNotFoundException ex)
    {
        Console.WriteLine("Проблема с файлом");
    }
    finally
    {
        sr?.Close();
        Console.WriteLine("Файл закрыт");
    }
    Console.WriteLine("Данные в файле: {0}", a);
    
}

try
{
    SomeFun();
}
catch (FormatException e)
{
    Console.WriteLine("Не удалось получить целое число :(");
    return;
}


var s = "-2";
try
{
    var i = int.Parse(s);
    if (i < 0) throw new NegativeNumberException();
    Console.WriteLine(i / 3);
    int[] x = { 1, 2 };
    x[5] = 6;
}
catch (FormatException e)
{
    Console.WriteLine("Упс! Что-то пошло не так! :(");
    Console.WriteLine(e.Message);
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Упс! Произошло деление на ноль! :(");
    Console.WriteLine(e.Message);
}
catch (NegativeNumberException e)
{
    Console.WriteLine("Упс! Вы ввели отрицательное значение. Оно не допускается!");
}
catch
{
    Console.WriteLine("Возникло исключение :(");
}
finally
{
    // Обязательное исполнение.
}

try
{
    var mc = new MyClass(1);
    mc.GroupNumber = 1;
    Console.WriteLine(mc.GroupNumber);
}
catch (IncorrectGroupNumberException e)
{
    Console.WriteLine("Неверный номер группы");
}

Console.WriteLine("Программа успешно завершена");