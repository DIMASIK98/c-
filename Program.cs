﻿// = оператор присваивания(присвает то что слева в то что справа)
// == оператор сравнения тоесть он берет точто слева 100/50 сравнивает с тем что справа == и пишет нам true тоесть истина
// bool isTwo = 1340/25 == 50;
// Console.WriteLine($"Значение переменной : {isTwo} ")
// БУЛЕВО;

// Переменные проверим по такой же схеме int это целочисленный вид данных поэтому мы не може 
// ввести сюда десятичные числа 1.16 только целые (целые true ) десятичные (false)
// ; точка с запятой это отсечка для компилятора что тут мы закончили и что он 
// может переходить смотреть данные на след строке это как точка в русском языке
// int number = 7;
// number++;
//number (++)  инкремент имеет важнейшое значение (это увеличение значения в этой переменной
// на единицу если number =1 то будет равно двум )
// // инкремент может быть префексным когда ++ стоят перед переменной 
// постфиксный после переменной 
// разница есть 
// int a = 5 ;
// int b = 2 ;
// int c = ++a / b ;
// если разделить а на б получится 2 так как переменная инт отсекает все числа 
// по идее должно было получиться 2.5 но получилось 2 если поставить инкремент при таком же действии результат будет на единицу больше 
// префиксный инкремент имеет больший приоритет чем  операторы умоножение деление 
// int a = 5 ;
// int b = 2 ;
// int c = a++ / b ;
// значение будет так же 2 так как приоритета у инкремента стало меньше 
// однако число а = 6 
// дело в том что при постфиксном инкременте оператор в самом начале вычисляет
// значение этого выражения a / b записывает его в левую часть а только потом переменная 
// переменная а увеличивается на единицу в префиксным все наоборот

// // есть такая вещь как переполнение переменной тоесть если мы заходим за грань
// значения переменной то мы грубо говоря заходим с другого конца и начинаем отсчет самого начала
// Переменная int может хранить в себе значение от -2147483648 до 2147483647
// если прописать команту 
// int num = 2147483647;
// num = num+1; 
// то консоль нам покажет -2147483648 это и означает что переменная переполнилась

// Если нам не хватает значение int то используем значение Long  в которой диапазон куда больше



// double decimalValue = 1,2;
//  Console.WriteLine($"Значение переменной : {decimalValue} " );
// double хранит в себе дробную часть довольно таки обширную 
// Если взять за пример выражение double decimalValue = 5/2 ;
// то покажет число 2 , потому что у нас два значения 5 и 2
// относятся к другому типу , а именно int (целые числа )
// Соответственно необходимо условие трактовать по другому 
// 5.0 / 2.0 тогда наше значение будет типа double 



Console.WriteLine($"Значение переменной : {num} " );