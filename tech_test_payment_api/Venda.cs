namespace tech_test_payment_api;

public class Venda
{
    public int Id { get; set; }
    public List<Produto> Produtos { get; set; }
    public Vendedor Vendedor { get; set; }
    public StatusDaVendaEnum Status { get; set; }
}