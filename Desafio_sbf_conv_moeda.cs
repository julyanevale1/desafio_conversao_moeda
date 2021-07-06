using System;

namespace DesafioSBF
{
  class Program
  {
    static void ConvMoeda(decimal vlrprd)
	{
        decimal vlrusd = 0.00M;
        decimal vlreur = 0.00M;
        decimal vlrinr = 0.00M;
        
       vlrusd = decimal.Round(vlrprd / 5.39539M,2); //valor do dolar
       vlreur = decimal.Round(vlrprd / 6.36548M,2); // valor do euro
       vlrinr = decimal.Round(vlrprd * 13.80956M,2); // valor da rupia
       
    
      Console.WriteLine("USD: "+vlrusd);
      Console.WriteLine("EUR: "+vlreur);
      Console.WriteLine("INR: "+vlrinr);
    }

    static void Main(string[] args)
    {
      ConvMoeda(529.99M);
      //USD 98,23 - fc 5.39539M
      //EUR 83,26 - fc 6.36548M
      //INR 7.318,93 - fc 13.80956M
     
    }  
  }
}
