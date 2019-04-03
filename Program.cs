using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace AdoDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            TableAnniversaire ta = new TableAnniversaire();
            int comptage = ta.CompteOccurences(2006);
            Console.WriteLine("le nombre d'occurence est : {0}", comptage);
            int comptagee = ta.CompteOccurences();
            Console.WriteLine("le nombre d'occurence est : {0}", comptagee);


            DateTime date = new DateTime(1996, 04, 13);

            Anniversaire monan = new Anniversaire(0,date,"wil","wileme","vis","beauge");
            Console.WriteLine(monan.ToString());
            Console.ReadLine();
        }
    }
}
