using UnityEngine;

public class BackgroundAdjust : MonoBehaviour
{
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        Vector3 bgScale = transform.localScale;
        bgScale = Vector3.one;

        float cameraHeight = Camera.main.orthographicSize*2f;
        float cameraWidth = cameraHeight*Camera.main.aspect;

        Vector3 bgSize = sr.sprite.bounds.size;
        bgScale.x = cameraWidth/bgSize.x;
        bgScale.y = cameraHeight/bgSize.y;
        transform.localScale = bgScale;
    }
}