using System.Collections.Generic;
using UnityEngine;

public abstract class AbilityActionSO : ScriptableObject, IAbilityAction
{
    public abstract void Do(IReadOnlyCollection<CardData> cards, IReadOnlyCollection<ICreature> targets);
}
