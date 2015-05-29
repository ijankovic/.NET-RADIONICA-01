using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWordApp
{
    public class Person
    {
        private string _firstName;
        private string _lastName;

        public string FirstName 
        { 
            get { return _firstName; }
            set { _firstName = FirstCharToUpper( value); } 
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = FirstCharToUpper( value); }
        }

        private string FirstCharToUpper(string word)
        {
            var wordArray = word.ToCharArray();
            wordArray[0] = char.ToUpper(wordArray[0]);
            return new string(wordArray);
        }
    }
}
