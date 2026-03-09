void Spawn(GameObject enemyPrefab) 
{
    Vector3 spawnPos = transform.position + new Vector3(0, 1, 0);
    
    Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    
    PlaySpawnParticle(spawnPos);
}