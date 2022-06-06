using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToplanabilirKup : MonoBehaviour
{
    bool toplandimi;
    int index;
    public Toplayici toplayici;

    void Start()
    {
        toplandimi = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (toplandimi==true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }

        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Engel")
        {
            toplayici.yukseklikAzalt();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
    public bool GetToplandimi()
    {
        return toplandimi;
    }
    public void toplandiYap()
    {
        toplandimi = true;
    }
    public void indexAyarla(int index)
    {
        this.index = index;
    }
}
