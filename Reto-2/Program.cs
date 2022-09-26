//Fibonacci

int[] fibonacci = new int[50];

fibonacci[0] = 0;
fibonacci[1] = 1;

for (int i = 2; i < fibonacci.Length; i++)
{
    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
    fibonacci.Append(fibonacci[i]);
}

foreach (int i in fibonacci)
{
    Console.Write(i + ", ");
}