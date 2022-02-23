using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_1_Shell
{
    public class animal
    {
        private string typeAnimal;
        private string nom;
        private int age;
        private int poids;
        private string couleur;
        private string nomProprietaire;

      

        public animal(string typeAnimal, string nom, int age, int poids, string couleur, string nomProprietaire)
        {
            this.TypeAnimal = typeAnimal;
            this.Nom = nom;
            this.Age = age;
            this.Poids = poids;
            this.Couleur = couleur;
            this.NomProprietaire = nomProprietaire;
        }

        public string TypeAnimal { get => typeAnimal; set => typeAnimal = value; }
        public string Nom { get => nom; set => nom = value; }
        public int Age { get => age; set => age = value; }
        public int Poids { get => poids; set => poids = value; }
        public string Couleur { get => couleur; set => couleur = value; }
        public string NomProprietaire { get => nomProprietaire; set => nomProprietaire = value; }
    }
}
