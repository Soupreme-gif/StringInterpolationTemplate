using System;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    //1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var date = ("January 22, 2019");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number02()
    {
        var date = ("2019.01.22");
        var answer = $"{date}";
        Console.WriteLine(answer);

        return answer;

    }

    public string Number03()
    {
        var date = ("22 of January, 2019");
        var answer = $"{date}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number04()
    {
        
        var date = ("Year: 2019, Month: 01, Day: 22");
        var answer = $"{date}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number05()
    {
        var date = ("Tuesday");
        var answer = $"{date,10}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number06()
    {
        var time = ("11:01 PM");
        var date = ("Tuesday");
        var answer = $"{time,10}{date,10}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number07()
    {
        var time = ("h:11, m:01, s:27");
        var answer = $"{time}";
        Console.WriteLine($"{answer}");

        return answer;
    }

    public string Number08()
    {
        var dateAndTime = ("2019.01.22.11.01.27");
        var answer = $"{dateAndTime}";
        
        Console.WriteLine(answer);

        return answer;
    }

    public string Number09()
    {
        var pi = Math.PI;
        var answer = $"{pi:C2}";
        Console.WriteLine(answer);

        return answer;

    }

    public string Number10()
    {
        var pi = Math.PI;
        var answer = $"{pi,10:f3}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number11()
    {
        var squareRoot = Math.Sqrt(2);
        byte[] hexadecimal = BitConverter.GetBytes(squareRoot);
        var hexadecimalString = BitConverter.ToString(hexadecimal);
        // code above came from https://stackoverflow.com/questions/3569041/convert-double-into-hex-in-c-sharp

        Console.WriteLine(hexadecimalString);

        return hexadecimalString;
    }

    //2.2019.01.22
}
