namespace lesson
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {
                try
                {
                    int choice = CreateMenu();
                    DoOperation(choice);
                }
                catch (ArgumentException ex)
                {
                   
                   Console.Write("Parametro errato:");
                   Console.WriteLine(ex.Message);
                   Main(args);
               }
        }
        ///<summary>
        ///Crea un menù che accetta un input utente e pone le seguenti opzioni.
        ///1 - Carica la matrice
        ///2 - Stampa la matrice
        ///3 - Stampa matrice identità
        ///</summary>
        ///<returns>La scelta dell'utente, se valida, altrimenti -1.</returns>
        private static int CreateMenu()
        {
            Console.WriteLine("1 - Carica matrice");
            Console.WriteLine("2 - Stampa matrice caricata");
            Console.WriteLine("3 - Stampa matrice identità");

            Console.WriteLine("Fai la tua scelta:");

            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice < 1 || choice > 3)
            {
                throw new ArgumentException("Hai sbagliato, voglio una scelta valida");
            }

            return choice;
        }
        /// <summary>
        /// Variabile globale che rapprsenta la matrice da caricare e stampare
        /// </summary>
        private static int[,] matrix;
        ///<summary>
        ///In base alla scelta specificata, esegue l'operazione
        ///come specificato nel menù.
        ///</summary>
        ///<param name="choice">La scelta dell'operazione</param>
        private static void DoOperation(int choice)
        {

            switch (choice)
            {
                case 1:
                    LoadMatrix();
                    break;
                case 2:
                    PrintMatrix();
                    break;
                case 3:
                    PrintIdentityMatrix();
                    break;
                default:
                    throw new ArgumentException("Scelta non valida");
            }

        }
        private static void LoadMatrix()
        {
            matrix = new int[2, 2];
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    try
                    {
                        Console.WriteLine($"matrix[{i}, {j}] = ");
                        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Errore durante l'input della cella");
                        return;
                    }
                }
            }

        }
        private static void PrintMatrix()
        {
            try
            {
                int rows = matrix.GetLength(0);
                int columns = matrix.GetLength(1);
                for(int i = 0;i < rows; i++)
                {
                    for(int j = 0;j < columns; j++)
                    {
                        Console.Write($"{matrix[i,j]}");
                    }
                    Console.WriteLine();
                }
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("Matrice non inizializzazione");
            }
           
        }
        private static void PrintIdentityMatrix()
        {
            try
            {
                int rows = matrix.GetLength(0);
                int columns = matrix.GetLength(1);

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (i == j)
                        {
                            matrix[i, j] = 1;
                        }
                        else
                        {
                            matrix[i, j] = 0;
                        }
                        Console.Write($"{matrix[i, j]}");
                    }
                    Console.WriteLine();
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Matrice non inizializzazione");
            }
        }
    }
}
