namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes, Suite suite)
        {
            if (hospedes.Count <= suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A capacidade da suíte é menor que o número de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes(List<Pessoa> hospedes)
        {
            return hospedes.Count;
        }

        public decimal CalcularValorDiaria(Suite suite)
        {
            decimal valor = DiasReservados * suite.ValorDiaria;
            decimal desconto = valor * 0.10m;

            if (DiasReservados >= 10)
            {
                valor = valor - desconto;
            }

            return valor;
        }
    }
}