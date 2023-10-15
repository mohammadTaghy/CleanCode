using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_Functions
{
    class OneLevelAbstraction
    {
        double areaOfCircle(double radius)
        {
            double pi = 3.14159;
            return pi * radius * radius;
        }

        void validateInput()
        {
            String input = getInput();
            if (input.isEmpty())
            {
                throw new Exception("Input cannot be empty");
            }
            if (input.containsInvalidCharacters())
            {
                throw new Exception("Input contains invalid characters");
            }
            if (input.isTooLong())
            {
                throw new Exception("Input is too long");
            }
            if (input.isTooShort())
            {
                throw new Exception("Input is too short");
            }
        }

    }
    class OneLevelAbstractionClean
    {
        const double PI = 3.14159;

        double areaOfCircle(double radius)
        {
            return PI * radius * radius;
        }

        void validateInput()
        {
            String input = getInput();
            validateNotEmpty(input);
            validateNoInvalidCharacters(input);
            validateLength(input);
        }

        void validateNotEmpty(String input)
        {
            if (input.isEmpty())
            {
                throw new Exception("Input cannot be empty");
            }
        }

        void validateNoInvalidCharacters(String input)
        {
            if (input.containsInvalidCharacters())
            {
                throw new Exception("Input contains invalid characters");
            }
        }

        void validateLength(String input)
        {
            if (input.isTooLong())
            {
                throw new Exception("Input is too long");
            }
            if (input.isTooShort())
            {
                throw new Exception("Input is too short");
            }
        }

    }
}
