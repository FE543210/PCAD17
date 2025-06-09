using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Assignments10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Serialize JSON
            Students studentOne = new("S01", "John", "Mark", 3.5);
            Students studentTwo = new("S02", "Patricia", "Rue", 3.6);
            //To pretty-print the JSON output from the https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/how-to
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(studentOne, options);
            Console.WriteLine(jsonString);
            //Deserialize into a separate obj JSON
            NamesAndGpa? namesAndGPA = JsonSerializer.Deserialize<NamesAndGpa>(jsonString);
            Console.WriteLine($"Name: {namesAndGPA.StuName} -> GPA: {namesAndGPA.StuGPA}\n\n");
            //Serilize XML
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Students));
            using StringWriter textWriter = new StringWriter();
            xmlSerializer.Serialize(textWriter, studentTwo);
            string xmlString = textWriter.ToString();
            Console.WriteLine(xmlString);
            //Deseriliaze XML
            Students deserializedStudent;
            using StringReader reader = new StringReader(xmlString);
            deserializedStudent = (Students)xmlSerializer.Deserialize(reader);
            NamesAndGpa namesAndGPATwo = new NamesAndGpa
            {
                StuName = deserializedStudent.StudentFirstName,
                StuGPA = deserializedStudent.StudentGPA
            };

            Console.WriteLine($"Name: {namesAndGPATwo.StuName} - GPA: {namesAndGPATwo.StuGPA}");



        }
    }
}
