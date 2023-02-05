using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AM.ApplicationCore.Domain
{
    public class Personne
    {

        public Personne()
        {

        }
        public bool Login(string nom,string password,string email)
        {
            return  nom == Nom && password == Password &&email==Email;
        }
        public virtual void GetMyType()
        {
            Console.WriteLine("je suis une personne");
        }
        public Personne(string prenom, int id, string nom, DateTime dateNaissance, string email, string password, string confirmPassword)
        {
            Prenom = prenom;
            Id = id;
            Nom = nom;
            DateNaissance = dateNaissance;
            Email = email;
            Password = password;
            ConfirmPassword = confirmPassword;
        }

        public string Prenom { get; set; }
        public int Id { get; set; }
        public string Nom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public override string ToString()
        {
            return "Id: "+Id+" " + "Nom: " + Nom +" "+ "Prenom: " + Prenom + " "+"Email: " + Email + " "+"DateNaissance: " +DateNaissance+ " ";

        }
    }
}
