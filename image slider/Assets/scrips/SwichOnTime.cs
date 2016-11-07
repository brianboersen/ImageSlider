using UnityEngine;
using System.Collections;

public class SwichOnTime : MonoBehaviour {
    public ImageSwicher imageSwicher;
    private DestroyImage destroy;
    void Start()
    {
        destroy = gameObject.GetComponent<DestroyImage>();
        imageSwicher = gameObject.GetComponent<ImageSwicher>();
        StartCoroutine(Swich(2.5f));
    }

    IEnumerator Swich(float wait)
    {


        while (true)
        {
            if(imageSwicher.num < imageSwicher.images.Length)
            {
                imageSwicher.num++;
            }
            else
            {
                imageSwicher.num = 0;
                imageSwicher.num++;
            }
            
            destroy.Destroy();
            imageSwicher.Swich();
            yield return new WaitForSeconds(wait);
        }

    }

}
