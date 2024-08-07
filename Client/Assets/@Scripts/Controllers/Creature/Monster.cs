using static Define;

public class Monster : Creature
{
    public override bool Init()
    { 
        if (base.Init() == false)
            return false;

        CreatureType = ECreatureType.Monster;
        CreatureState = ECreatureState.Idle;
        Speed = 5.0f;

        return true;
    }
}
