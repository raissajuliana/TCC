using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2morteinimigo3 : MonoBehaviour
{
    public Animator anim;
 
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerLevel2.morte == 3)
        {
            anim.SetBool("emorreu", true);
        }
    }
}