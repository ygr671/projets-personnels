using System;

class TriABulles
{
        public static void Main()
        {

                //Initialisation du tableau
                int[] tab = new int[5] {8,2,4,10,15};

                int i, j, temp;


                // Principe du tri à bulles : on regarde si l'élément sous le premier "curseur" est plus grand que l'élément sous le second et si c'est le cas, on modifie le tableau pour inverser les deux.
                // De plus, on fait tab.Length - 1 - i car déjà on veut éviter le out of range avec j+1 puis - i pour exclure tous les éléments déjà triés vers la droite, dès la première itération on exclu déjà 15 car il est déjà trié (i = 1), à la seconde, on exclu 10 et 15 car i = 2, c'est incrrrrr je viens de comprendre.
                for (i = 0 ; i < tab.Length - 1; i++)
                {
                        for (j = 0 ; j < tab.Length - 1 - i; j++)
                        {
                                if (tab[j] > tab[j+1])
                                {
                                        temp = tab[j+1];
                                        tab[j+1] = tab[j];
                                        tab[j] = temp;
                                }
                        }
                }

                for (i = 0 ; i < tab.Length ; i++)
                {
                        Console.Write($"{tab[i]} ");
                }
        }
}
