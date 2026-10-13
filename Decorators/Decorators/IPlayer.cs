public interface IPlayer
{
    float GetSpeed();
    int GetArmour();
}
public class Player : IPlayer
{
    public float GetSpeed()
    {
        float baseSpeed = 5.0f;
        return baseSpeed;
    }
    public int GetArmour()
    {
        int baseArmour = 0;
        return baseArmour;
    }
}
public abstract class PlayerDecorator : IPlayer
{
    protected IPlayer player;
    public PlayerDecorator(IPlayer player)
    {
        this.player = player;
    }
    public virtual float GetSpeed()
    {
        return player.GetSpeed();
    }
    public virtual int GetArmour()
    {
        return player.GetArmour();
    }
}
public abstract class EquippedArmour : PlayerDecorator
{
    public EquippedArmour(IPlayer player) : base(player) { }
}
class IronBreastPlate : EquippedArmour
{
    public IronBreastPlate(IPlayer player) : base(player) { }
    public override int GetArmour()
    {
        int currentArmour = player.GetArmour();
        int armourBuff = 15;
        return currentArmour + armourBuff;
    }
}
class IronBoots : EquippedArmour
{
    public IronBoots(IPlayer player) : base(player) { }
    public override int GetArmour()
    {
        int currentArmour = player.GetArmour();
        int armourBuff = 5;
        return currentArmour + armourBuff;
    }
}
public abstract class StatusEffects : PlayerDecorator
{
    public StatusEffects(IPlayer player) : base(player) { }
}
class SpeedPotion : StatusEffects
{
    public SpeedPotion(IPlayer player) : base(player) { }
    public override float GetSpeed()
    {
        float currentSpeed = player.GetSpeed();
        float SpeedBuff = 1.2f;
        return currentSpeed * SpeedBuff;
    }
}
class SlownessPotion : StatusEffects
{
    public SlownessPotion(IPlayer player) : base(player) { }
    public override float GetSpeed()
    {
        float currentSpeed = player.GetSpeed();
        float SpeedDebuff = 0.67f;
        return currentSpeed * SpeedDebuff;
    }
}