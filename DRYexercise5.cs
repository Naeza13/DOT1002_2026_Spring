
float haritaSiniri = 100f; 

void MoveRight() 
{
    if (transform.position.x < haritaSiniri) {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}

void MoveLeft() 
{
    if (transform.position.x > -haritaSiniri) {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}   