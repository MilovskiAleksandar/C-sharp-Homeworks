string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = new string[] { "Aleksandar", "Danilo", "Borce", "Marko", "Darko"};

Console.WriteLine("Enter student group (there are 1 and 2):");
string students = Console.ReadLine();
int studentsGroup;
bool success = int.TryParse(students, out studentsGroup);

if (success)
{
    if (studentsGroup == 1)
    {
        Console.WriteLine("The students in G1 are:");
        for (int i = 0; i < studentsG1.Length; i++)
        {
            Console.WriteLine(studentsG1[i]);
        }
    }
    if (studentsGroup == 2)
    {
        Console.WriteLine("The students in G2 are:");
        for (int j = 0; j < studentsG2.Length; j++)
        {
            Console.WriteLine(studentsG2[j]);
        }
    }
}