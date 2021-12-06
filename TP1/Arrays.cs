using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysProjectMethods
{
    class Arrays
    {
        private int size;
        private string typeofArray;
        private string[] arrarystring;
        private double[] arraynumber;
        
        //constructeur
        public Arrays(string Type, int size) {

            this.size = 0;
            type = null;
        }

        public string TYPE(string Type, int size)
        {

            this.size = size;
            if (Type == "string")
                return this.arrarystring = new string[this.size];
            else
                return this.arraynumber = new double[this.size];
        }

        #region methods Insert 
        /// <summary>
        /// //inserer valeur reel avec préciser la position 
        /// </summary>
        /// <param name="Valeur">la valeur reel</param>
        /// <param name="position">la position </param>
        /// 
        public void InsertionFloat(float Valeur, int position)
        {

            arraynumber[position] = Valeur;

        }

        
        /// <summary>
        /// fonction d'insertion une chaine de caracteres
        /// </summary>
        /// <param name="Val">chaine de caracters</param>
        /// <param name="position">la position de insertion</param>
        public void InsertionString(string Val, int position)
        {
            Array.Resize<string>(ref arrarystring, arrarystring.Length + 1);

            for (int j = arrarystring.Length - 1; j - 1 == Index; j--)
            {
                arrarystring[j] = arrarystring[j - 1];
            }
            arrarystring[position-1] = Val;

        }
        #endregion


        #region methods display
        
        /// //l'affichage des elements du tableau string
        

        public void afficheString(string[] tableau)
        {
            this.arrarystring = tableau;
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(arrarystring[i]);
            }
        }
        /// //l'affichage des elements du tableau number
        public void affichenumber(double[] tableau)
        {
            this.arraynumber= tableau

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tableau[i]);
            }
        }
        #endregion



        #region methods serching
        //chercher un element dans un tableau chiane de caracters

        public int search(string[] tableau, int strinG)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                if (strinG == tableau[i])
                    return 1;
            }
            return 0;
        }

        //chercher un element dans un tableau number
        public int search(double[] tableau, int strinG)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                if (strinG == tableau[i])
                    return 1;
            }
            return 0;
        }
        #endregion



        #region methods Inverse
        /// <summary>
        /// methode inverser un tableau number
        /// </summary>
        
        public float[] Inversernumber(float[]  tableauNumber )
        {
            for (int i = 0; i < tableauNumber.Length - 1; i++)
            {
                for (int j = 0; i < tableauNumber.Length - 1; j--)
                {
                    float change = tableauNumber[i];
                    tableauNumber[i] = tableauNumber[j];
                    tableauNumber[j] = change;
                }
            }
              
            return tableauNumber;
        }

        /// methode inverser un tableau chaine de caracters
        
        public string[] Inverserchiane(string[] tableauNumber)
        {
            for (int i = 0; i < tableauNumber.Length - 1; i++)
            {
                for (int j = 0; i < tableauNumber.Length - 1; j--)
                {
                    float change = tableauNumber[i];
                    tableauNumber[i] = tableauNumber[j];
                    tableauNumber[j] = change;
                }
            }

            return tableauNumber;
        }
        #endregion


        #region methods sorting

        public int verify_sort_array(int[] tab)
        {
            for (int i = 0; i < tab.Length - 1; i++)
            {
                if (tab[i] > tab[i + 1])
                {
                    return 0;
                }
            }
            return 1;
        }
        #endregion



        #region methods concatener
        //concatener deux tableaux chaine de caracters

        public String  concate(string[] tableau, string[] tableau2)
        {
            
            return arrarystring = tableau.Concat(tableau2).ToArray();
           
        }
        //concatener deux tableaux number

        public double concate(double[] tableau, double[] tableau2)
        {
            
            return arraynumber = tableau.Concat(tableau2).ToArray();

        }
        public void concate(double[] tableau, double[] tableau2)
        {

            return arraynumber = tableau.Concat(tableau2).ToArray();

        }
        #endregion


        //suppression d'un element du tableau
        public void supprimer(int[] tab, int sup)
        {
            for (int i = sup - 1; i < tab.Length - 1; i++)
            {
                tab[i] = tab[i + 1];
            }
            //redimontiennement de tableau n - 1

            affiche(tab);
        }




    }
}
