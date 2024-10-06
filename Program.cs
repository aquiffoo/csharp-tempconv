using System;

bool isCelsius(string value) {
    return value == "Celsius" || value == "C" || value == "c";
}

bool isFahrenheit(string value) {
    return value == "Fahrenheit" || value == "F" || value == "f";
}

bool isKelvin(string value) {
    return value == "Kelvin" || value == "K" || value == "k";
}

void Main() {
    double temp = 0.00;
    string originalUnit = "";
    string convertUnit = "";

    while (true) {
        Console.WriteLine("Give me the temperature of your place rn: ");
        temp = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Got it! The temperature is " + temp + ", but in which unit?");
        Console.WriteLine("C - Celsius");
        Console.WriteLine("F - Fahrenheit");
        Console.WriteLine("K - Kelvin");
        originalUnit = Console.ReadLine();

        if (isCelsius(originalUnit) || isFahrenheit(originalUnit) || isKelvin(originalUnit)) {
            Console.WriteLine("In which temperature unit do you want to convert it to?");
            convertUnit = Console.ReadLine();
            break;
        } else {
            Console.WriteLine("Invalid unit. Please try again.");
        }
    }

    double convertedTemp = 0.00;

    if (isCelsius(convertUnit)) {
        if (isFahrenheit(originalUnit)) {
            convertedTemp = (temp - 32) * 5 / 9;
        } else if (isKelvin(originalUnit)) {
            convertedTemp = temp - 273.15;
        } else {
            convertedTemp = temp;
        }
    } else if (isFahrenheit(convertUnit)) {
        if (isCelsius(originalUnit)) {
            convertedTemp = (temp * 9 / 5) + 32;
        } else if (isKelvin(originalUnit)) {
            convertedTemp = (temp - 273.15) * 9 / 5 + 32;
        } else {
            convertedTemp = temp;
        }
    } else if (isKelvin(convertUnit)) {
        if (isCelsius(originalUnit)) {
            convertedTemp = temp + 273.15;
        } else if (isFahrenheit(originalUnit)) {
            convertedTemp = (temp - 32) * 5 / 9 + 273.15;
        } else {
            convertedTemp = temp;
        }
    }

    Console.WriteLine($"Converted temperature: {convertedTemp} {convertUnit}");
}

Main();
