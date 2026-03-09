class HealthPotion 
{
    int healAmount = 10;

    void Consume(Player player) 
    {
        player.Heal(healAmount); 
    }
}