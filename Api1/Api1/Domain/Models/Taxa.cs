namespace Api1.Domain.Models
{
   /// <summary>
   /// Classe que representa uma Taxa.
  /// </summary>
  public class Taxa
  {
    /// <summary>
    /// Propriedade que retorna/seta o valor da taxa.
    /// </summary>
    public decimal Value { get; private set; }
    
    /// <summary>
    /// Construtor da classe Taxa.
    /// </summary>
    /// <param name="taxa"></param>
    public Taxa(decimal taxa)
    {
      Value = taxa;      
    }
  }
}
