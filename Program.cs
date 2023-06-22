// See https://aka.ms/new-console-template for more information

int n = 6;
for (int i = 0; i < n; i++)
{
    string space = new(' ', n - i - 1);
    string hastag = new('#', i + 1);
    string result = space + hastag;
    Console.WriteLine(result);
}