class Rektangel {
  double bas;
  double höjd;
  static int antalRektanglar=0;

  public Rektangel(double b, double h) {
    antalRektanglar++;
    bas=b;
    höjd=h;
  }

  public Rektangel(double sida) {
    antalRektanglar++;
    bas=sida;
    höjd=sida;
  }

  public Rektangel() {antalRektanglar++;}
  
  public static int AntalRektanglar {
    get{return antalRektanglar;}
  }

  public double Bas {
    set{
      if(value>=0)
        bas=value;
    }
    get{return bas;}
  }

  public double Höjd {
    set{
      if(value>=0)
        höjd=value;
    }
    get{return höjd;}
  }

  public double Area {
    get {return bas*höjd;}
  }

  public override string ToString() {
    string output="";
    output+="Bas: "+bas;
    output+=" Höjd: "+höjd;
    return output;
  }
}