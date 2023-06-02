using UnityEngine;

public class Tube : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float destroyLine = -4;
    

    void Update()
    {
        if (transform.position.x < destroyLine) Destroy(gameObject);
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    public void SetSpeed(float newSpeed)
    {
        if (speed >= 0) speed = newSpeed;
        else speed = 0;
    }
}
