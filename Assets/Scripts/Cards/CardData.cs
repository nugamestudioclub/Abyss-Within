public class CardData
{
    private SuitType m_suit;
    private int m_value;

    public CardData(SuitType suit, int value)
    {
        ThrowIfInvalid(value);

        m_suit = suit;
        m_value = value;
    }

    public void SetValue(int value)
    {
        ThrowIfInvalid(value);

        m_value = value;
    }

    public int GetValue() { return m_value; }
    public SuitType GetSuit() { return m_suit; }


    public void SetSuit(SuitType suit) { m_suit = suit; }

    private void ThrowIfInvalid(int value)
    {
        if (value < 2 || value > 13) throw new System.ArgumentException("Card value not in range!");
    }
}
