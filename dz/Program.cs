//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//Например: 
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

Console.Write("Введите числа: ");
int[] num = StringToNum(Console.ReadLine());

int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ' ')
        {
            count++;
        }
    }

    int[] num = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ' ')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        num[index] = Convert.ToInt32(temp);
        index++;
    }
    return num;
}

int sum = 0;
for (int i = 0; i < num.Length; i++)
{
    if (num[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine($"Количество чисел больше 0 = {sum}");