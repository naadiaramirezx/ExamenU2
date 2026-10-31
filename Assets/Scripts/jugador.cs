using UnityEngine;
using UnityEngine.SceneManagement;  //herramientas de la escena

public class jugador : MonoBehaviour
{
    private void OnCollisionEnter2D (Collision2D collision)
    
    {
        if (collision.gameObject.CompareTag("daño"))
        {
            Destroy(gameObject);

            //reiniciar juego
            SceneManager.LoadScene(
                //obtenemos la escena actual
                SceneManager.GetActiveScene().buildIndex
            );
        }
        
    }
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
