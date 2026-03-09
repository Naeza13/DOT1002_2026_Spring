class CollectibleDot 
{
    int pointValue = 10;

    void Collect(Player player) 
    {
        player.AddScore(pointValue);
    }
}