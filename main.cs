using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Rektangel rekt1 = new Rektangel();
    rekt1.Bas=3.6;
    rekt1.Höjd=11.2;

    Rektangel rekt2 = new Rektangel(6.5, 2.9);

    Rektangel rekt3 = new Rektangel(5.5);

    Console.WriteLine("Antal: "+Rektangel.AntalRektanglar);

    List<Rektangel> rektanglar = new List<Rektangel>();

    rektanglar.Add(rekt1);
    rektanglar.Add(rekt2);
    rektanglar.Add(rekt3);
    rektanglar.Add(new Rektangel(9.3, 2.8));
    rektanglar.Add(new Rektangel(5.2, 7.1));
    Console.WriteLine("Antal: "+Rektangel.AntalRektanglar);
    
    foreach(Rektangel r in rektanglar) {
      Console.WriteLine(r);
    }
     
  }
}