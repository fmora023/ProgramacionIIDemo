namespace Threads
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Ejecucion simple de un par de hilos simultaneamente.
            // SimpleThreadExecution();

            // Ejecucion de tareas en hilos distintos.
            TaskThreadExecution();
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