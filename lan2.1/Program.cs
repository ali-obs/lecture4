int count = 0;
double sum = 0;
double highest = double.MinValue;
double lowest = double.MaxValue;

Console.Write("Enter grade (-1 to stop): ");
double grade = double.Parse(Console.ReadLine()!);

while (grade != -1)
{
    sum += grade;
    count++;

    if (grade > highest) highest = grade;
    if (grade < lowest) lowest = grade;

    Console.Write("Enter grade (-1 to stop): ");
    grade = double.Parse(Console.ReadLine()!);
}

if (count == 0)
{
    Console.WriteLine("No grades entered.");
}
else
{
    double average = sum / count;
    Console.WriteLine($"Count: {count}");
    Console.WriteLine($"Sum: {sum:F2}");
    Console.WriteLine($"Average: {average:F2}");
    Console.WriteLine($"Highest: {highest:F2}");
    Console.WriteLine($"Lowest: {lowest:F2}");
}
