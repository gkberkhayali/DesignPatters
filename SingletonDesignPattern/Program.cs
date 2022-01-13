using SingletonDesignPattern.Helpers;

//Singleton design pattern is based on private constructer logic. There can be only one instance of each class.
//You can not create object from class but only can access one single instance of it. 
//For accessing to instance without creating object, we use static keyword. Static keyword is belongs to class itself not any object of it.
//For example with sample below I will access Print method of LogHelper and use it without creating new object.

//You see code below will write log to console.
LogHelper.GetInstance().WriteInformativeLog("Sample log");


//Now lets try to create two different objects of loghelper. 
//These two objects are identical. To check this we can control their hashcodes, values should be same.

var obj1 = LogHelper.GetInstance();
var obj2 = LogHelper.GetInstance();


if (long.Equals(obj1.GetHashCode(),obj2.GetHashCode()))
{
    Console.WriteLine("Objects are identical");
}
else
{
    Console.WriteLine("Objects are different");
}

//Another implementation of getting instance through c#

var obj3 = LogHelper.Instance;


if (long.Equals(obj1.GetHashCode(), obj3.GetHashCode()))
{
    Console.WriteLine("Objects are identical");
}
else
{
    Console.WriteLine("Objects are different");
}



Console.ReadLine();






