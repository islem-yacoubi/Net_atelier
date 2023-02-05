
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


    bool result = pass.CheckProfile("Yacoubi", "Islem");

    if (result)
    {
        Console.WriteLine("Correct");
    }
    else
    {
        Console.WriteLine("Erreur");
    }



    Console.WriteLine(pass.CheckProfile("Islem", "Yacoubi", "Islem@Esprit.tn"));





    bool result1 = pass.CheckProfile("Yacoubi", "Islem");

    if (result1)
    {
        Console.WriteLine("Correct");
    }
    else
    {
        Console.WriteLine("Incorrect");
    }

    bool result2 = pass.CheckProfile("Yacoubi", "Islem", "test@esprit.tn");

    if (result2)
    {
        Console.WriteLine("Correct");
    }
    else
    {
        Console.WriteLine("Incorrect");
    }


    Passenger psst = new Passenger();
    psst.PassengerType();


    Staff st = new Staff();
    Traveller tr = new Traveller();
    st.PassengerType();
    tr.PassengerType();

}






