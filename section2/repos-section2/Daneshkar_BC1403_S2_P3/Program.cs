
//Implicit Conversion
int num = 10;
double dNum = num; // تبدیل ضمنی از int به double
Console.WriteLine(dNum);



//Explicit Conversion  ( Casting  )
double dNum2 = 9.78;
int num2 = (int)dNum2; // تبدیل صریح از double به int
Console.WriteLine(num2);


//Convert Class
string str = "123";
int num3 = Convert.ToInt32(str);
Console.WriteLine(num3);


//using DataTypes Parsers
string strNum = "456";
int num4 = int.Parse(strNum); // تبدیل string به int
Console.WriteLine(num4);



//Exception
string input = "1200";
if (int.TryParse(input, out int result))
{
    Console.WriteLine(result);
    // تبدیل موفق
}
else
{
    Console.WriteLine("error");
    // تبدیل ناموفق
}