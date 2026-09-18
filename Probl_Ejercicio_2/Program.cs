
            Console.WriteLine("==================================================================");
            Console.WriteLine("EJERCICIO 2: Medición de 10 temperaturas de un motor");
            Console.WriteLine("Clasificación:");
            Console.WriteLine(" - Promedio <= 70 °C: TEMPERATURA NORMAL");
            Console.WriteLine(" - Promedio > 70 °C: ALERTA DE TEMPERATURA");
            Console.WriteLine("==================================================================\n");

            double suma = 0;
            double temperatura;
            const int TOTAL_MEDICIONES = 10;

            for (int i = 1; i <= TOTAL_MEDICIONES; i++)
            {
                Console.Write($"Ingrese la medición #{i} (°C): ");
                temperatura = Convert.ToDouble(Console.ReadLine());
                suma += temperatura;
            }

            double promedio = suma / TOTAL_MEDICIONES;

            Console.WriteLine($"\nTemperatura Promedio: {promedio:F2} °C");

            if (promedio <= 70)
            {
                Console.WriteLine("Estado: TEMPERATURA NORMAL");
            }
            else
            {
                Console.WriteLine("Estado: ALERTA DE TEMPERATURA");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        
