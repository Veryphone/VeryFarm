using UnityEngine;

public class DiamondEffectScript : MonoBehaviour
{
    public UILabel Label;
    AudioControl audioControl;
    void Start()
    {
        audioControl = GameObject.Find("AudioControl").GetComponent<AudioControl>();
        audioControl.PlaySound("Kim cuong roi xuong");
    }
	public void setValueDiamond(int value, string sortingLayerName = "15")
    {
        Label.text = value.ToString();
		this.GetComponentInChildren<ParticleSystem>().GetComponent<Renderer>().sortingLayerName = sortingLayerName;
    }
    public void Destroy()
    {
        GameObject.Destroy(this.gameObject);
    }
}
