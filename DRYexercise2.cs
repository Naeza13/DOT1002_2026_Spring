void Ses(AudioClip dosya) 
{
    GetComponent<AudioSource>().PlayOneShot(dosya);
}

void Jump() 
{
    Ses(jumpSound); 
    rb.velocity = Vector2.up * jumpForce;
}

void Shoot() 
{
    Ses(shootSound);
    Instantiate(bullet);
}