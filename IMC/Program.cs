namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = 0;
            Console.WriteLine("Cuántas personas se ingresarán?");
            //people count sirve para definir el tamaño de los arreglos
            peopleCount = int.Parse(Console.ReadLine());
            string[] names = new string[peopleCount];
            double[] weight = new double[peopleCount];
            double[] height = new double[peopleCount];
            double[] imc = new double[peopleCount];
            int[] age = new int[peopleCount];

            int count = 0;

            while (count < peopleCount)
            {
                int errorCount = 3;
                while (errorCount > 0)
                {
                    Console.WriteLine($"Proporcione el nombre de la persona N° {count + 1}");
                    names[count] = Console.ReadLine();
                    if (!names[count].Contains(" "))
                    {
                        Console.WriteLine("El nombre no tiene apellido");
                        errorCount--;
                        continue;
                    }
                    Console.WriteLine($"Proporcione la altura (metros) de la persona N° {count + 1}");
                    height[count] = double.Parse(Console.ReadLine());
                    if (height[count] < 1.2 || height[count] > 2.1)
                    {
                        Console.WriteLine("La altura no es un valor valido");
                        errorCount--;
                        continue;
                    }
                    break;
                }
                if (errorCount == 0)
                {
                    Console.WriteLine("Excedio el numero de errores permitidos");
                    names[count] = "No Capturo";
                    grades[count] = 0;
                }
                count++;
            }
            count = 0;
            double gradeSum = 0;
            int omitEntry = 0;
            while (count < alumnCount)
            {
                if (names[count] == "No Capturo")
                {
                    omitEntry++;
                    count++;
                    continue;
                }
                Console.WriteLine($"El alumno {names[count]} tiene calificacion de {grades[count]}, el alumno {(grades[count] > 7 ? "aprobo" : "reprobo")}");
                gradeSum += grades[count];
                count++;
            }
            Console.WriteLine($"La calificacion promedio es {gradeSum / (alumnCount - omitEntry)}");

        }
    }
}
