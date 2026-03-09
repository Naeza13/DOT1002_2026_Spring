class Spaceship 
{
    float moveSpeed = 5f;

    void MoveHorizontal(float input) {
        transform.Translate(Vector3.right * input * moveSpeed * Time.deltaTime);
    }
}