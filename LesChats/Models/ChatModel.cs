using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP.Models
{
    public class ChatModel
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Age { get; set; }
        public string Couleur { get; set; }

        public static List<ChatModel> GetMeuteDeChats()
        {
            var i = 1;
            return new List<ChatModel>
            {
                new ChatModel{Id=i++,Nom = "Felix",Age = 3,Couleur = "Roux"},
                new ChatModel{Id=i++,Nom = "Minette",Age = 1,Couleur = "Noire"},
                new ChatModel{Id=i++,Nom = "Miss",Age = 10,Couleur = "Blanche"},
                new ChatModel{Id=i++,Nom = "Garfield",Age = 6,Couleur = "Gris"},
                new ChatModel{Id=i++,Nom = "Chatran",Age = 4,Couleur = "Fauve"},
                new ChatModel{Id=i++,Nom = "Minou",Age = 2,Couleur = "Blanc"},
                new ChatModel{Id=i,Nom = "Bichette",Age = 12,Couleur = "Rousse"}
            };
        }
    }
}