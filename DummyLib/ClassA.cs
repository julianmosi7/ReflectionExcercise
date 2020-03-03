namespace DummyLib
{
  /// <summary>
  /// Basisklasse der DummyLib
  /// </summary>
  public class ClassA
  {

    /// <summary>
    /// Retourniert den Wert * 10
    /// </summary>
    /// <param name="val">Wert, der multipliziert werden soll</param>
    /// <returns>Wert * 10</returns>
    public virtual int F(int val) => val * 10;

    /// <summary>
    /// Retourniert das Produkt der beiden Parameter
    /// </summary>
    /// <param name="valA">Erster Wert</param>
    /// <param name="valB">Zweiter Wert</param>
    /// <returns>valA * valB</returns>
    public virtual int G(int valA, int valB) => valA * valB;

  }
}
