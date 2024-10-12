using System.Collections.Generic;

public interface IAbilityAction
{
    void Do(IReadOnlyCollection<CardData> cards, IReadOnlyCollection<ICreature> targets);
}
