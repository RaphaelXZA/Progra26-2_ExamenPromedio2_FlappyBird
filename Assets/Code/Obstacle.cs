using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private void Update()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }
}
