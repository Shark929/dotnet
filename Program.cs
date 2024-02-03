float MilesToKm(float miles){
    float result = miles * 1.6f;
    return result;
}

void PrintWithPrefix(string theStr){
    Console.WriteLine($"::> {theStr}");
}

Console.WriteLine($"The result is {MilesToKm(8.0f)}");

PrintWithPrefix("The String");
PrintWithPrefix("Another test string");