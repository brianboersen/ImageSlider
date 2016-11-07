using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//[RequireComponent (typeof (AudioSource))]
public class PlayClip : MonoBehaviour
{
    private MovieTexture mt;
    void Start()
    {
        Debug.Log("test");
        RawImage currentImage = GetComponent<RawImage>();//.texture = movie as MovieTexture;        
        //movie.Play();
         mt = (MovieTexture)currentImage.mainTexture;
        
            
    }

    void Update()
    {
        mt.Play();
    }
}