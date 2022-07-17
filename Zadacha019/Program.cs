int number = Convert.ToInt32(Console.ReadLine());
int firstDigit = number/10000;
int secondDigit = (number - firstDigit*10000)/1000;
int fiveDigit = number%10;
int fourthDigit = (number%100 - firstDigit)/10;


Console.WriteLine("firstDigit: " + firstDigit);
Console.WriteLine("secondDigit: " + secondDigit);
Console.WriteLine("fourthDigit: " + fourthDigit);
Console.WriteLine("fiveDigit: " + fiveDigit);
if (firstDigit == fiveDigit && secondDigit == fourthDigit){
    Console.WriteLine($"Число {number} является полиэдром");
}
