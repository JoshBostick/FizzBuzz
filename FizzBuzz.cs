
public string FizzBuzz(int number)
{
answer = ""

if (number % 3 == 0)
{
    answer += "fizz";
}
if (number % 5 == 0)
{
    answer += "buzz";
}
return answer
}