using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class morteinimigolevel33 : MonoBehaviour
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
        if (PlayerLevel3.morte == 3)
        {
            anim.SetBool("emorreu", true);
        }
    }
}
