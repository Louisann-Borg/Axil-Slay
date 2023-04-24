using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class KelpCollisionHandler : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(3);
    }
}
