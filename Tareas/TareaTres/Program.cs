Console.WriteLine("Bienvenido a mi lista de Contactos");

bool isRunning = true;

List<int> ids = new List<int>();
Dictionary<int, string> names = new Dictionary<int, string>();
Dictionary<int, string> lastnames = new Dictionary<int, string>();
Dictionary<int, string> addresses = new Dictionary<int, string>();
Dictionary<int, string> telephones = new Dictionary<int, string>();
Dictionary<int, string> emails = new Dictionary<int, string>();
Dictionary<int, int> ages = new Dictionary<int, int>();
Dictionary<int, bool> bestFriends = new Dictionary<int, bool>();

while (isRunning)
{
    Console.WriteLine(@"1. Agregar Contacto     2. Ver Contactos    3. Buscar Contactos     4. Modificar Contacto   5. Eliminar Contacto    6. Salir");
    Console.WriteLine("Digite el número de la opción deseada");

    int chosenOption = Convert.ToInt32(Console.ReadLine());

    switch (chosenOption)
    {
        case 1: // Agregar Contacto
            break;
        case 2: // Ver Contactos
            break;
        case 3: // Buscar Contactos
            break;
        case 4: // Modificar Contacto
            break;
        case 5: // Eliminar Contacto
            break;
        case 6: // Salir
            break;
        default:
            break;
    }
}