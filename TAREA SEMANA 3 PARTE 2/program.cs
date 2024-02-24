using System.ComponentModel;

internal class program
{
    private static void Main(string[] args)
    {
        //1) CONVERTIR NUMEROS EN LETRAS
        Console.WriteLine("Ingrese un numero de 1 al 5 en LETRAS:");
        string numberletters = Console.ReadLine().ToLower();

        int number;
        switch (numberletters)
        {
            case "uno":
                number = 1;
                break;
            case "dos":
                number = 2;
                break;
            case "tres":
                number = 3;
                break;
            case "cuatro":
                number = 4;
                break;
            case "cinco":
                number = 5;
                break;
            default:
                Console.WriteLine("Ingrese el numero en LETRAS");
                return;
                {
                    Console.WriteLine("El numero en digito es:" + number);

                }
                //2) MOSTRAR EL DIA DE LA SEMANA A PARTIR DE UN NUMERO
                Console.WriteLine("Ingrese un numero DEL 1 AL 7: ");
                int daynumber = int.Parse(Console.ReadLine());
                string dayweek;            
                
                    switch (dayweek)
                    {
                        case "L":
                        dayweek = "Lunes";
                            break;
                        case "M":
                         dayweek="Martes";
                            break;
                        case "MI":
                        dayweek="Miercoles";
                            break;
                        case "J":
                            dayweek="Jueves";
                            break;
                        case "V":
                            dayweek="Viernes";
                            break;
                        case "S":
                            dayweek="Sabado";
                            break;
                        case "D":
                            dayweek="Domingo";
                            break;
                        default:
                            Console.WriteLine("El mumero ingresado no es valido intente de nuevo. ");
                            return;
                        Console.WriteLine("El dia de la semana es:" + dayweek);
                        {

                    }

                }
                //3) CALCULAR PAGAR POR UN SERVICIO
                Console.WriteLine("Opciones disponibles:");
                Console.WriteLine("1. LAVADO DE AUTO");
                Console.WriteLine("2. CAMBIO DE ACEITE");
                Console.WriteLine("3. REVISION MECANICA");
                Console.WriteLine("Seleccione aqui su opcion:");

                int optio;
                if (int.TryParse(Console.ReadLine(), out optio))
                {
                    double import;
                    switch (optio)
                    {
                        case 1:
                            import = 10;
                            Console.WriteLine("El importe es:" + import);
                            break;
                        case 2:
                            import = 50;
                            Console.WriteLine("El importe es:" + import);
                            break;
                        case 3:
                            import = 150;
                            Console.WriteLine("El importe es:" + import);
                        default:
                            Console.WriteLine("A ocurrido un error");
                            break;


                    }

                }
                //4) MOSTRAR UN MENSAJE DE BIENVENIDA EN DIFERENTES IDIOMAS
                Console.WriteLine("\nIngrese alguno de los siguientes idiomas: ingles, frances, español ");
                string lenguage = Console.ReadLine();

                switch(lenguage)
                {
                    case "español":
                        Console.WriteLine("hola");
                        break;
                    case "ingles":
                        Console.WriteLine("hello");
                        break;
                    case "frances":
                        Console.WriteLine("salut");
                        break;
                    default:
                        Console.WriteLine("Ocurrio un error intentelo de nuevo");
                        break;

                }
                //5) EVALUAR LA CALIFICACION DE UN EXAMEN
                Console.WriteLine("Ingresa tu calificacion:");

                if (int.TryParse(Console.ReadLine(), out int calification)){
                    switch(calification)
                    {
                        case int nc when (nc >= 95 || nc <= 100):
                            Console.WriteLine("Aprobo felicidadeeesss");
                            break;
                        case int nc when (nc >= 80 || nc <= 89):
                            Console.WriteLine("Felicidades eres alguien notable");
                            break;
                        case int nc when (nc >= 70 || nc <= 79):
                            Console.WriteLine("Alegrate tienes una nota aprobatoria");
                            break;
                        case int nc when (nc >= 60 || nc <= 69):
                            Console.WriteLine("Tienes una nota aprobatoria pero no te conformes sigue esforzandote");
                            break;
                        case int nc when (nc >= 1 || nc <= 59):
                            Console.WriteLine("Lo siento no aprobaste pero no te rindas sigue intentandolo");
                            break;
                        default:
                            Console.WriteLine("A ocurrido un error ingrese de nuevo");
                            break;

                           





                        
                    }

                }
                





        }




    }
}

























