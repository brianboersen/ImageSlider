using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

    private ImageSwicher imageSwicher;
    private DestroyImage destroy;
    private int number = 0;

    void Start()
    {
        imageSwicher = gameObject.GetComponent<ImageSwicher>();
        destroy = gameObject.GetComponent<DestroyImage>();
    }

    public void Up ()
    {
        if (imageSwicher.num < imageSwicher.images.Length-1)
        {
           imageSwicher.num++;
        }
        else
        {
            imageSwicher.num = 0;
        }
        destroy.Destroy();
        imageSwicher.Swich();
	}
	
	
	public void Down ()
    {
        if (imageSwicher.num > 0)
        {
            imageSwicher.num--;
        }
        else
        {
            imageSwicher.num = 4;
        }
        destroy.Destroy();
        imageSwicher.Swich();
    }
   
}
