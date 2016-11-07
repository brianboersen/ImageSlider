using UnityEngine;
using System.Collections;

public class DestroyImage : MonoBehaviour {
    private GameObject[] images;

    

    public void Destroy()
    {
        images = GameObject.FindGameObjectsWithTag("image");

        if (images.Length != 0)
        {
            Destroy(images[0]);
        }

    }
}
