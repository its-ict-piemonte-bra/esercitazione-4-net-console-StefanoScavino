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
            int choice = CreateMenu();
            if (choice == -1)
            {
                Console.WriteLine("Scelta non Valida");
            }
            else
            {
                DoOperation(choice);
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
            int returnValue;
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice < 1 || choice > 3)
            {
                Console.WriteLine("Hai sbagliato");
                returnValue= -1;
            }
            else
            {
                returnValue = choice;
            }

            return returnValue;
        }
        /// <summary>
        /// Variabile globale
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
                    Console.WriteLine("Scelta non valida");
                    break;
            }

        }
        private static void LoadMatrix()
        {

        }
        private static void PrintMatrix()
        {

        }
        private static void PrintIdentityMatrix()
        {

        }
    }
}
