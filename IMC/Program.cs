using System.Linq;
using System.Timers;

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

            double most_tall = 0;
            int most_young = 0;

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
                    



                    if (height[count] < 0.4 || height[count] > 2.3)
                    {
                        Console.WriteLine("La altura no es un valor valido");
                        errorCount--;
                        continue;
                    }
                    Console.WriteLine($"Proporcione el peso en kg de la persona N° {count + 1}");
                    weight[count] = double.Parse(Console.ReadLine());
                    if (weight[count] < 2 || weight[count] > 250)
                    {
                        Console.WriteLine("El peso no es un valor valido");
                        errorCount--;
                        continue;
                    }
                    Console.WriteLine($"Proporcione la edad de la persona N° {count + 1}");
                    age[count] = int.Parse(Console.ReadLine());
                    if (age[count] < 1 || age[count] > 110)
                    {
                        Console.WriteLine("La edad no es un valor valido");
                        errorCount--;
                        continue;
                    }




                    break;
                }



                if (errorCount == 0)
                {
                    Console.WriteLine("Excedio el numero de errores permitidos");
                    names[count] = "No Capturo";
                    height[count] = 0;
                    weight[count] = 0;
                    age[count] = 0;
                }
                count++;
            }
            count = 0;
            int omitEntry = 0;
            while (count < peopleCount)
            {
                if (names[count] == "No Capturo")
                {
                    omitEntry++;
                    count++;
                    continue;
                }
                count++;
            }
          
            //Se calcula la persona mas joven
            most_young = age.Min();
            int yungest = Array.IndexOf(age, most_young);
            string youngName = names[yungest];
            Console.WriteLine($"La persona mas joven es: {youngName} con: {most_young} edad");
            
          
            //se calcula la persona mas alta          
            most_tall = height.Max();
            int index = Array.IndexOf(height, most_tall);  
            string tallestName = names[index];             
            Console.WriteLine("La persona mas joven es: ");
            Console.WriteLine($"La persona mas alta es: {tallestName} con: {most_tall} metros" );

            //Cacular el mayor indice de masa corporal
            for (int i = 0; i < peopleCount; i++)
            {
                if (names[i] != "No Capturo")
                {
                    imc[i] = weight[i] / (height[i] * height[i]);
                }
            }

            double maxIMC = 0;
            string personWithMaxIMC = "";

            for (int i = 0; i < peopleCount; i++)
            {
                if (names[i] != "No Capturo" && imc[i] > maxIMC)
                {
                    maxIMC = imc[i];
                    personWithMaxIMC = names[i];
                }
            }

            Console.WriteLine($"La persona con el mayor IMC es {personWithMaxIMC} con un IMC de {maxIMC}");
        }
    }
}

