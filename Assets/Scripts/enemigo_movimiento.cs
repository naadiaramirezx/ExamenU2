using UnityEngine;

public class enemigo_movimiento : MonoBehaviour
{
    public float speed = 3f;
    private Rigidbody2D rb;

    //guarda el movimiento del enemigo y empieza en la derecha
    private Vector2 cambioDireccion = Vector2.right;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.gravityScale = 0;
        //comienza moviendose a la derecha a speed de 3UxS
        rb.linearVelocity = cambioDireccion * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //cuando el enemigo choque con pared
        if (collision.gameObject.CompareTag("pared"))
        {
            // //se generan direcciones aleatorias
            float x = Random.Range(-1f, 2f);
            float y = Random.Range(-1f, 2f);

             //se invierten las direcciones al colisionar
             //cambioDireccion = -cambioDireccion;
            cambioDireccion = new Vector2(x,y).normalized;

            //Cuando ocurre una colisión, invertimos la dirección y actualizamos la velocidad.
            rb.linearVelocity = cambioDireccion * speed;
        }

       

        
    }
}