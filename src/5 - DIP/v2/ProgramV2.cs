namespace _5___DIP
{
    class ProgramV2
    {
        static void Main(string[] args)
        {
            // Aplicando o DIP, estamos invertendo a dependência, já que dentro de ClientBO 
            // contém apenas uma abstração do comportamento de ClientRepository e estamos também 
            // invertendo o controle, pois ele é  fornecido de fora da classe.
            ClientV2 ClientV2 = new ClientV2 { Name = "Zézinho" };

            ClientV2BO ClientV2Business = new ClientV2BO(new ClientV2Repository());

            ClientV2Business.SaveClientV2(ClientV2);
        }
    }
}
