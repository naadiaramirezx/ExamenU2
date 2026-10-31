using UnityEngine;

public class movimiento_player : MonoBehaviour
{
    //velocidad del jugador
    public float speed = 5f;
  
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        //detectar mov  horizontal
        float x = Input.GetAxisRaw("Horizontal");

        //detectar mov vertical
        float y = Input.GetAxisRaw("Vertical");

        //movimiento en las zonas x,y,z
        Vector3 movimiento = new Vector3(x,y,0);

        transform.Translate(movimiento * speed * Time.deltaTime);
        
    }
}
