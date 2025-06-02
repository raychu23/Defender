using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CorrectLogo : MonoBehaviour {

    public Sprite tigerSamplingLogo;

	// Use this for initialization
	void Start () {
        Image thisImage = this.GetComponent<Image>();
        thisImage.sprite = tigerSamplingLogo;
     
	}
}
