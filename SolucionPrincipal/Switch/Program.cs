using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Estado> estados = new List<Estado>()
            {
                new Estado{ Descripcion = "Tarea 1", HorasEstimadas = 6, Status = TaskStatus.Completed},
                new Estado{ Descripcion = "Tarea 2", HorasEstimadas = 2, Status = TaskStatus.InProgress},
                new Estado{ Descripcion = "Tarea 3", HorasEstimadas = 8, Status = TaskStatus.Deleted},
                new Estado{ Descripcion = "Tarea 4", HorasEstimadas = 5, Status = TaskStatus.NotStarted},
                new Estado{ Descripcion = "Tarea 5", HorasEstimadas = 4, Status = TaskStatus.InProgress},
                new Estado{ Descripcion = "Tarea 6", HorasEstimadas = 3, Status = TaskStatus.OnHold},
                new Estado{ Descripcion = "Tarea 7", HorasEstimadas = 9, Status = TaskStatus.OnHold},
                new Estado{ Descripcion = "Tarea 8", HorasEstimadas = 0, Status = TaskStatus.NotStarted},
                new Estado{ Descripcion = "Tarea 9", HorasEstimadas = 12, Status = TaskStatus.Completed},
                new Estado{ Descripcion = "Tarea 10", HorasEstimadas = 11, Status = TaskStatus.NotStarted},
                new Estado{ Descripcion = "Tarea 11", HorasEstimadas = 7, Status = TaskStatus.Deleted},
                new Estado{ Descripcion = "Tarea 12", HorasEstimadas = 1, Status = TaskStatus.Completed},
                new Estado{ Descripcion = "Tarea 13", HorasEstimadas = 8, Status = TaskStatus.Completed},
                new Estado{ Descripcion = "Tarea 14", HorasEstimadas = 13, Status = TaskStatus.Completed},
            };
            Console.ForegroundColor = ConsoleColor.Yellow;

            MostrarTareas(estados);
            Console.WriteLine();
        }
        private static void MostrarTareas(List<Estado> estados)
        {
            foreach (var estado  in estados)
            {
                switch (estado.Status)
                {
                    case TaskStatus.Completed:
                        Console.ForegroundColor = ConsoleColor.Green;
                          break;
                    case TaskStatus.Deleted:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                            break;
                        case TaskStatus.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        case TaskStatus.InProgress:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                        case TaskStatus.OnHold:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    default:
                        break;                
                }
                Console.WriteLine(estado.Descripcion);
             
            }
            Console.ReadLine();
        }
       
    }
    class Estado
    {
        public string Descripcion { get; set; }
        public int HorasEstimadas  { get; set; }
        public TaskStatus Status { get; set; }
    }
    enum TaskStatus
    {

        NotStarted,
        InProgress,
        OnHold,
        Completed,
        Deleted
    }
}

