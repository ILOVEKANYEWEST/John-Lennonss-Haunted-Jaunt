using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveMent : MonoBehaviour
{


    vector3 m_Movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        m_Movement.Set(horizontal, 0f, vertical);
        m_Movement.Normlize();

        bool hasHorizontalInput = !Mathf.Approximately (horizontal) ,0f;
        bool hasVeritcalInput = !Mathf.Approximately(horizontal),0f;

        bool isWalking = hasHorizontalInput || hasVeritcalInput;

    }
}
