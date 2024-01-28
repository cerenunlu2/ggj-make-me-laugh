using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Sprite[] sprites; // Karakterin farkl� durumlar�n� i�eren sprite dizisi
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Klavyeden giri�i kontrol et
        if (Input.GetKey(KeyCode.UpArrow))
        {
            ChangeSprite(0); // Yukar�ya d�n�k sprite'� g�ster
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            ChangeSprite(1); // A�a��ya d�n�k sprite'� g�ster
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            ChangeSprite(2); // Sola d�n�k sprite'� g�ster
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            ChangeSprite(3); // Sa�a d�n�k sprite'� g�ster
        }
    }

    void ChangeSprite(int spriteIndex)
    {
        // Belirli bir sprite'� g�stermek i�in spriteRenderer'� g�ncelle
        if (spriteIndex >= 0 && spriteIndex < sprites.Length)
        {
            spriteRenderer.sprite = sprites[spriteIndex];
        }
    }
}
