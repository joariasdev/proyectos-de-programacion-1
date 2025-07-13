Console.WriteLine("Bienvenido a mi lista de Contactos");

bool isRunning = true;

List<int> ids = new List<int>();
Dictionary<int, string> firstNames = new Dictionary<int, string>();
Dictionary<int, string> lastNames = new Dictionary<int, string>();
Dictionary<int, string> addresses = new Dictionary<int, string>();
Dictionary<int, string> telephones = new Dictionary<int, string>();
Dictionary<int, string> emails = new Dictionary<int, string>();
Dictionary<int, int> ages = new Dictionary<int, int>();
Dictionary<int, bool> bestFriends = new Dictionary<int, bool>();

List<int> searchResults = new List<int>();


while (isRunning)
{
    Console.WriteLine(@"1. Agregar Contacto     2. Ver Contactos    3. Buscar Contactos     4. Modificar Contacto   5. Eliminar Contacto    6. Salir");
    Console.WriteLine("Digite el número de la opción deseada");

    int chosenOption = Convert.ToInt32(Console.ReadLine());

    switch (chosenOption)
    {
        case 1: // Agregar Contacto
            {
                AddContact(ids, firstNames, lastNames, addresses, telephones, emails, ages, bestFriends);
            }
            break;
        case 2: // Ver Contactos
            {
                ViewContacts(ids, firstNames, lastNames, addresses, telephones, emails, ages, bestFriends);
            }
            break;
        case 3: // Buscar Contactos
            {
                searchResults.Clear();

                Console.WriteLine("Buscar por:");
                Console.WriteLine(@"1. Nombre    2. Apellido    3. Telefono     4. Direccion   5. Email    6. Regresar");
                Console.WriteLine("Digite el número de la opción deseada");

                chosenOption = Convert.ToInt32(Console.ReadLine());

                switch (chosenOption)
                {
                    case 1:
                        FindContacts("nombre", firstNames);
                        break;
                    case 2:
                        FindContacts("apellido", lastNames);
                        break;
                    case 3:
                        FindContacts("telefono", telephones);
                        break;
                    case 4:
                        FindContacts("direccion", addresses);
                        break;
                    case 5:
                        FindContacts("email", emails);
                        break;
                    case 6:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opcion Invalida");
                        break;
                }
            }
            break;
        case 4: // Modificar Contacto
            {
                EditContact();
            }
            break;
        case 5: // Eliminar Contacto
            {
                DeleteContact();
            }
            break;
        case 6: // Salir
            {
                Environment.Exit(0);
            }
            break;
        default:
            break;
    }
}

void AddContact(List<int> ids, Dictionary<int, string> firstNames, Dictionary<int, string> lastNames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.WriteLine("Digite el nombre de la persona");
    string firstName = Console.ReadLine() ?? "Anonymous";
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

    while (ids.Contains(id))
    {
        id += 1;
    }

    ids.Add(id);

    firstNames.Add(id, firstName);
    lastNames.Add(id, lastName);
    addresses.Add(id, address);
    telephones.Add(id, phone);
    emails.Add(id, email);
    ages.Add(id, age);
    bestFriends.Add(id, isBestFriend);
}

void ViewContacts(List<int> ids, Dictionary<int, string> firstNames, Dictionary<int, string> lastNames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.WriteLine();
    Console.WriteLine($"Id          Nombre          Apellido            Dirección           Telefono            Email           Edad            Es Mejor Amigo?");
    Console.WriteLine($"--------------------------------------------------------------------------------------------------------------------------------------------");

    foreach (var id in ids)
    {
        var isBestFriend = bestFriends[id];

        string isBestFriendStr = (isBestFriend == true) ? "Si" : "No";
        Console.WriteLine($"{id}         {firstNames[id]}         {lastNames[id]}         {addresses[id]}         {telephones[id]}            {emails[id]}            {ages[id]}          {isBestFriendStr}");
    }
    Console.WriteLine($"--------------------------------------------------------------------------------------------------------------------------------------------");
}

void FindContacts(string searchString, Dictionary<int, string> targetCollection)
{
    Console.WriteLine($"Inserta el {searchString}:");
    string target = Console.ReadLine() ?? "Anonymus";

    foreach (var item in targetCollection)
    {
        if (item.Value.Equals(target))
        {
            searchResults.Add(item.Key);
        };
    }
    ViewContacts(searchResults, firstNames, lastNames, addresses, telephones, emails, ages, bestFriends);
}

void EditContact()
{
    ViewContacts(ids, firstNames, lastNames, addresses, telephones, emails, ages, bestFriends);
    Console.WriteLine("Selecciona un contanto para modificar:");
    var targetId = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite el nombre de la persona");
    string firstName = Console.ReadLine() ?? "Anonymous";
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

    firstNames[targetId] = firstName;
    lastNames[targetId] = lastName;
    addresses[targetId] = address;
    telephones[targetId] = phone;
    emails[targetId] = email;
    ages[targetId] = age;
    bestFriends[targetId] = isBestFriend;

    Console.WriteLine("Contacto modificado.");
}

void DeleteContact()
{
    ViewContacts(ids, firstNames, lastNames, addresses, telephones, emails, ages, bestFriends);
    Console.WriteLine("Selecciona un contanto para eliminar:");
    var targetId = Convert.ToInt32(Console.ReadLine());

    ids.Remove(targetId);

    firstNames.Remove(targetId);
    lastNames.Remove(targetId);
    addresses.Remove(targetId);
    telephones.Remove(targetId);
    emails.Remove(targetId);
    ages.Remove(targetId);
    bestFriends.Remove(targetId);

    Console.WriteLine("Contacto eliminado.");
}