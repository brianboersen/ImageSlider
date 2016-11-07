using UnityEngine;
using System.Collections;

public class ImageSwicher : MonoBehaviour {
   // [SerializeField]
    public GameObject[] images;
    public int num;
	// swiches from image to image
	public void Swich ()
    {   
        if(num < images.Length)
        {
            Instantiate(images[num], new Vector3(0, 0, 0), Quaternion.identity);
        }
        else
        {
            num = 0;
            Instantiate(images[num], new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
	
}
