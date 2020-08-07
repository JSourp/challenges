using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace challenges
{
    class UsernameValidation {
        public static bool Validate(string str) {
            // 1. The username is between 4 and 25 characters.
            if (str.Length < 4 || str.Length > 25) { return false; }

            // 2. It must start with a letter.
            if (!(char.IsLetter(str.First()))) { return false; }

            // 3. It can only contain letters, numbers, and the underscore character
            Regex pattern = new Regex(@"^[A-Za-z0-9_]+$");
            if (!(pattern.IsMatch(str))) { return false; }

            // 4. It cannot end with an underscore character.
            if (str.Last().ToString() == "_") { return false; }

            return true;
        }
    }
}
