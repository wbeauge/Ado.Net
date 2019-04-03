using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace AdoDotNet
{
    class TableAnniversaire
    {
        private MySqlConnection connection;
        private MySqlCommand deleteAnniveraire;
        private MySqlCommand insertAnniveraire;
        private MySqlCommand selectAnniveraire;
        private MySqlCommand updateAnniveraire;

        public TableAnniversaire()
        {
            this.connection = ConnectionJoyeuxAnniversaire.GetConnection();

        }

        public int CompteOccurences() {

            Console.WriteLine("Quelle année?");
            int annee = 1940;

            string req = "select count(*) from anniversaire where YEAR(dateAnniversaire)=@annee";
            int comptage = -1;


            try
            {
                this.connection.Open();

                this.selectAnniveraire = new MySqlCommand(req, this.connection);
                this.selectAnniveraire.Parameters.Add(new MySqlParameter("@annee",MySqlDbType.Int32));
                selectAnniveraire.Parameters["@annee"].Value=annee;

                comptage = Convert.ToInt32(selectAnniveraire.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {

                this.connection.Close();
                Console.WriteLine("Connexion fermé");
            }

            return comptage;
        }

        public int CompteOccurences(int annee)
        {

            string req = "select count(*) from anniversaire where YEAR(dateAnniversaire)=@annee";
            int comptage = 0;


            try
            {
                this.connection.Open();

                this.selectAnniveraire = new MySqlCommand(req, this.connection);
                this.selectAnniveraire.Parameters.Add(new MySqlParameter("@annee", MySqlDbType.Int32));
                selectAnniveraire.Parameters["@annee"].Value = annee;

                comptage = Convert.ToInt32(selectAnniveraire.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {

                this.connection.Close();
                Console.WriteLine("Connexion fermé");
            }

            return comptage;
        }





        public List<Anniversaire> LeNomPatronymiqueCommencePar(string debutNom)
        {

            string req = "select nom,prenom,dateAniversaire from anniversaire where nom like @lettres%";

            List<Anniversaire> premieresLettre = new List<Anniversaire>();

            try
            {
                Anniversaire anna;

                this.connection.Open();

                this.selectAnniveraire = new MySqlCommand(req, this.connection);
                this.selectAnniveraire.Parameters.Add(new MySqlParameter("@lettres", MySqlDbType.String));
                selectAnniveraire.Parameters["@lettres"].Value = debutNom;

                DateTime dateAnniversaire;
                string prenom;
                string nom;

                MySqlDataReader reader = selectAnniveraire.ExecuteReader();
                while (reader.Read())
                {
                    prenom = reader["prenom"].ToString();
                    nom = reader["nom"].ToString();
                    dateAnniversaire = DateTime.Parse(reader["dateAnniversaire"].ToString());
                    anna = new Anniversaire(dateAnniversaire, " ", " " ,  prenom,  nom);

                    premieresLettre.Add(anna);
                }
                reader.Close(); 


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {

                this.connection.Close();
                Console.WriteLine("Connexion fermé");
            }

            return premieresLettre;
        }




    }
}
