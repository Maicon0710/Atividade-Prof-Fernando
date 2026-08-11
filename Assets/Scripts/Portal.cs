using UnityEngine;
using UnityEngine.SceneManagement;
public class Portal : MonoBehaviour
{
    public class Obstaculo : MonoBehaviour
    {
        public GameManager gameManager;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                SceneManager.LoadScene("Fase2");
            }
        }

    }
}
