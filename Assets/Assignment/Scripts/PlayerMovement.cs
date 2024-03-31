using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform plyr;
    public GameObject projectile;
    private float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float keyboardInput = Input.GetAxis("Vertical");
        transform.Translate(0, keyboardInput * speed * Time.deltaTime, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile, plyr.position, plyr.rotation);
        }
    }

    
}
