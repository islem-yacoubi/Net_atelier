using System.Collections;
using System.Collections.Generic;
using AM.ApplicationCore.Domain;




Plane pl = new Plane();
{
    pl.Capacity = 123;
    pl.ManualFactureDate = DateTime.Now;
    pl.PlaneId = 3;
    pl.PlaneType = PlaneType.Boing;

    Console.WriteLine(pl);


    Plane avion2 = new Plane()
    {
        Capacity = 350,
        ManualFactureDate = DateTime.Now,
        PlaneId = 4,
        PlaneType = PlaneType.Airbus
    };
    Console.WriteLine(avion2);





    Passenger pass = new Passenger()
    {
        BirthDate = DateTime.Now,
        PasseportNumber = 95332,
        EmailAddress = "test@esprit.tn",
        FirstName = "Yacoubi",
        LastName = "Islem",
        TelNumber = 56761270
    };

    //11
    Traveller traveller = new Traveller();
    Staff staff = new Staff();
    Passenger passenger = new Passenger();
    traveller.passengerType();
    staff.passengerType();
    passenger.passengerType();
    //Collection des objets non génériques

    ArrayList list = new ArrayList();
    list.Add(pl);
    list.Add(1);
    list.Add("bonjour");
    for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine(list[i]);
    }

    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
    //Collection des objets génériques
    IList<Plane> planes = new List<Plane>();
    //Ilist: IEnumerable, ICollection
    //ICollection: IEnumerable
    //IEnumerable: assure le parcours des listes uniquement 
    //ICollection: les methode de parcours et insertion(add,remove,recherche..)
    planes.Add(pl);
    planes.Add(avion2);
    IList<Plane> planes2 = new List<Plane>()
    {
        pl,avion2,new Plane() {
         Capacity = 400,
        ManualFactureDate = DateTime.Now,
        PlaneId = 6,
        PlaneType = PlaneType.Airbus
        }
    };
    Personne p1 = new Personne();
    Console.WriteLine(Personne.nb);
    Personne p2 = new Personne();
    Console.WriteLine(Personne.nb);
    Personne p3 = new Personne();
    Console.WriteLine(Personne.nb);


}






