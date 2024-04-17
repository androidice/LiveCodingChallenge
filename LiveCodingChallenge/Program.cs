// See https://aka.ms/new-console-template for more information
using LiveCodingChallenge;
using System.Xml.XPath;
using Exception = LiveCodingChallenge.Exception;

Console.WriteLine("Hello, World!");

Exception ex  = Solution1.OpenFile("C:\\Users\\KevinAlviola\\OneDrive - Ocean Technologies Group\\Desktop\\LiveCodingChallenge\\LiveCodingChallenge\\LiveCodingChallenge\\program1.cs");
if (ex.Status != 200) { 
    Console.WriteLine(ex.Message);
}
ex =  Solution2.Validate(101);
if (ex.Status != 200)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine(Solution3.CalculateAverage(new int[] { 3,5,6 }));
int result;
Exception exResult;

 (result, exResult) =  Solution4.TryParse("12sss");
if(exResult.Status != 200)
{
    Console.WriteLine(exResult.Message);
}
else
{
  Console.WriteLine(result);
}

Console.WriteLine(Solution5.ValidateList(new List<int> { 3,5,7 }));

(result, exResult) = Solution6.Devide(23, 0);
if (exResult.Status != 200)
{
    Console.WriteLine(exResult.Message);
}
else
{
    Console.WriteLine(result);
}

Console.ReadKey();