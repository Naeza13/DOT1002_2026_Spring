
float cooldown = 5f; 

void Update() 
{
    if (cooldown > 0) {
        cooldown -= Time.deltaTime;
    }
}   