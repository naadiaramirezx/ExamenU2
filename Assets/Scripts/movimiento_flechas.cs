using UnityEngine;

public class movimiento_flechas : MonoBehaviour
{
    public float velocidad = 5f;
    
    //guardar direccion del jugador para mov continuo
    private Vector3 direccion = Vector3.zero;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow ) || Input.GetKey(KeyCode.W))
            direccion = Vector3.up;

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            // transform.Translate(Vector3.down * velocidad * Time.deltaTime);
            direccion = Vector3.down;

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        direccion = Vector3.left;
            

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        direccion = Vector3.right;

        transform.Translate(direccion * velocidad * Time.deltaTime);
            
    }
}

//movimiento continuo -> guardar direccion en una var