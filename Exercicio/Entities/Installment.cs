namespace ExercicioDeFixacao.Entities
{
    public class Installment //Parcela
    {
        public DateTime DueDate { get; set; } //Data de vencimento
        public double Amount { get; set; } // Montante

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

    }
}
