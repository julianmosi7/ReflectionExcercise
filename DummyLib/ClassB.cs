namespace DummyLib
{
  /// <summary>
  /// Abgeleitete Klasse für DummyLib
  /// </summary>
  public class ClassB : ClassA
  {
    /// <summary>
    /// Retourniert den Wert / 10
    /// </summary>
    /// <param name="val">Wert, der dividiert werden soll</param>
    /// <returns>Wert / 10</returns>
    public override int F(int val) => val / 10;

    /// <summary>
    /// Retourniert den Quotient der beiden Parameter
    /// </summary>
    /// <param name="valA">Erster Wert</param>
    /// <param name="valB">Zweiter Wert</param>
    /// <returns>valA / valB</returns>
    public override int G(int valA, int valB) => valA / valB;

  }
}
