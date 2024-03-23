using Controller;
using Controller.Interfaces;

namespace Threads
{
    public class Program
    {
        private static object counter = 0;

        private static int meta = 100;

        private static bool finished = false;

        public static void Main(string[] args)
        {
            // Ejecucion simple de un par de hilos simultaneamente.
            // SimpleThreadExecution();

            // Ejecucion de tareas en hilos distintos.
            // TaskThreadExecution();

            // Ejecucion con Lock.
            // CounterThreads(5);

            // Ejercicio de carrera.
            // Race();

            // Ejercicio diccionario.
            DictionaryExercise("palabra");
        }

        private static void DictionaryExercise(string arg)
        {
            arg = arg.Replace(" ", string.Empty).ToLower();
            arg[0].ToString().ToLower();
            arg[0].ToString().ToUpper();
            var result = new Dictionary<char, int>();
            foreach (var letter in arg) // => for (var i =0; i< arg.Length; i++) { letter => arg[i]; }
            {
                if (result.ContainsKey(letter))
                {
                    result[letter]++;
                }
                else
                {
                    result.Add(letter, 1);
                }
            }

            foreach(var item in result)
            {
                Console.WriteLine("La letra " + item.Key + " se repite " + item.Value + " veces.");
            }
        }

        private static void Race()
        {
            var runner1 = new Thread(Run);
            runner1.Name = "Runner 1";
            var runner2 = new Thread(Run);
            runner2.Name = "Runner 2";

            runner1.Start();
            runner2.Start();

            while (!finished)
            {
            }
        }

        private static void Run()
        {
            var random = new Random();
            var steps = 0;

            while (steps < meta)
            {
                steps += random.Next(1, 5);
                Console.WriteLine(Thread.CurrentThread.Name + " ha dado " + steps.ToString() + " pasos.");

                if (steps >= meta)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " ha cruzado la meta!!!");
                    finished = true;
                    break;
                }

                Thread.Sleep(500);
            }
        }

        private static void CounterThreads(int threadCounter)
        {
            var threads = new Thread[threadCounter];
            for (var i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(IncrementCounter);
                threads[i].Name = "Thread " + i.ToString();
                threads[i].Start();
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }

            Console.WriteLine("El contador es: " + counter.ToString());
        }

        private static void IncrementCounter()
        {
            lock (counter)
            {
                if (counter is int value)
                {
                    Thread.Sleep(1000);
                    value++; 
                    counter = value;
                    Console.WriteLine("El contador es en el hilo " + Thread.CurrentThread.Name + " : " + counter.ToString());
                    counter = value;
                }
            }
        }

        private static async void TaskThreadExecution()
        {
            var myCustomTask = Task.Run(async () => await LoadAsyncData());

            Thread.CurrentThread.Name = "Main";
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine("En el hilo " + Thread.CurrentThread.Name + " el contador es " + i.ToString());
                Thread.Sleep(1000);
            }

            Console.WriteLine("Esperando por hilo secundario....");
            Console.WriteLine(myCustomTask.IsCompleted.ToString());
            var result = await myCustomTask;
            
            Console.WriteLine(result);

            Console.WriteLine("El hilo principal " + Thread.CurrentThread.Name + " puede continuar su ejecucion...");
        }

        private static async Task<string> LoadAsyncData()
        {
            Thread.CurrentThread.Name = "Worker";
            await Task.Delay(15000);
            return Thread.CurrentThread.Name + " ya ha terminado";
        }

        private static void SimpleThreadExecution()
        {
            var myWorkerThread = new Thread(new ThreadStart(LoadData))
            {
                Name = "Worker",
            };

            myWorkerThread.Start();

            Thread.CurrentThread.Name = "Main";
            Console.WriteLine("El hilo principal " + Thread.CurrentThread.Name + " va a pausar...");

            Thread.Sleep(6000);

            Console.WriteLine("El hilo principal " + Thread.CurrentThread.Name + " continua ejecutandose...");
        }

        private static void LoadData()
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine("desde el hilo secundario: " + Thread.CurrentThread.Name + " el contador es " + i.ToString());
                Thread.Sleep(1000);
            }
        }
    }
}