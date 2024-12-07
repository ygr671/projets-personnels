using System;

class calculatrice
{
        public static double Addition(double a, double b)
        {
                return a + b;
        }

        public static double Multiplication(double a, double b)
        {
                return a * b;
        }

        public static double Soustraction(double a, double b)
        {
                return a - b;
        }

        public static double Division(double a, double b)
        {
                double res;
                //Précondition : si a ou b = 0 alors renvoyer -1
                if (a == 0 || b == 0)
                {
                        res = -1;
                }
                else
                {
                        res = a/b;
                }

                return res;
        }

        //Procédure demanderReels qui demande deux réels passés en référence a et b pour pouvoir ensuite appeler les fonctions de calcul plus haut
        public static void demanderReels(ref double a, ref double b)
        {
                Console.Write("Nombre 1 : ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Nombre 2 : ");
                b = double.Parse(Console.ReadLine());
        }


        public static void Main()
        {
                bool quit = false;
                //Première boucle do-while : elle permet de rester dans le programme si bool quit = false et le quitter si bool quit = true 
                do
                {
                        double res;
                        double a = 0;
                        double b = 0;
                        int choix;
                        Console.WriteLine("Calculatrice v0.1\n1 - Addition\n2 - Soustraction\n3 - Multiplication\n4 - Division\n5 - Quitter");
                        //Seconde boucle do-while : Elle permet de prompter l'utilisateur à chaque fin de calcul s'il veut en refaire un autre ou quitter
                        do
                        {
                                Console.Write("Choix : ");
                                choix = Convert.ToInt32(Console.ReadLine());
                                switch (choix)
                                {
                                        case 1:
                                                demanderReels(ref a, ref b);
                                                res = Addition(a,b);
                                                Console.Clear();
                                                Console.WriteLine("{0} + {1} = {2}", a, b, res);
                                                break;
                                        case 2:
                                                demanderReels(ref a, ref b);
                                                res = Soustraction(a,b);
                                                Console.Clear();
                                                Console.WriteLine("{0} - {1} = {2}", a, b, res);
                                                break;
                                        case 3:
                                                demanderReels(ref a, ref b);
                                                res = Multiplication(a,b);
                                                Console.Clear();
                                                Console.WriteLine("{0} * {1} = {2}", a, b, res);
                                                break;
                                        case 4:
                                                demanderReels(ref a, ref b);
                                                res = Division(a,b);
                                                Console.Clear();
                                                Console.WriteLine("{0} / {1} = {2}", a, b, res);
                                                break;
                                        case 5:
                                                quit = true;
                                                break;
                                        default:
                                                Console.WriteLine("Entrez un nombre entre 1 et 5 !");
                                                break;
                                }
                        } while(choix < 1 || choix > 5);
                } while(!quit);
        }
}
