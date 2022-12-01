// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

int number = 123454321;

string strNumber = Convert.ToString(number);
char[] numberCharArray = strNumber.ToCharArray();
Array.Reverse(numberCharArray);
string strReverseNumber = new string (numberCharArray);
int revNumber = Convert.ToInt32(strReverseNumber);

if (number == revNumber)
   Console.WriteLine($"Число {number} - является палиндромом");
else 
   Console.WriteLine($"Число {number} - не является полиндромом");


