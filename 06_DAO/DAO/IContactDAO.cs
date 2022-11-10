using _06_DAO.Model;


namespace _06_DAO.DAO
{
    public interface IContactDAO
    {
        void AddContact(Contact c);

        List<Contact> GetAll();
    }
}
