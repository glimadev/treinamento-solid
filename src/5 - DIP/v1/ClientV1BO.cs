namespace _5___DIP.v1
{
    public class ClientV1BO
    {
        private ClientV1DAO obj;

        public void SaveClient(ClientV1 client)
        {
            obj = new ClientV1DAO();
            obj.Save(client);
        }
    }
}
