using UnityEngine;

public class BackgroundAdjust : MonoBehaviour
{
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        Vector3 bgScale = transform.localScale;
        bgScale = Vector3.one;

        float camHeight = Camera.main.orthographicSize*2f;
        float camWidth = camHeight*Camera.main.aspect;

        Vector3 bgSize = sr.sprite.bounds.size;
        bgScale.x = camWidth/bgSize.x;
        bgScale.y = camHeight/bgSize.y;
        transform.localScale = bgScale;
    }
}