using System.ComponentModel.DataAnnotations;

namespace ValorFuturo.Models
{
    public class ValorFuturoModel
    {
        [Required(ErrorMessage ="No se puede dejar el campo Inversion Mensual vacio")]
        [Range(100,50000,ErrorMessage ="El rango adminito para el campo Inversion Mensual debe ser entre 100 y 50000")]
        public decimal? InversionMensual { get; set; }

        [Required(ErrorMessage ="No se puede dejar el campo Interes Anual vacio")]
        [Range(1, 100,ErrorMessage ="El rango admitido para el interes anual debe ser entre 1 y 25")]
        public decimal? InteresAnual { get; set; }

        [Required(ErrorMessage ="No se puede dejar el campo Años vacio")]
        [Range(1,15,ErrorMessage ="El rango admitido para los Años debe ser entre 1 y 15")]
        public int? Años { get; set; }

        public decimal? CalcularValorFuturo()
        {

            int? meses = Años * 12;
            decimal? interesMensual = InteresAnual / 12 / 100;
            decimal? valorFuturo = 0;
            for (int i = 0; i < meses; i++)
            {
                valorFuturo = valorFuturo + InversionMensual * (1 + interesMensual);
            }

            return valorFuturo;

        }
    }
}
