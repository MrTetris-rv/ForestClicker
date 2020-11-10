using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AnimateButton : MonoBehaviour
{
    [SerializeField] GameObject effect;
    public void isPressed()
    {
        var clone = Instantiate(effect, transform.position, Quaternion.identity);
        Destroy(clone, 0.6f);
        GetComponent<Animation>().Play("New Animation");
    }
 

}
