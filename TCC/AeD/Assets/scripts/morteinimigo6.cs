using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class morteinimigo6 : MonoBehaviour
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
        if (Player.morte == 6)
        {
            anim.SetBool("morreu", true);
        }
    }
}
