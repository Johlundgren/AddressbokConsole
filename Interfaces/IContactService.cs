namespace AddressbokConsole.Interfaces;

public interface IContactService
{
    /// <summary>
    /// Add a contact to a contact list
    /// </summary>
    /// <param name="contact">a contact of type IContact</param>
    /// <returns>Return true if successful, or false if it fails or customer already exists</returns>
    bool AddContactToList(IContact contact);
    IEnumerable<IContact> GetContactsFromList();
    IContact GetContactFromList(string email);
}
