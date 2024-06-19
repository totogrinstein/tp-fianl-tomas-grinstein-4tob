using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visualizarcript : MonoBehaviour
{
    public GameObject[] arrayobjetos;
    private int idx = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            DesactivateALL();
            arrayobjetos[idx].SetActive(true);
            if (idx!= arrayobjetos.Length -1)
            {
                idx++;
            }

            Debug.Log(idx);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            DesactivateALL();
            arrayobjetos[idx].SetActive(true);
            if (idx != 0)
            {
                idx--;
            }
            Debug.Log(idx);
        }
       

    }
    void DesactivateALL()
    {
        foreach (var objeto in arrayobjetos)
        {
            objeto.SetActive(false);
        }
    }
}
