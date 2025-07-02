Console.WriteLine("Bienvenido a mi lista de Contactos");

bool isRunning = true;

List<int> ids = new List<int>();
Dictionary<int, string> names = new Dictionary<int, string>();
Dictionary<int, string> lastNames = new Dictionary<int, string>();
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
            {
                Console.WriteLine("Digite el nombre de la persona");
                string name = Console.ReadLine() ?? "Anonymous";
                Console.WriteLine("Digite el apellido de la persona");
                string lastName = Console.ReadLine() ?? "";
                Console.WriteLine("Digite la dirección");
                string address = Console.ReadLine() ?? "Unknown";
                Console.WriteLine("Digite el telefono de la persona");
                string phone = Console.ReadLine() ?? "Unknown";
                Console.WriteLine("Digite el email de la persona");
                string email = Console.ReadLine() ?? "Unknown";
                Console.WriteLine("Digite la edad de la persona en números");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Especifique si es mejor amigo: 1. Si, 2. No");
                bool isBestFriend = Convert.ToInt32(Console.ReadLine()) == 1;

                var id = ids.Count + 1;
                ids.Add(id);

                names.Add(id, name);
                lastNames.Add(id, lastName);
                addresses.Add(id, address);
                telephones.Add(id, phone);
                emails.Add(id, email);
                ages.Add(id, age);
                bestFriends.Add(id, isBestFriend);
            }
            break;
        case 2: // Ver Contactos
            {
                Console.WriteLine();
                Console.WriteLine($"Nombre          Apellido            Dirección           Telefono            Email           Edad            Es Mejor Amigo?");
                Console.WriteLine($"----------------------------------------------------------------------------------------------------------------------------");

                foreach(var id in ids)
                {
                    var isBestFriend = bestFriends[id];

                    string isBestFriendStr = (isBestFriend == true) ? "Si" : "No";
                    Console.WriteLine($"{names[id]}         {lastNames[id]}         {addresses[id]}         {telephones[id]}            {emails[id]}            {ages[id]}          {isBestFriendStr}");
                }
                Console.WriteLine($"----------------------------------------------------------------------------------------------------------------------------");
            }
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