using System;

public class RandomIpv6Address
{
    public static void Main(string[] args)
    {
        var chars = "abcdef0123456789";
        var stringChars = new char[4];
        var random = new Random();

    for (int j =0; j<=7 ;j++)
    {

        for (int i = 0; i < stringChars.Length; i++)
        {
            stringChars[i] = chars[random.Next(chars.Length)];
            
        }

        var finalString = new String(stringChars);
        Console.Write(finalString + ":");   
    } 
}
}
