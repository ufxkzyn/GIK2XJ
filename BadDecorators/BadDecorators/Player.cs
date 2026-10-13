public class Player
{
	float baseSpeed = 5.0f;
	
	public bool hasSpeedPotion = false;
	public bool hasSlownessPotion = false;

    public float GetSpeed()
	{
		float speed = baseSpeed;

		if (hasSlownessPotion)
			speed *= 1.2f;
		if (hasSpeedPotion)
			speed *= 0.67f;

		return speed;
    }
}
