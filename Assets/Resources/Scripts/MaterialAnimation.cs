using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialAnimation : MonoBehaviour
{
    Renderer rend;

    public float AnimationSpeed;
    public Vector2 Tiling;
    float offset;



    private void Awake()
    {
        rend = GetComponent<Renderer>();
        rend.material.SetTextureScale("_MainTex", Tiling);
    }

    // Update is called once per frame
    void Update()
    {
        offset -= Time.deltaTime * AnimationSpeed;

        rend.material.SetTextureOffset("_MainTex", new Vector2(0,offset));
    }
}
