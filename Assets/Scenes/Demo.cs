using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    int i = 10;
    int j = 5;
    int ans;
    // Start is called before the first frame update
    void Start()
    {
        ans = i%j;
        Debug.Log(ans);
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 10; i++;)
        {
            Debug.Log(i);
        }
        
    }
}
