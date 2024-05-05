using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{

    private Vector3 destination;
    [SerializeField] float speed;
    
    private void Update() {
        Vector3 direction = destination - transform.position;
        transform.position += speed * Time.deltaTime * direction.normalized;

        if (Input.GetKeyDown(KeyCode.Mouse0)){
            Move(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
    }

    private void Move(Vector3 destination){
        this.destination = destination;

    }

}
