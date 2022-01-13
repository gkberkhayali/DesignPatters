using SingletonDesignPattern.Helpers;

//Singleton design pattern is based on private constructer logic. There can be only one instance of each class.
//You can not create object from class but only can access one single instance of it. 
//For accessing to instance without creating object, we use static keyword. Static keyword is belongs to class itself not any object of it.
//For example with sample below I will access Print method of LogHelper and use it without creating new object.

LogHelper.GetInstance().WriteInformativeLog("Sample log");

Console.ReadLine();






