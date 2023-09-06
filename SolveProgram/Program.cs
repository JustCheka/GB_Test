Console.Write("Введите длину массива ");
int len = int.Parse(Console.ReadLine());
string[] strArr = new string[len];

for (int index = 0; index < len; index++){
    Console.Write($"Введите {index + 1} элемент массива ");
    strArr[index] = Console.ReadLine();
}

int countOfLen3 = 0;
for (int index = 0; index < len; index++){
    if (strArr[index].Length <= 3) countOfLen3++;
}

if (countOfLen3 != 0){
    string[] newStrArr = new string[countOfLen3];
    int index2 = 0;
    for (int index = 0; index < len; index++){
        if (strArr[index].Length <= 3){
            newStrArr[index2] = strArr[index];
            index2++;
        }
    }

    Console.WriteLine();
    foreach(string el in newStrArr){
        Console.Write(el + " ");
    }
}
else {
    Console.WriteLine("\nНет строк, длина которых меньше, либо равна 3 символам");
}
