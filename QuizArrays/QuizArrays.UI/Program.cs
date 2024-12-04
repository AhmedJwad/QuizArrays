
using QuizArrays.Logic;

Console.WriteLine("ARRAY QUIZ");
var twoDimensions = new TwoDimensions(5, 3);

try
{
    twoDimensions.Fill();
    Console.WriteLine("Two dimensions array =>");
    Console.WriteLine(twoDimensions);
    var oneDimension = twoDimensions.ToOneDimension();
    Console.WriteLine("One dimension array =>");
    Console.WriteLine(oneDimension);


}
catch (Exception Ex)
{

    Console.WriteLine("Error: " + Ex.Message);
}