using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = touch.position;

            

            if (touchPosition.y > Screen.height / 2 && touchPosition.x > Screen.width / 4 && touchPosition.x < Screen.width * 3 / 4) { //Este crea solo una zona en la parte superior , evitando la superposición de cada una de las áreas- 
                MoveCharacter(transform.forward);
            }
            // Mover personaje hacia atrás si se toca la parte inferior de la pantalla
            else if (touchPosition.y < Screen.height / 2 && touchPosition.x > Screen.width / 4 && touchPosition.x < Screen.width * 3 / 4) { //Lo mismo que el de arriba, pero considerando sólo debajo. La diferencia con el de otro es que no se superpone. 
                MoveCharacter(-transform.forward);
            }
            // Mover personaje hacia la derecha si se toca el lado derecho de la pantalla
            else if (touchPosition.x > Screen.width * 3 / 4) {
                MoveCharacter(transform.right);
            }
            // Mover personaje hacia la izquierda si se toca el lado izquierdo de la pantalla
            else if (touchPosition.x < Screen.width / 4) {
                MoveCharacter(-transform.right);
            }
        }
                /*

            if (touchPosition.y > Screen.height / 2){
                MoveCharacter(transform.forward);
            }
            if (touchPosition.y < Screen.height / 2){
                MoveCharacter(-transform.forward);
            }
            if (touchPosition.x < Screen.height * 3/4){
                MoveCharacter(transform.right);
            }
            if (touchPosition.x > Screen.height / 4){
                MoveCharacter(-transform.right);
            }
        }
        */


/*------Este código hace que el jugador literalmente se mueva hacia arriba de la pantalla
            // Comparar la posición del toque con el centro de la pantalla
            if (touchPosition.x < Screen.width / 2 && touchPosition.y > Screen.height / 2) {
                // Mover personaje hacia arriba
                MoveCharacter(Vector3.up);
            } else if (touchPosition.x < Screen.width / 2 && touchPosition.y < Screen.height / 2) {
                // Mover personaje hacia abajo
                MoveCharacter(Vector3.down);
            } else if (touchPosition.x > Screen.width / 2 && touchPosition.y > Screen.height / 2) {
                // Mover personaje hacia la derecha
                MoveCharacter(Vector3.right);
            } else if (touchPosition.x > Screen.width / 2 && touchPosition.y < Screen.height / 2) {
                // Mover personaje hacia la izquierda
                MoveCharacter(Vector3.left);
            }
            */     
    

    void MoveCharacter(Vector3 direction)
    {
        transform.Translate(direction * moveSpeed * Time.deltaTime, Space.World);
    }

    }
}

