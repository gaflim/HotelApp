namespace HotelApp.Models;

public class Hospedagem
{
    public Quarto? QuartoSelec { get; set; }
    public int QntAdulto { get; set; }
    public int QntCrianca { get; set; }
    public DateTime DataCheckIn { get; set; }
    public DateTime DataCheckOut { get; set; }

    public int Estadia
    {
        get => DataCheckOut.Subtract(DataCheckIn).Days;
    }

    public double ValorTotal
    {
        get
        {
            double valorAdultos = QntAdulto * QuartoSelec.ValAdulto;
            double valorCrianca = QntCrianca * QuartoSelec.ValCrianca;
            
            double total = (valorAdultos + valorCrianca) * Estadia;
            return total;
        }
    }
}