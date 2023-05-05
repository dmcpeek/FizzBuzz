private static string FizzBuzz(int number)
{
    string answer = "";
    if (number % 3 == 0)
    {
        answer = "Fizz";
        return answer;
    }

    else if (number % 5 == 0)
    {
        answer = "Buzz";
        return answer;
    }

    else if (number % 5 == 0 && number % 3 == 0)
    {
        answer = "FizzBuzz";
        return answer;
    }

    else
    {
        return "That number is not the one we are looking for";
    }
}