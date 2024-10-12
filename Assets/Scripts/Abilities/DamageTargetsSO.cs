using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "DamageTargets", menuName = "ScriptableObjects/AbilityActions/DamageTargetsSO", order = 1)]
public class DamageTargetsSO : AbilityActionSO
{
    [SerializeField] private bool m_dealsFixedDamage;
    [SerializeField] private int m_fixedDamageAmount;

    // todo consider:
    // tracking the source of the damage? damage method takes in what cards were used? what type of damage it was?
    public override void Do(IReadOnlyCollection<CardData> cards, IReadOnlyCollection<ICreature> targets)
    {
        int damage = m_dealsFixedDamage ? m_fixedDamageAmount : cards.Sum(c => c.GetValue());

        foreach (var item in targets)
        {
            item.STUB_Damage(damage);
        }
    }

}
