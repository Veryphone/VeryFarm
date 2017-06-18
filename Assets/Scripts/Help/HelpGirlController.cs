using UnityEngine;
using System.Collections;

public class HelpGirlController : MonoBehaviour {

    public static Animator animator;

	
	void Start () {
        animator = GetComponent<Animator>();
        SetIDLayer("15");
	}
	
	
	void Update () {
	}

	void SetIDLayer(string sortingLayerName)
    {
        Transform[] transforms = gameObject.GetComponentsInChildren<Transform>(true);

        for (int i = 0; i < transforms.Length; i++)
        {
            GameObject gObject = transforms[i].gameObject;
            if (gObject.GetComponent<SpriteRenderer>() != null)
            {
				gObject.GetComponent<SpriteRenderer>().sortingLayerName = sortingLayerName;
            }
        }
    }
    void ResetAnimation()
    {
        //animator.SetTrigger("Stand");

    }
}
