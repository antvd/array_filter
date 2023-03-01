string[] fillarr(int size) 
{ 
    string[] arr = new string[size]; 
    Console.WriteLine("Введите элементы массива через enter"); 
    for (int i = 0; i < size;) 
    { 
        string num = Console.ReadLine(); 
        arr[i] = num; 
        i++; 
        if (size-i !=0) 
        { 
            Console.WriteLine($"Осталось ввести элементов: {size-i}"); 
        } 
        else 
        { 
            Console.WriteLine($"Все"); 
        } 
    } 
    return arr; 
} 