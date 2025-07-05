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

// Data for testing
ids.Add(1);
firstNames.Add(1, "Jorge");
lastNames.Add(1, "Arias");
addresses.Add(1, "Anacaona");
telephones.Add(1, "8095554444");
emails.Add(1, "email@gmail.com");
ages.Add(1, 99);
bestFriends.Add(1, false);

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
                        {
                            Console.WriteLine("Inserta el nombre:");
                            string searchedFirstName = Console.ReadLine() ?? "Anonymus";

                            foreach (var firstName in firstNames)
                            {
                                if (firstName.Value.Equals(searchedFirstName))
                                {
                                    searchResults.Add(firstName.Key);
                                };
                            }

                            Console.WriteLine();
                            Console.WriteLine($"Nombre          Apellido            Dirección           Telefono            Email           Edad            Es Mejor Amigo?");
                            Console.WriteLine($"----------------------------------------------------------------------------------------------------------------------------");

                            foreach (var id in searchResults)
                            {
                                var isBestFriend = bestFriends[id];

                                string isBestFriendStr = (isBestFriend == true) ? "Si" : "No";
                                Console.WriteLine($"{firstNames[id]}         {lastNames[id]}         {addresses[id]}         {telephones[id]}            {emails[id]}            {ages[id]}          {isBestFriendStr}");
                            }
                            Console.WriteLine($"----------------------------------------------------------------------------------------------------------------------------");
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Inserta el apellido:");
                            string searchedLastName = Console.ReadLine() ?? "Anonymus";

                            foreach (var lastName in lastNames)
                            {
                                if (lastName.Value.Equals(searchedLastName))
                                {
                                    searchResults.Add(lastName.Key);
                                };
                            }

                            Console.WriteLine();
                            Console.WriteLine($"Nombre          Apellido            Dirección           Telefono            Email           Edad            Es Mejor Amigo?");
                            Console.WriteLine($"----------------------------------------------------------------------------------------------------------------------------");

                            foreach (var id in searchResults)
                            {
                                var isBestFriend = bestFriends[id];

                                string isBestFriendStr = (isBestFriend == true) ? "Si" : "No";
                                Console.WriteLine($"{firstNames[id]}         {lastNames[id]}         {addresses[id]}         {telephones[id]}            {emails[id]}            {ages[id]}          {isBestFriendStr}");
                            }
                            Console.WriteLine($"----------------------------------------------------------------------------------------------------------------------------");
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Inserta el telefono:");
                            string searchedTelephone = Console.ReadLine() ?? "Anonymus";

                            foreach (var telephone in telephones)
                            {
                                if (telephone.Value.Equals(searchedTelephone))
                                {
                                    searchResults.Add(telephone.Key);
                                };
                            }

                            Console.WriteLine();
                            Console.WriteLine($"Nombre          Apellido            Dirección           Telefono            Email           Edad            Es Mejor Amigo?");
                            Console.WriteLine($"----------------------------------------------------------------------------------------------------------------------------");

                            foreach (var id in searchResults)
                            {
                                var isBestFriend = bestFriends[id];

                                string isBestFriendStr = (isBestFriend == true) ? "Si" : "No";
                                Console.WriteLine($"{firstNames[id]}         {lastNames[id]}         {addresses[id]}         {telephones[id]}            {emails[id]}            {ages[id]}          {isBestFriendStr}");
                            }
                            Console.WriteLine($"----------------------------------------------------------------------------------------------------------------------------");
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Inserta la direccion:");
                            string searchedAddress = Console.ReadLine() ?? "Anonymus";

                            foreach (var address in addresses)
                            {
                                if (address.Value.Equals(searchedAddress))
                                {
                                    searchResults.Add(address.Key);
                                };
                            }

                            Console.WriteLine();
                            Console.WriteLine($"Nombre          Apellido            Dirección           Telefono            Email           Edad            Es Mejor Amigo?");
                            Console.WriteLine($"----------------------------------------------------------------------------------------------------------------------------");

                            foreach (var id in searchResults)
                            {
                                var isBestFriend = bestFriends[id];

                                string isBestFriendStr = (isBestFriend == true) ? "Si" : "No";
                                Console.WriteLine($"{firstNames[id]}         {lastNames[id]}         {addresses[id]}         {telephones[id]}            {emails[id]}            {ages[id]}          {isBestFriendStr}");
                            }
                            Console.WriteLine($"----------------------------------------------------------------------------------------------------------------------------");
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Inserta el email:");
                            string searchedEmail = Console.ReadLine() ?? "Anonymus";

                            foreach (var email in emails)
                            {
                                if (email.Value.Equals(searchedEmail))
                                {
                                    searchResults.Add(email.Key);
                                };
                            }

                            Console.WriteLine();
                            Console.WriteLine($"Nombre          Apellido            Dirección           Telefono            Email           Edad            Es Mejor Amigo?");
                            Console.WriteLine($"----------------------------------------------------------------------------------------------------------------------------");

                            foreach (var id in searchResults)
                            {
                                var isBestFriend = bestFriends[id];

                                string isBestFriendStr = (isBestFriend == true) ? "Si" : "No";
                                Console.WriteLine($"{firstNames[id]}         {lastNames[id]}         {addresses[id]}         {telephones[id]}            {emails[id]}            {ages[id]}          {isBestFriendStr}");
                            }
                            Console.WriteLine($"----------------------------------------------------------------------------------------------------------------------------");
                        }
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
            break;
        case 5: // Eliminar Contacto
            break;
        case 6: // Salir
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
    Console.WriteLine($"Nombre          Apellido            Dirección           Telefono            Email           Edad            Es Mejor Amigo?");
    Console.WriteLine($"----------------------------------------------------------------------------------------------------------------------------");

    foreach (var id in ids)
    {
        var isBestFriend = bestFriends[id];

        string isBestFriendStr = (isBestFriend == true) ? "Si" : "No";
        Console.WriteLine($"{firstNames[id]}         {lastNames[id]}         {addresses[id]}         {telephones[id]}            {emails[id]}            {ages[id]}          {isBestFriendStr}");
    }
    Console.WriteLine($"----------------------------------------------------------------------------------------------------------------------------");
}