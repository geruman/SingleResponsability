namespace SingleResponsability
{
    public class Order
    {
        public string Email {get;set;}
        public Order(string mailDestino)
        {
            Email = mailDestino;
        }
    }
}