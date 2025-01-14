using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
bool hasPackage = false;
[SerializeField]float DestroyDelay = 0;
[SerializeField] Color32 hasPackagecolor = new Color32 (1, 1, 1, 1);
[SerializeField] Color32 noPackagecolor = new Color32 (1, 1, 1, 1);

SpriteRenderer spriteRenderer;

 void Start() 
{
    spriteRenderer = GetComponent<SpriteRenderer>();
}
     void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("o");
    }
        void OnTriggerEnter2D(Collider2D other) 
        {
            if (other.tag == "Package" && !hasPackage)
            {
                Debug.Log("package picked up");
                hasPackage = true;
                spriteRenderer.color = hasPackagecolor;
                Destroy(other.gameObject, DestroyDelay);
            }

            if (other.tag == "Customer" && hasPackage)
            {
                Debug.Log("Package delivered");
                bool hasPackage = false;
                spriteRenderer.color = noPackagecolor;
            }
        }
}

