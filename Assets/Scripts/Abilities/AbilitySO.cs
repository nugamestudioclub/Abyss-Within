using System.Collections.Generic;
using TNRD;
using UnityEngine;

[CreateAssetMenu(fileName = "DamageTargets", menuName = "ScriptableObjects/AbilitySO", order = 1)]
public class AbilitySO : ScriptableObject
{
    [SerializeField] private List<SerializableInterface<IAbilityAction>> m_abilityActions;

    // same signature as IAbilityAction's method. They could be one in the same, but for now I'll leave them separate
    public void UseAbility(IReadOnlyCollection<CardData> cards, IReadOnlyCollection<ICreature> targets)
    {
        m_abilityActions.ForEach(a => a.Value.Do(cards, targets));
    }
}
