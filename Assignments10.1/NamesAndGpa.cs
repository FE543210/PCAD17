using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Assignments10._1
{
    internal class NamesAndGpa
    {
        //C# Atribute
        [JsonPropertyName("StudentFirstName")]
        public string StuName { get; set; }
       
        [JsonPropertyName("StudentGPA")] 
        public double StuGPA { get; set; }

    }
}
