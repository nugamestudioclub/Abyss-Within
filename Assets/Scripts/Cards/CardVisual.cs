using TMPro;
using UnityEngine;

public class CardVisual : MonoBehaviour
{
    [SerializeField] private TextMeshPro m_suitText;
    [SerializeField] private TextMeshPro m_valueText;

    public void SetData(CardData data)
    {
        SetSuitText(data.GetSuit());
        SetValueText(data.GetValue());
    }

    public void SetSuitText(SuitType suit)
    {
        m_suitText.text = suit.ToString();
    }

    public void SetValueText(int value)
    {
        m_valueText.text = value.ToString();
    }
}
