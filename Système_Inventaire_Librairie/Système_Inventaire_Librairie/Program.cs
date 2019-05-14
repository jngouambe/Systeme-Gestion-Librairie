using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using SIL;

namespace Système_Inventaire_Librairie
{
    class Program
    {
        static Livre livre = new Livre();
        static Film film = new Film();
        static AlbumMusical musique = new AlbumMusical();
        static void Main(string[] args)
        {
            ChoixMenu();
            Console.ReadKey();
        }
        //Méthode pour la modification du prix du livre recevant en paramètre l'objet livre.
        static void ModificationDePrixLivre(Livre livre)
        {
            //Déclaration des variables utilisées par la méthode.
            bool saisie = false; ;
            double modification;
            string valeur;
            //Boucle pour repéter la demande lorsque l'utilisateur a repondu Oui 'O'.
            do
            {
                Console.WriteLine();
                Console.WriteLine(" Donnez- moi la valeur de modification que vous voulez appliquer");
                Console.Write(" au prix de vente du livre.(Exemple, 10 pour 10%): ");
                //Saisie de la valeur de modification.
                valeur = Console.ReadLine();
                //Vérification du format de saisie.
                if (CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator == ",")
                {
                    valeur = valeur.Replace(".", ",");
                }
                else
                {
                    valeur = valeur.Replace(",", ".");
                }
                //Conversion de la saisi en valeur de type double.
                saisie = Double.TryParse(valeur, out modification);
                if (saisie)
                {
                    livre.ModifierPrix(modification);
                    //Affichage des informations saisies sur le livre après la modification
                    Console.WriteLine();
                    Console.WriteLine($" Après une modification du prix de {modification}% du prix de vente,");
                    Console.WriteLine(" Les informations sur le livre sont maintenant les suivantes.");
                    Console.WriteLine();
                    Console.WriteLine(livre.ToString());
                }
                //Si la conversion n'a pas réussi ou que la valeur de modification est inférieur ou égale à 0
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(" La valeur saisie n'est pas une valeur valide.");
                    Console.WriteLine(" Impossible d'effectuer l'opération d'augmentation ou de réduction de prix démandée.");
                }
            } while (!saisie);
        }
        //Méthode pour la modification du prix du film recevant en paramètre l'objet film.
        static void ModificationDePrixFilm(Film film)
        {
            //Déclaration des variables utilisées par la méthode.
            bool saisie = false; ;
            double modification;
            string valeur;
            //Boucle pour repéter la demande lorsque l'utilisateur a repondu Oui 'O'.
            do
            {
                Console.WriteLine();
                Console.WriteLine(" Donnez- moi la valeur de modification que vous voulez appliquer");
                Console.Write(" au prix de vente du film.(Exemple, 10 pour 10%): ");
                //Saisie de la valeur de modification.
                valeur = Console.ReadLine();
                //Vérification du format de saisie.
                if (CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator == ",")
                {
                    valeur = valeur.Replace(".", ",");
                }
                else
                {
                    valeur = valeur.Replace(",", ".");
                }
                //Conversion de la saisie en valeur de type double.
                saisie = Double.TryParse(valeur, out modification);
                if (saisie)
                {
                    film.ModifierPrix(modification);
                    //Affichage des informations saisies sur le film après la modification
                    Console.WriteLine();
                    Console.WriteLine($" Après une modification du prix de {modification}% du prix de vente,");
                    Console.WriteLine(" Les informations sur le film sont maintenant les suivantes.");
                    Console.WriteLine();
                    Console.WriteLine(film.ToString());
                }
                //Si la conversion n'a pas réussi ou que la valeur de modification est inférieur ou égale à 0
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(" La valeur saisie n'est pas une valeur valide.");
                    Console.WriteLine(" Impossible d'effectuer l'opération d'augmentation ou de réduction de prix démandée.");
                }
            } while (!saisie);
        }
        //Méthode pour la modification du prix de l'album musical recevant en paramètre l'objet musique.
        static void ModificationDePrixMusique(AlbumMusical musique)
        {
            //Déclaration des variables utilisées par la méthode.
            bool saisie = false; ;
            double modification;
            string valeur;
            //Boucle pour repéter la demande lorsque l'utilisateur a repondu Oui 'O'.
            do
            {
                Console.WriteLine();
                Console.WriteLine(" Donnez- moi la valeur de modification que vous voulez appliquer");
                Console.Write(" au prix de vente de l'album musical.(Exemple, 10 pour 10%): ");
                //Saisie de la valeur de modification.
                valeur = Console.ReadLine();
                //Vérification du format de saisie.
                if (CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator == ",")
                {
                    valeur = valeur.Replace(".", ",");
                }
                else
                {
                    valeur = valeur.Replace(",", ".");
                }
                //Conversion de la saisie en valeur de type double.
                saisie = Double.TryParse(valeur, out modification);
                if (saisie)
                {
                    musique.ModifierPrix(modification);
                    //Affichage des informations saisies sur l'album musical après la modification
                    Console.WriteLine();
                    Console.WriteLine($" Après une modification du prix de {modification}% du prix de vente,");
                    Console.WriteLine(" Les informations sur l'album musical sont maintenant les suivantes.");
                    Console.WriteLine();
                    Console.WriteLine(musique.ToString());
                }
                //Si la conversion n'a pas réussi ou que la valeur de modification est inférieur ou égale à 0
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(" La valeur saisie n'est pas une valeur valide.");
                    Console.WriteLine(" Impossible d'effectuer l'opération d'augmentation ou de réduction de prix démandée.");
                }
            } while (!saisie);
        }
        //Méthode pour la reception de commande de livre recevant en paramètre l'objet livre.
        static void ReceptionCommmandeLivre(Livre livre)
        {
            bool Ok = false;
            string code = "";
            int quantite = 0;
            //boucle effectuant la saisie et la vérification du code ISBN du livre.
            while (!Ok)
            {
                Console.WriteLine();
                Console.Write(" Donnez-moi le code ISBN du livre dont vous désirez recevoir: ");
                code = Console.ReadLine();
                if (code.Length == 13)
                {
                    if (char.IsDigit(code[0]) && char.IsDigit(code[1]) && char.IsDigit(code[2]) && char.IsDigit(code[3]) && char.IsDigit(code[4]) &&
                            char.IsDigit(code[5]) && char.IsDigit(code[6]) && char.IsDigit(code[6]) && char.IsDigit(code[7]) && char.IsDigit(code[8]) &&
                            char.IsDigit(code[9]) && char.IsDigit(code[10]) && char.IsDigit(code[11]) && char.IsDigit(code[12]))
                    {
                        //Boucle effectuant les la saisie et la vérification de la quantité de livre.
                        while (!Ok)
                        {
                            Console.WriteLine();
                            Console.Write(" Quelle est la quantité de ce livre que vous désirez recevoir: ");
                            //Saisie de la valeur du livre
                            if (Ok = int.TryParse(Console.ReadLine(), out quantite) && quantite > 0)
                            {
                                livre.RecevoirCommande(code, quantite);
                                Ok = true;
                                Console.WriteLine();
                                Console.WriteLine($" Après la reception de {quantite} livre(s),");
                                Console.WriteLine(" Les informations concernant le code et la quantité de ce livre sont: ");
                                Console.WriteLine();
                                Console.WriteLine($" ISBN du livre: {livre.Isbn}");
                                Console.WriteLine($" Quantité total en inventaire de ce livre: {livre.Quantite}");
                            }
                            if (!Ok)
                            {
                                Console.WriteLine();
                                Console.WriteLine(" Cette valeur n'est pas une valeur entière valide.");
                            }
                        }
                    }
                    Ok = true;
                }
                else
                {
                    if (!Ok)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Un code ISBN doit être composé de 13 caractères numériques.");
                        Ok = false;
                    }
                }
            }
        }
        //Méthode pour la reception de commande de film recevant en paramètre l'objet film.
        static void ReceptionCommmandeFilm(Film film)
        {
            bool Ok = false;
            string code = "";
            int quantite = 0;
            //boucle effectuant la saisie et la vérification du code ISBN du film.
            while (!Ok)
            {
                Console.WriteLine();
                Console.Write(" Donnez-moi le code ISBN du film dont vous désirez recevoir: ");
                code = Console.ReadLine();
                if (code.Length == 13)
                {
                    if (char.IsDigit(code[0]) && char.IsDigit(code[1]) && char.IsDigit(code[2]) && char.IsDigit(code[3]) && char.IsDigit(code[4]) &&
                            char.IsDigit(code[5]) && char.IsDigit(code[6]) && char.IsDigit(code[6]) && char.IsDigit(code[7]) && char.IsDigit(code[8]) &&
                            char.IsDigit(code[9]) && char.IsDigit(code[10]) && char.IsDigit(code[11]) && char.IsDigit(code[12]))
                    {
                        //Boucle effectuant les la saisie et la vérification de la quantité de film.
                        while (!Ok)
                        {
                            Console.WriteLine();
                            Console.Write(" Quelle est la quantité de ce film que vous désirez recevoir: ");
                            //Saisie de la valeur du film
                            if (Ok = int.TryParse(Console.ReadLine(), out quantite) && quantite > 0)
                            {
                                film.RecevoirCommande(code, quantite);
                                Ok = true;
                                Console.WriteLine();
                                Console.WriteLine($" Après la reception de {quantite} film(s),");
                                Console.WriteLine(" Les informations concernant le code et la quantité de ce film sont: ");
                                Console.WriteLine();
                                Console.WriteLine($" ISBN du film: {film.Isbn}");
                                Console.WriteLine($" Quantité total en inventaire de ce film: {film.Quantite}");
                            }
                            if (!Ok)
                            {
                                Console.WriteLine();
                                Console.WriteLine(" Cette valeur n'est pas une valeur entière valide.");
                            }
                        }
                    }
                    Ok = true;
                }
                else
                {
                    if (!Ok)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Un code ISBN doit être composé de 13 caractères numériques.");
                        Ok = false;
                    }
                }
            }
        }
        //Méthode pour la reception de commande d'album musical recevant en paramètre l'objet musique.
        static void ReceptionCommmandeMusique(AlbumMusical musique)
        {
            bool Ok = false;
            string code = "";
            int quantite = 0;
            //boucle effectuant la saisie et la vérification du code ISBN du film.
            while (!Ok)
            {
                Console.WriteLine();
                Console.Write(" Donnez-moi le code ISBN de l'album musical dont vous désirez recevoir: ");
                code = Console.ReadLine();
                if (code.Length == 13)
                {
                    if (char.IsDigit(code[0]) && char.IsDigit(code[1]) && char.IsDigit(code[2]) && char.IsDigit(code[3]) && char.IsDigit(code[4]) &&
                            char.IsDigit(code[5]) && char.IsDigit(code[6]) && char.IsDigit(code[6]) && char.IsDigit(code[7]) && char.IsDigit(code[8]) &&
                            char.IsDigit(code[9]) && char.IsDigit(code[10]) && char.IsDigit(code[11]) && char.IsDigit(code[12]))
                    {
                        //Boucle effectuant les la saisie et la vérification de la quantité de film.
                        while (!Ok)
                        {
                            Console.WriteLine();
                            Console.Write(" Quelle est la quantité d'album musical que vous désirez recevoir: ");
                            //Saisie de la valeur du film
                            if (Ok = int.TryParse(Console.ReadLine(), out quantite) && quantite > 0)
                            {
                                musique.RecevoirCommande(code, quantite);
                                Ok = true;
                                Console.WriteLine();
                                Console.WriteLine($" Après la reception de {quantite} album(s) music(al/aux),");
                                Console.WriteLine(" Les informations concernant le code et la quantité de cet album musical sont: ");
                                Console.WriteLine();
                                Console.WriteLine($" ISBN du film: {musique.Isbn}");
                                Console.WriteLine($" Quantité total en inventaire de ce film: {musique.Quantite}");
                            }
                            if (!Ok)
                            {
                                Console.WriteLine();
                                Console.WriteLine(" Cette valeur n'est pas une valeur entière valide.");
                            }
                        }
                    }
                    Ok = true;
                }
                else
                {
                    if (!Ok)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Un code ISBN doit être composé de 13 caractères numériques.");
                        Ok = false;
                    }
                }
            }
            //
        }
        //Méthode pour la vente de livre recevant en paramètre l'objet livre.
        static void VenteItemLivre(Livre livre)
        {
            bool Ok = false;
            string code = "";
            int valeur = 0;
            //boucle effectuant la saisie et la vérification du code ISBN du livre.
            while (!Ok)
            {
                Console.WriteLine();
                Console.Write(" Donnez-moi le code ISBN du livre dont vous désirez vendre: ");
                code = Console.ReadLine();
                if (code.Length == 13)
                {
                    if (char.IsDigit(code[0]) && char.IsDigit(code[1]) && char.IsDigit(code[2]) && char.IsDigit(code[3]) && char.IsDigit(code[4]) &&
                            char.IsDigit(code[5]) && char.IsDigit(code[6]) && char.IsDigit(code[6]) && char.IsDigit(code[7]) && char.IsDigit(code[8]) &&
                            char.IsDigit(code[9]) && char.IsDigit(code[10]) && char.IsDigit(code[11]) && char.IsDigit(code[12]))
                    {
                        //Boucle effectuant les la saisie et la vérification de la quantité de livre.
                        while (!Ok)
                        {
                            Console.WriteLine();
                            Console.Write(" Quelle est la quantité de ce livre que vous désirez vendre: ");
                            //Saisie de la valeur du film
                            if (Ok = int.TryParse(Console.ReadLine(), out valeur) && valeur > 0)
                            {
                                livre.VendreItem(code, valeur);
                                Ok = true;
                                Console.WriteLine();
                                Console.WriteLine($" Après la vente de {valeur} livre(s),");
                                Console.WriteLine(" Les informations concernant le code et la quantité de ce livre sont: ");
                                Console.WriteLine();
                                Console.WriteLine($" ISBN du livre: {livre.Isbn}");
                                Console.WriteLine($" Quantité restante en inventaire de ce livre: {livre.Quantite}");
                            }
                            if (!Ok)
                            {
                                Console.WriteLine();
                                Console.WriteLine(" Cette valeur n'est pas une valeur entière valide.");
                            }
                        }
                    }
                    Ok = true;
                }
                else
                {
                    if (!Ok)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Un code ISBN doit être composé de 13 caractères numériques.");
                        Ok = false;
                    }
                }
            }
        }
        //Méthode pour la vente de film recevant en paramètre l'objet film.
        static void VenteItemFilm(Film film)
        {
            bool Ok = false;
            string code = "";
            int quantite = 0;
            //boucle effectuant la saisie et la vérification du code ISBN du film.
            while (!Ok)
            {
                Console.WriteLine();
                Console.Write(" Donnez-moi le code ISBN du film dont vous désirez vendre: ");
                code = Console.ReadLine();
                if (code.Length == 13)
                {
                    if (char.IsDigit(code[0]) && char.IsDigit(code[1]) && char.IsDigit(code[2]) && char.IsDigit(code[3]) && char.IsDigit(code[4]) &&
                            char.IsDigit(code[5]) && char.IsDigit(code[6]) && char.IsDigit(code[6]) && char.IsDigit(code[7]) && char.IsDigit(code[8]) &&
                            char.IsDigit(code[9]) && char.IsDigit(code[10]) && char.IsDigit(code[11]) && char.IsDigit(code[12]))
                    {
                        //Boucle effectuant les la saisie et la vérification de la quantité de film.
                        while (!Ok)
                        {
                            Console.WriteLine();
                            Console.Write(" Quelle est la quantité de ce film que vous désirez vendre: ");
                            //Saisie de la valeur du film
                            if (Ok = int.TryParse(Console.ReadLine(), out quantite) && quantite > 0)
                            {
                                film.VendreItem(code, quantite);
                                Ok = true;
                                Console.WriteLine();
                                Console.WriteLine($" Après la vente de {quantite} film(s),");
                                Console.WriteLine(" Les informations concernant le code et la quantité de ce film sont: ");
                                Console.WriteLine();
                                Console.WriteLine($" ISBN du film: {film.Isbn}");
                                Console.WriteLine($" Quantité restante en inventaire de ce film: {film.Quantite}");
                            }
                            if (!Ok)
                            {
                                Console.WriteLine();
                                Console.WriteLine(" Cette valeur n'est pas une valeur entière valide.");
                            }
                        }
                    }
                    Ok = true;
                }
                else
                {
                    if (!Ok)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Un code ISBN doit être composé de 13 caractères numériques.");
                        Ok = false;
                    }
                }
            }
        }
        //Méthode pour la vente d'album musical recevant en paramètre l'objet musique.
        static void VenteItemMusique(AlbumMusical musique)
        {
            bool Ok = false;
            string code = "";
            int quantite = 0;
            //boucle effectuant la saisie et la vérification du code ISBN de l'album musical.
            while (!Ok)
            {
                Console.WriteLine();
                Console.Write(" Donnez-moi le code ISBN de l'album musical dont vous désirez vendre: ");
                code = Console.ReadLine();
                if (code.Length == 13)
                {
                    if (char.IsDigit(code[0]) && char.IsDigit(code[1]) && char.IsDigit(code[2]) && char.IsDigit(code[3]) && char.IsDigit(code[4]) &&
                            char.IsDigit(code[5]) && char.IsDigit(code[6]) && char.IsDigit(code[6]) && char.IsDigit(code[7]) && char.IsDigit(code[8]) &&
                            char.IsDigit(code[9]) && char.IsDigit(code[10]) && char.IsDigit(code[11]) && char.IsDigit(code[12]))
                    {
                        //Boucle effectuant les la saisie et la vérification de la quantité de l'album musical.
                        while (!Ok)
                        {
                            Console.WriteLine();
                            Console.Write(" Quelle est la quantité de cet album musical que vous désirez vendre: ");
                            //Saisie de la valeur de l'album musical
                            if (Ok = int.TryParse(Console.ReadLine(), out quantite) && quantite > 0)
                            {
                                musique.VendreItem(code, quantite);
                                Ok = true;
                                Console.WriteLine();
                                Console.WriteLine($" Après la vente de {quantite} album(s) music(al/aux),");
                                Console.WriteLine(" Les informations concernant le code et la quantité de cet album musical sont: ");
                                Console.WriteLine();
                                Console.WriteLine($" ISBN de l'album musical: {musique.Isbn}");
                                Console.WriteLine($" Quantité restante en inventaire de cet album musical: {musique.Quantite}");
                            }
                            if (!Ok)
                            {
                                Console.WriteLine();
                                Console.WriteLine(" Cette valeur n'est pas une valeur entière valide.");
                            }
                        }
                    }
                    Ok = true;
                }
                else
                {
                    if (!Ok)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Un code ISBN doit être composé de 13 caractères numériques.");
                        Ok = false;
                    }
                }
            }
        }
        //Menu Principal.
        static void AfficherMenu()
        {
            Console.WriteLine();
            Console.WriteLine("     Système d'inventaire de librairie");
            Console.WriteLine();
            Console.WriteLine(" ************  Menu des objets  *************");
            Console.WriteLine(" *                                          *");
            Console.WriteLine(" * 1 - créer un item Livre                  *");
            Console.WriteLine(" * 2 - créer un item Film                   *");
            Console.WriteLine(" * 3 - créer un item AlbumMusical           *");
            Console.WriteLine(" * 0 - Quitter                              *");
            Console.WriteLine(" ********************************************");
            Console.WriteLine();
            Console.WriteLine(" Que désirez-vous faire ?");
            Console.WriteLine();
            Console.Write(" (Entre 1 et 3, 0 pour quitter l'application):    ");
        }
        //Méthode pour l'affichage du menu principal.
        static void ChoixMenu()
        {
            string choix = "9";
            //bool reponse = true;
            while (choix != "0")
            {
                AfficherMenu();
                choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        SaisirInfo_Livre();
                        break;
                    case "2":
                        SaisirInfo_Film();
                        break;
                    case "3":
                        SaisirInfo_Musique();
                        break;
                    case "0":
                        Console.Write(" Appuyez sur une touche pour sortir de l'application.");
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine(" Vous devez saisir une valeur entre 1 et 3. ");
                        Console.WriteLine();
                        break;
                }
            }
        }

        //Informations concernant le livre.
        static void SaisirInfo_Livre()
        {

            string isbn = SaisirISBN_Livre();
            string titre = SaisirTitre_Livre();
            string auteur = SaisirAuteur_Livre();
            string type = SaisirType_Livre();
            int quantite = SaisirQuantite_Livre();
            double prix = SaisirValeur_Livre();
            ushort nbrPages = SaisirNbrPages_Livre();
            Livre livre = new Livre(isbn, titre, auteur, type, quantite, prix, nbrPages);
            AfficherInfoLivre(livre);
            //
            bool rep = false;
            do
            {
                //Déclaration de la variable qui sera utilisée pour récupérer la réponse de l'utilisateur.
                char modification;
                Console.WriteLine();
                Console.Write(" Désirez-vous modifier le prix du livre?(O ou N): ");
                //Récupération de la réponse de l'utilisateur.
                rep = char.TryParse(Console.ReadLine().ToUpper(), out modification);
                //Si le transtypage a réussi
                if (rep)
                {
                    //Si la réponse est différente de 'O' ou 'N'
                    if (modification != 'O' && modification != 'N')
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Vous devez répondre par O ou N.");
                        Console.WriteLine();
                        rep = false;
                    }
                    //Si la réponse est soit 'O'ou 'N'
                    else
                    {
                        rep = true;
                        //Si la réponse est égale à 'O'
                        if (modification == 'O')
                        {
                            //Appel de la méthode AugmenterPrix() avec l'objet livre en paramètre.
                            ModificationDePrixLivre(livre);
                        }
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(" Vous devez répondre par O ou N.");
                    Console.WriteLine();
                    rep = false;
                }
            } while (!rep);
            //
            rep = false;
            do
            {
                //Déclaration de la variable qui sera utilisée pour récupérer la réponse de l'utilisateur.
                char recevoir;
                Console.WriteLine();
                Console.Write(" Désirez-vous recevoir un commande de livre?(O ou N): ");
                //Récupération de la réponse de l'utilisateur.
                rep = char.TryParse(Console.ReadLine().ToUpper(), out recevoir);
                //Si le transtypage a réussi
                if (rep)
                {
                    //Si la réponse est différente de 'O' ou 'N'
                    if (recevoir != 'O' && recevoir != 'N')
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Vous devez répondre par O ou N.");
                        Console.WriteLine();
                        rep = false;
                    }
                    //Si la réponse est soit 'O'ou 'N'
                    else
                    {
                        rep = true;
                        //Si la réponse est égale à 'O'
                        if (recevoir == 'O')
                        {
                            //Appel de la méthode ReceptionCommmandeLivre() avec l'objet livre en paramètre.
                            ReceptionCommmandeLivre(livre);
                        }
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(" Vous devez répondre par O ou N.");
                    Console.WriteLine();
                    rep = false;
                }
            } while (!rep);
            //
            //
            rep = false;
            do
            {
                //Déclaration de la variable qui sera utilisée pour récupérer la réponse de l'utilisateur.
                char vente;
                Console.WriteLine();
                Console.Write(" Désirez-vous vendre ce livre?(O ou N): ");
                //Récupération de la réponse de l'utilisateur.
                rep = char.TryParse(Console.ReadLine().ToUpper(), out vente);
                //Si le transtypage a réussi
                if (rep)
                {
                    //Si la réponse est différente de 'O' ou 'N'
                    if (vente != 'O' && vente != 'N')
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Vous devez répondre par O ou N.");
                        Console.WriteLine();
                        rep = false;
                    }
                    //Si la réponse est soit 'O'ou 'N'
                    else
                    {
                        rep = true;
                        //Si la réponse est égale à 'O'
                        if (vente == 'O')
                        {
                            //Appel de la méthode VenteItemLivre() avec l'objet livre en paramètre.
                            VenteItemLivre(livre);
                        }
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(" Vous devez répondre par O ou N.");
                    Console.WriteLine();
                    rep = false;
                }
            } while (!rep);
        }
        //Méthode pour l'affichage des informations sur le livre.
        static void AfficherInfoLivre(Livre livre)
        {

            Console.WriteLine();
            Console.WriteLine(" Les informations enregistrées sur votre livre.");
            Console.WriteLine();
            Console.WriteLine(livre.ToString());
        }
        //Méthode pour la saisie du code ISBN du livre.
        static string SaisirISBN_Livre()
        {
            bool Ok = false;
            string isbn = "";
            //boucle effectuant la saisie et la vérification du code ISBN du livre.
            while (!Ok)
            {
                Console.WriteLine();
                Console.Write(" Donnez-moi le code ISBN du livre: ");
                isbn = Console.ReadLine();
                if (isbn.Length == 13)
                {
                    if (char.IsDigit(isbn[0]) && char.IsDigit(isbn[1]) && char.IsDigit(isbn[2]) && char.IsDigit(isbn[3]) && char.IsDigit(isbn[4]) &&
                            char.IsDigit(isbn[5]) && char.IsDigit(isbn[6]) && char.IsDigit(isbn[6]) && char.IsDigit(isbn[7]) && char.IsDigit(isbn[8]) &&
                            char.IsDigit(isbn[9]) && char.IsDigit(isbn[10]) && char.IsDigit(isbn[11]) && char.IsDigit(isbn[12]))
                    {
                        Ok = true;
                    }
                }
                if (!Ok)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Un code ISBN doit être composé de 13 caractères numériques.");
                    Ok = false;
                }
            }
            return isbn;
        }
        //Méthode pour la saisie du titre du livre.
        static string SaisirTitre_Livre()
        {
            bool Ok = false;
            string titre = "";
            //boucle effectuant la saisie et la vérification du code ISBN du livre.
            while (!Ok)
            {
                Console.WriteLine();
                Console.Write(" Donnez-moi le titre du livre: ");
                titre = Console.ReadLine();
                if (titre.Length <= 50)
                {
                    Ok = true;

                }
                //Si le code ISBN saisi n'est pas valide, 
                //affichage d,un message d'erreur.
                else
                {
                    if (!Ok)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Le titre de ce film  doit contenir maximum 50 caractères.");
                    }
                }
            }
            return titre;
        }
        //Méthode pour la saisie du nom de l'auteur du livre.
        static string SaisirAuteur_Livre()
        {

            bool Ok = false;
            string auteur = "";
            //boucle effectuant la saisie et la vérification du code ISBN du livre.
            while (!Ok)
            {
                Console.WriteLine();
                Console.Write(" Donnez-moi le nom de l'auteur: ");
                auteur = Console.ReadLine();
                if (auteur.Length <= 50)
                {
                    Ok = true;

                }
                //Si le code ISBN saisi n'est pas valide, 
                //affichage d,un message d'erreur.
                else
                {
                    if (!Ok)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Le nom de l'auteur de ce film  doit contenir maximum 50 caractères .");
                    }
                }
            }
            return auteur;
        }
        //Méthode pour la saisie du nombre de pages.
        static ushort SaisirNbrPages_Livre()
        {
            bool Ok = false;
            ushort nbrPages = 0;
            //Boucle effectuant les la saisie et la vérification du nombre de pages du livre.
            do
            {
                Console.WriteLine();
                Console.Write(" Quelle est le nombre de pages du livre: ");
                //Saisie du nombre de pages du livre.
                Ok = ushort.TryParse(Console.ReadLine(), out nbrPages);
                // Si la saisie n'est pas bonne.
                if (!Ok || nbrPages <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Le nombre de pièces d'un album doit être un nombre entier positif.");
                    Ok = false;
                }
            } while (!Ok);
            return nbrPages;
        }
        //Méthode pour la saisie du type de livre.
        static string SaisirType_Livre()
        {
            int choix;
            string type = "";
            bool rep = false;
            Console.WriteLine();
            Console.WriteLine(" ****** Menu du type de livre  *******");
            Console.WriteLine(" *                                   *");
            Console.WriteLine(" * 1 - Type Roman                    *");
            Console.WriteLine(" * 2 - Type Nouvelle                 *");
            Console.WriteLine(" * 3 - Type Référence technique      *");
            Console.WriteLine(" *                                   *");
            Console.WriteLine(" *************************************");
            //
            do
            {
                Console.WriteLine();
                Console.Write(" Quel type de livre désirez-vous dans notre librairie?:  ");
                rep = int.TryParse(Console.ReadLine(), out choix);
                switch (choix)
                {
                    case 1:
                        type = "R";

                        break;
                    case 2:
                        type = "N";

                        break;
                    case 3:
                        type = "T";

                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine(" Vous devez saisir un chiffre entre 1, 2 et 3. ");
                        break;
                }
            } while ((choix < 1) || (choix > 3));
            return type;
        }
        //Méthode pour la saisie du prix du livre.
        static double SaisirValeur_Livre()
        {
            Console.WriteLine();
            bool Ok = false;
            double prix = 0;

            //Boucle effectuant les la saisie et la vérification de la valeur du livre.
            do
            {
                Console.Write(" Quelle est la valeur du livre: ");
                if (CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator == ",")
                {
                    Ok = double.TryParse(Console.ReadLine().Replace(".", ","), out prix);
                }
                else
                {
                    Ok = double.TryParse(Console.ReadLine().Replace(",", "."), out prix);
                }
                if (!Ok || prix <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Le prix de vente du livre doit être une valeur monétaire positive.");
                    Console.WriteLine();
                    Ok = false;
                }

            } while (!Ok);

            return prix;
        }
        //Méthode pour la saisie de la quantité de livres.
        static int SaisirQuantite_Livre()
        {
            bool Ok = false;
            int quantite = 0;
            //Boucle effectuant les la saisie et la vérification de la quantité de livre.
            while (!Ok)
            {
                Console.WriteLine();
                Console.Write(" Quelle est la quantité de ce livre en inventaire: ");
                //Saisie de la valeur du livre
                if (Ok = int.TryParse(Console.ReadLine(), out quantite) && quantite > 0)
                {
                    Ok = true;
                }
                if (!Ok)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Cette valeur n'est pas une valeur entière valide.");
                }
            }
            return quantite;
        }

        //Informations concernant le film.
        static void SaisirInfo_Film()
        {
            string isbn = SaisirISBN_Film();
            string titre = SaisirTitre_Film();
            string realisateur = SaisirRealisateur();
            string type = SaisirType_Film();
            int quantite = SaisirQuantite_Film();
            double prix = SaisirValeur_Film();
            ushort duree = SaisirDuree_Film();
            Film film = new Film(isbn, titre, realisateur, type, quantite, prix, duree);
            AfficherInfoFilm(film);
            //
            bool rep = false;
            do
            {
                //Déclaration de la variable qui sera utilisée pour récupérer la réponse de l'utilisateur.
                char modification;
                Console.WriteLine();
                Console.Write(" Désirez-vous modifier le prix du film?(O ou N): ");
                //Récupération de la réponse de l'utilisateur.
                rep = char.TryParse(Console.ReadLine().ToUpper(), out modification);
                //Si le transtypage a réussi
                if (rep)
                {
                    //Si la réponse est différente de 'O' ou 'N'
                    if (modification != 'O' && modification != 'N')
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Vous devez répondre par O ou N.");
                        Console.WriteLine();
                        rep = false;
                    }
                    //Si la réponse est soit 'O'ou 'N'
                    else
                    {
                        rep = true;
                        //Si la réponse est égale à 'O'
                        if (modification == 'O')
                        {
                            //Appel de la méthode AugmenterPrix() avec l'objet film en paramètre.
                            ModificationDePrixFilm(film);
                        }
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(" Vous devez répondre par O ou N.");
                    Console.WriteLine();
                    rep = false;
                }
            } while (!rep);
            //
            rep = false;
            do
            {
                //Déclaration de la variable qui sera utilisée pour récupérer la réponse de l'utilisateur.
                char recevoir;
                Console.WriteLine();
                Console.Write(" Désirez-vous recevoir un commande de ce film?(O ou N): ");
                //Récupération de la réponse de l'utilisateur.
                rep = char.TryParse(Console.ReadLine().ToUpper(), out recevoir);
                //Si le transtypage a réussi
                if (rep)
                {
                    //Si la réponse est différente de 'O' ou 'N'
                    if (recevoir != 'O' && recevoir != 'N')
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Vous devez répondre par O ou N.");
                        Console.WriteLine();
                        rep = false;
                    }
                    //Si la réponse est soit 'O'ou 'N'
                    else
                    {
                        rep = true;
                        //Si la réponse est égale à 'O'
                        if (recevoir == 'O')
                        {
                            //Appel de la méthode ReceptionCommmandeFilm(); avec l'objet film en paramètre.
                            ReceptionCommmandeFilm(film);
                        }
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(" Vous devez répondre par O ou N.");
                    Console.WriteLine();
                    rep = false;
                }
            } while (!rep);
            //
            rep = false;
            do
            {
                //Déclaration de la variable qui sera utilisée pour récupérer la réponse de l'utilisateur.
                char vente;
                Console.WriteLine();
                Console.Write(" Désirez-vous vendre ce film?(O ou N): ");
                //Récupération de la réponse de l'utilisateur.
                rep = char.TryParse(Console.ReadLine().ToUpper(), out vente);
                //Si le transtypage a réussi
                if (rep)
                {
                    //Si la réponse est différente de 'O' ou 'N'
                    if (vente != 'O' && vente != 'N')
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Vous devez répondre par O ou N.");
                        Console.WriteLine();
                        rep = false;
                    }
                    //Si la réponse est soit 'O'ou 'N'
                    else
                    {
                        rep = true;
                        //Si la réponse est égale à 'O'
                        if (vente == 'O')
                        {
                            //Appel de la méthode VenteItemFilm() avec l'objet film en paramètre.
                            VenteItemFilm(film);
                        }
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(" Vous devez répondre par O ou N.");
                    Console.WriteLine();
                    rep = false;
                }
            } while (!rep);
        }
        //Méthode pour l'affichage des informations sur le film.
        static void AfficherInfoFilm(Film film)
        {
            Console.WriteLine();
            Console.WriteLine(" Les informations enregistrées sur votre film.");
            Console.WriteLine();
            Console.WriteLine(film.ToString());
        }
        //Méthode pour la saisie du code ISBN du film.
        static string SaisirISBN_Film()
        {
            bool Ok = false;
            string isbn = "";
            //boucle effectuant la saisie et la vérification du code ISBN du film.
            while (!Ok)
            {
                Console.WriteLine();
                Console.Write(" Donnez-moi le code ISBN du film: ");
                isbn = Console.ReadLine();
                if (isbn.Length == 13)
                {
                    if (char.IsDigit(isbn[0]) && char.IsDigit(isbn[1]) && char.IsDigit(isbn[2]) && char.IsDigit(isbn[3]) && char.IsDigit(isbn[4]) &&
                            char.IsDigit(isbn[5]) && char.IsDigit(isbn[6]) && char.IsDigit(isbn[6]) && char.IsDigit(isbn[7]) && char.IsDigit(isbn[8]) &&
                            char.IsDigit(isbn[9]) && char.IsDigit(isbn[10]) && char.IsDigit(isbn[11]) && char.IsDigit(isbn[12]))
                    {
                        Ok = true;
                    }
                }
                if (!Ok)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Un code ISBN doit être composé de 13 caractères numériques.");
                    Ok = false;
                }
            }
            return isbn;
        }
        //Méthode pour la saisie du titre du film
        static string SaisirTitre_Film()
        {
            bool Ok = false;
            string titre = "";
            //boucle effectuant la saisie et la vérification du titre du film.
            while (!Ok)
            {
                Console.WriteLine();
                Console.Write(" Donnez-moi le titre du film: ");
                titre = Console.ReadLine();
                if (titre.Length <= 50)
                {
                    Ok = true;

                }
                //Si le titre du film saisi n'est pas valide, 
                //affichage d,un message d'erreur.
                else
                {
                    if (!Ok)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Le titre du film doit contenir maximum 50 caractères.");
                    }
                }
            }
            return titre;
        }
        //Méthode pour la saisie du nom du réalisateur du film.
        static string SaisirRealisateur()
        {
            string realisateur = "";
            bool Ok = false;
            //boucle effectuant la saisie et la vérification du nom du réalisateur.
            while (!Ok)
            {
                Console.WriteLine();
                Console.Write(" Donnez-moi le nom du rélisateur: ");
                realisateur = Console.ReadLine();
                if (realisateur.Length <= 50)
                {
                    Ok = true;
                }
                //Si le nom du réalisateursaisi n'est pas valide, 
                //affichage d,un message d'erreur.
                else
                {
                    if (!Ok)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Le nom du réalisateur de ce film  doit contenir maximum 50 caractères .");
                    }
                }
            }
            return realisateur;
        }
        //Méthode pour la saisie de la durée du film.
        static ushort SaisirDuree_Film()
        {
            ushort duree = 0;
            bool Ok = false;
            //Boucle effectuant les la saisie et la vérification de la durée du film.
            do
            {
                Console.WriteLine();
                Console.Write(" Quelle est la durée de ce film: ");
                //Saisie de la durée du film.
                Ok = ushort.TryParse(Console.ReadLine(), out duree);
                // Si la saisie n'est pas bonne.
                if (!Ok || duree <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(" La durée d'un film doit être une valeur entière positive.");
                    Ok = false;
                }
            } while (!Ok);
            return duree;
        }
        //Méthode pour la saisie du type de film.
        static string SaisirType_Film()
        {
            int choix;
            string type = "";
            bool rep = false;
            Console.WriteLine();
            Console.WriteLine(" ****** Menu du type de film  *******");
            Console.WriteLine(" *                                  *");
            Console.WriteLine(" * 1 - Type film d'action           *");
            Console.WriteLine(" * 2 - Type film d'horreur          *");
            Console.WriteLine(" * 3 - Type documentaire            *");
            Console.WriteLine(" *                                  *");
            Console.WriteLine(" ************************************");
            //
            do
            {
                Console.WriteLine();
                Console.Write(" Quel type de film désirez-vous dans notre librairie?:  ");
                rep = int.TryParse(Console.ReadLine(), out choix);
                switch (choix)
                {
                    case 1:
                        type = "A";

                        break;
                    case 2:
                        type = "H";

                        break;
                    case 3:
                        type = "D";

                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine(" Vous devez saisir un chiffre entre 1, 2 et 3. ");
                        break;
                }
            } while ((choix < 1) || (choix > 3));
            return type;
        }
        //Méthode pour la saisie du prix du film.
        static double SaisirValeur_Film()
        {
            Console.WriteLine();
            bool Ok = false;
            double prix = 0;

            //Boucle effectuant les la saisie et la vérification de la valeur du film.
            do
            {
                Console.Write(" Quelle est la valeur du film: ");
                if (CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator == ",")
                {
                    Ok = double.TryParse(Console.ReadLine().Replace(".", ","), out prix);
                }
                else
                {
                    Ok = double.TryParse(Console.ReadLine().Replace(",", "."), out prix);
                }
                if (!Ok || prix <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Le prix de vente du film doit être une valeur monétaire positive.");
                    Console.WriteLine();
                    Ok = false;
                }

            } while (!Ok);

            return prix;
        }
        //Méthode pour la saisie de la quantité de films.
        static int SaisirQuantite_Film()
        {
            bool Ok = false;
            int quantite = 0;
            //Boucle effectuant les la saisie et la vérification de la quantité de livre.
            while (!Ok)
            {
                Console.WriteLine();
                Console.Write(" Quelle est la quantité de ce film en inventaire: ");
                //Saisie de la valeur du film
                if (Ok = int.TryParse(Console.ReadLine(), out quantite) && quantite > 0)
                {
                    Ok = true;
                }
                if (!Ok)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Cette valeur n'est pas une valeur entière valide.");
                }
            }
            return quantite;
        }

        //Informations concernant l'album musical.
        static void SaisirInfo_Musique()
        {
            string isbn = SaisirISBN_Musique();
            string titre = SaisirTitre_Musique();
            string artiste = SaisirArtiste();
            string type = SaisirType_Musique();
            int quantite = SaisirQuantite_Musique();
            double prix = SaisirValeur_Musique();
            ushort nbrPieces = SaisirNbrPieces_Musique();
            AlbumMusical musique = new AlbumMusical(isbn, titre, artiste, type, quantite, prix, nbrPieces);
            AfficherInfoAlbum(musique);
            //
            bool rep = false;
            do
            {
                //Déclaration de la variable qui sera utilisée pour récupérer la réponse de l'utilisateur.
                char modification;
                Console.WriteLine();
                Console.Write(" Désirez-vous modifier le prix de l'album musical?(O ou N): ");
                //Récupération de la réponse de l'utilisateur.
                rep = char.TryParse(Console.ReadLine().ToUpper(), out modification);
                //Si le transtypage a réussi
                if (rep)
                {
                    //Si la réponse est différente de 'O' ou 'N'
                    if (modification != 'O' && modification != 'N')
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Vous devez répondre par O ou N.");
                        Console.WriteLine();
                        rep = false;
                    }
                    //Si la réponse est soit 'O'ou 'N'
                    else
                    {
                        rep = true;
                        //Si la réponse est égale à 'O'
                        if (modification == 'O')
                        {
                            //Appel de la méthode AugmenterPrix() avec l'objet AlbumMusical en paramètre.
                            ModificationDePrixMusique(musique);
                        }
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(" Vous devez répondre par O ou N.");
                    Console.WriteLine();
                    rep = false;
                }
            } while (!rep);
            //
            rep = false;
            do
            {
                //Déclaration de la variable qui sera utilisée pour récupérer la réponse de l'utilisateur.
                char recevoir;
                Console.WriteLine();
                Console.Write(" Désirez-vous recevoir un commande de cet album musical?(O ou N): ");
                //Récupération de la réponse de l'utilisateur.
                rep = char.TryParse(Console.ReadLine().ToUpper(), out recevoir);
                //Si le transtypage a réussi
                if (rep)
                {
                    //Si la réponse est différente de 'O' ou 'N'
                    if (recevoir != 'O' && recevoir != 'N')
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Vous devez répondre par O ou N.");
                        Console.WriteLine();
                        rep = false;
                    }
                    //Si la réponse est soit 'O'ou 'N'
                    else
                    {
                        rep = true;
                        //Si la réponse est égale à 'O'
                        if (recevoir == 'O')
                        {
                            //Appel de la méthode ReceptionCommmandeMusique(); avec l'objet musique en paramètre.
                            ReceptionCommmandeMusique(musique);
                        }
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(" Vous devez répondre par O ou N.");
                    Console.WriteLine();
                    rep = false;
                }
            } while (!rep);
            //
            rep = false;
            do
            {
                //Déclaration de la variable qui sera utilisée pour récupérer la réponse de l'utilisateur.
                char vente;
                Console.WriteLine();
                Console.Write(" Désirez-vous vendre cet album musical?(O ou N): ");
                //Récupération de la réponse de l'utilisateur.
                rep = char.TryParse(Console.ReadLine().ToUpper(), out vente);
                //Si le transtypage a réussi
                if (rep)
                {
                    //Si la réponse est différente de 'O' ou 'N'
                    if (vente != 'O' && vente != 'N')
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Vous devez répondre par O ou N.");
                        Console.WriteLine();
                        rep = false;
                    }
                    //Si la réponse est soit 'O'ou 'N'
                    else
                    {
                        rep = true;
                        //Si la réponse est égale à 'O'
                        if (vente == 'O')
                        {
                            //Appel de la méthode VenteItemMusique() avec l'objet musique en paramètre.
                            VenteItemMusique(musique);
                        }
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(" Vous devez répondre par O ou N.");
                    Console.WriteLine();
                    rep = false;
                }
            } while (!rep);
        }
        //Méthode pour l'affichage des informations sur l'album musical.
        static void AfficherInfoAlbum(AlbumMusical musique)
        {
            Console.WriteLine();
            Console.WriteLine(" Les informations enregistrées sur votre album musical.");
            Console.WriteLine();
            Console.WriteLine(musique.ToString());
        }
        //Méthode pour la saisie du code ISBN de l'album musical.
        static string SaisirISBN_Musique()
        {
            bool Ok = false;
            string isbn = "";
            //boucle effectuant la saisie et la vérification du code ISBN de l'album musical.
            while (!Ok)
            {
                Console.WriteLine();
                Console.Write(" Donnez-moi le code ISBN de l'album musical: ");
                isbn = Console.ReadLine();
                if (isbn.Length == 13)
                {
                    if (char.IsDigit(isbn[0]) && char.IsDigit(isbn[1]) && char.IsDigit(isbn[2]) && char.IsDigit(isbn[3]) && char.IsDigit(isbn[4]) &&
                            char.IsDigit(isbn[5]) && char.IsDigit(isbn[6]) && char.IsDigit(isbn[6]) && char.IsDigit(isbn[7]) && char.IsDigit(isbn[8]) &&
                            char.IsDigit(isbn[9]) && char.IsDigit(isbn[10]) && char.IsDigit(isbn[11]) && char.IsDigit(isbn[12]))
                    {
                        Ok = true;
                    }
                }
                if (!Ok)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Un code ISBN doit être composé de 13 caractères numériques.");
                    Ok = false;
                }
            }
            return isbn;
        }
        //Méthode pour la saisie du titre du l'album musical.
        static string SaisirTitre_Musique()
        {
            bool Ok = false;
            string titre = "";
            //boucle effectuant la saisie et la vérification du titre de l'album.
            while (!Ok)
            {
                Console.WriteLine();
                Console.Write(" Donnez-moi le titre de l'album: ");
                titre = Console.ReadLine();
                if (titre.Length <= 50)
                {
                    Ok = true;

                }
                //Si le titre de l'album saisi n'est pas valide, 
                //affichage d,un message d'erreur.
                else
                {
                    if (!Ok)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Le titre de cet album musical doit contenir maximum 50 caractères.");
                    }
                }
            }
            return titre;
        }
        //Méthode pour la saisie du nom de l'artiste.
        static string SaisirArtiste()
        {
            string artiste = "";
            bool Ok = false;
            //boucle effectuant la saisie et la vérification du nom de l'artiste.
            while (!Ok)
            {
                Console.WriteLine();
                Console.Write(" Donnez-moi le nom de l'artiste: ");
                artiste = Console.ReadLine();
                if (artiste.Length <= 50)
                {
                    Ok = true;

                }
                //Si le nom de l'artiste saisi n'est pas valide, 
                //affichage d,un message d'erreur.
                else
                {
                    if (!Ok)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Le nom de l'artiste doit contenir maximum 50 caractères .");
                    }
                }
            }
            return artiste;
        }
        //Méthode pour la saisie du nombres de pièces musicales.
        static ushort SaisirNbrPieces_Musique()
        {
            ushort nbrPieces = 0;
            bool Ok = false;

            //Boucle effectuant les la saisie et la vérification du nombre de pièces de l'album.
            do
            {
                Console.WriteLine();
                Console.Write(" Quelle est le nombre de pièces que contient cet album musical: ");
                //Saisie du nombre de pièces de l'album.
                Ok = ushort.TryParse(Console.ReadLine(), out nbrPieces);
                // Si la saisie n'est pas bonne.
                if (!Ok || nbrPieces <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Le nombre de pièces d'un album doit être un nombre entier positif.");
                    Ok = false;
                }
            } while (!Ok);
            return nbrPieces;
        }
        //Méthode pour la saisie du type de musique.
        static string SaisirType_Musique()
        {
            int choix;
            string type = "";
            bool rep = false;
            Console.WriteLine();
            Console.WriteLine(" ****** Menu du type d'album  *******");
            Console.WriteLine(" *                                  *");
            Console.WriteLine(" * 1 - Type album Rock&Roll         *");
            Console.WriteLine(" * 2 - Type album Blues             *");
            Console.WriteLine(" * 3 - Type album Dance             *");
            Console.WriteLine(" *                                  *");
            Console.WriteLine(" ************************************");
            //
            do
            {
                Console.WriteLine();
                Console.Write(" Quel type d'album désirez-vous dans notre librairie?:  ");
                rep = int.TryParse(Console.ReadLine(), out choix);
                switch (choix)
                {
                    case 1:
                        type = "R";

                        break;
                    case 2:
                        type = "B";

                        break;
                    case 3:
                        type = "D";

                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine(" Vous devez saisir un chiffre entre 1, 2 et 3. ");
                        break;
                }
            } while ((choix < 1) || (choix > 3));
            return type;
        }
        //Méthode pour la saisie du prix de l'album musical.
        static double SaisirValeur_Musique()
        {
            Console.WriteLine();
            bool Ok = false;
            double prix = 0;

            //Boucle effectuant les la saisie et la vérification de la valeur de l'album musical.
            do
            {
                Console.Write(" Quelle est la valeur de l'album musical: ");
                if (CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator == ",")
                {
                    Ok = double.TryParse(Console.ReadLine().Replace(".", ","), out prix);
                }
                else
                {
                    Ok = double.TryParse(Console.ReadLine().Replace(",", "."), out prix);
                }
                if (!Ok || prix <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Le prix de vente de l'album musical doit être une valeur monétaire positive.");
                    Console.WriteLine();
                    Ok = false;
                }

            } while (!Ok);

            return prix;
        }
        // Méthode pour la saisie de la quantité d'albums musicaux.
        static int SaisirQuantite_Musique()
        {
            bool Ok = false;
            int quantite = 0;
            //Boucle effectuant les la saisie et la vérification de la quantité de cet album.
            while (!Ok)
            {
                Console.WriteLine();
                Console.Write(" Quelle est la quantité de cet album en inventaire: ");
                //Saisie de la quantité de cet album.
                if (Ok = int.TryParse(Console.ReadLine(), out quantite) && quantite > 0)
                {
                    Ok = true;
                }
                if (!Ok)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Cette valeur n'est pas une valeur entière valide.");
                }
            }
            return quantite;
        }
    }
}
