using TareaCuatro;

Console.WriteLine("Bienvenido a mi lista de Contactos");

bool isRunning = true;
List<Contact> contacts = new List<Contact>();

// Datos para pruebas
var contactOne = new Contact(1, "Jorge", "Arias", "Anacaona", "8099742836", "email@gmail.com", 31, false);
var contactTwo = new Contact(2, "Lui", "Acosta", "Anacaona", "8099742836", "email@gmail.com", 19, true);
contacts.Add(contactOne);
contacts.Add(contactTwo);

while (isRunning)
{
    Console.WriteLine(@"1. Agregar Contacto     2. Ver Contactos    3. Buscar Contactos     4. Modificar Contacto   5. Eliminar Contacto    6. Salir");
    Console.WriteLine("Digite el número de la opción deseada");

    int chosenOption = Convert.ToInt32(Console.ReadLine());

    switch (chosenOption)
    {
        case 1: // Agregar Contacto
            {
                AddContact(contacts);
            }
            break;
        case 2: // Ver Contactos
            {
                ViewContacts(contacts);
            }
            break;
        case 3: // Buscar Contactos
            {

                Console.WriteLine("Buscar por:");
                Console.WriteLine(@"1. Nombre    2. Apellido    3. Telefono     4. Direccion   5. Email    6. Regresar");
                Console.WriteLine("Digite el número de la opción deseada");

                chosenOption = Convert.ToInt32(Console.ReadLine());

                switch (chosenOption)
                {
                    case 1:
                        FindContacts("nombre", contacts);
                        break;
                    case 2:
                        FindContacts("apellido", contacts);
                        break;
                    case 3:
                        FindContacts("telefono", contacts);
                        break;
                    case 4:
                        FindContacts("direccion", contacts);
                        break;
                    case 5:
                        FindContacts("email", contacts);
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
            //        case 6: // Salir
            //            {
            //                Environment.Exit(0);
            //            }
            //            break;
            //        default:
            //            break;
    }
}

void AddContact(List<Contact> contacts)
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

    var id = contacts.Count + 1;
    var isIdTaken = contacts.Exists(c => c.Id == id);

    while (isIdTaken)
    {
        id += 1;
    }

    var newContact = new Contact(id, firstName, lastName, address, phone, email, age, isBestFriend);

    contacts.Add(newContact);
}

void ViewContacts(List<Contact> contacts)
{
    Console.WriteLine();
    Console.WriteLine($"Id          Nombre          Apellido            Dirección           Telefono            Email           Edad            Es Mejor Amigo?");
    Console.WriteLine($"--------------------------------------------------------------------------------------------------------------------------------------------");

    foreach (var contact in contacts)
    {
        string isBestFriendStr = (contact.IsBestFriend == true) ? "Si" : "No";

        Console.WriteLine($"{contact.Id}         {contact.FirstName}         {contact.LastName}         {contact.Address}         {contact.Phone}            {contact.Email}            {contact.Age}          {isBestFriendStr}");
    }
    Console.WriteLine($"--------------------------------------------------------------------------------------------------------------------------------------------");
}

void FindContacts(string searchString, List<Contact> contacts)
{
    List<Contact> searchResults = new List<Contact>();

    Console.WriteLine($"Inserta el {searchString}:");

    string target = Console.ReadLine() ?? "Anonymus";

    switch (searchString)
    {
        case "nombre":
            searchResults = contacts.FindAll(c => c.FirstName == target);
            break;
        case "apellido":
            searchResults = contacts.FindAll(c => c.LastName == target);
            break;
        case "telefono":
            searchResults = contacts.FindAll(c => c.Phone == target);
            break;
        case "direccion":
            searchResults = contacts.FindAll(c => c.Address == target);
            break;
        case "email":
            searchResults = contacts.FindAll(c => c.Email == target);
            break;
        default:
            Console.WriteLine("Opcion Invalida");
            break;
    }

    ViewContacts(searchResults);
}

void EditContact()
{
    ViewContacts(contacts);

    Console.WriteLine("Selecciona un contanto para modificar:");
    var targetId = Convert.ToInt32(Console.ReadLine());

    var targetContact = contacts.Find(c => c.Id == targetId) ?? null;

    if (targetContact == null)
    {
        Console.WriteLine("Contacto no encontrado.");
        return;
    };

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

    targetContact.FirstName = firstName;
    targetContact.LastName = lastName;
    targetContact.Address = address;
    targetContact.Phone = phone;
    targetContact.Email = email;
    targetContact.Age = age;
    targetContact.IsBestFriend = isBestFriend;

    Console.WriteLine("Contacto modificado.");
}

void DeleteContact()
{
    ViewContacts(contacts);
    Console.WriteLine("Selecciona un contanto para eliminar:");

    var targetId = Convert.ToInt32(Console.ReadLine());

    var targetContact = contacts.Find(c => c.Id == targetId);

    if (targetContact == null) return;

    contacts.Remove(targetContact);

    Console.WriteLine("Contacto eliminado.");
}