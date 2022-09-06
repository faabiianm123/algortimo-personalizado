int i = 0;
Console.WriteLine ( "inregese su dni");
int dni=  Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("desea consultar su estado prima?"); 
Console.WriteLine ("si= s");
Console.WriteLine ("no= n"); 
String respuesta=Console.ReadLine();
 if (respuesta== "s") { 
 Console.WriteLine( "condicion de contrato" );
 Console.WriteLine( "1 planta" );
 Console.WriteLine( "2 prestacion de servicios");
 int respuesta1 =Convert.ToInt32 (Console.ReadLine ());
 
 if (respuesta1==1 ){  

      Console.WriteLine( "tienes derecho a prima" );
      if (respuesta1==2 )
      Console.WriteLine( "no tienes derecho a prima"  ); 
 }}
      