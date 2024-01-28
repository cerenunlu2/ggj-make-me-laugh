using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Sprite[] sprites; // Karakterin farklý durumlarýný içeren sprite dizisi
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Klavyeden giriþi kontrol et
        if (Input.GetKey(KeyCode.UpArrow))
        {
            ChangeSprite(0); // Yukarýya dönük sprite'ý göster
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            ChangeSprite(1); // Aþaðýya dönük sprite'ý göster
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            ChangeSprite(2); // Sola dönük sprite'ý göster
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            ChangeSprite(3); // Saða dönük sprite'ý göster
        }
    }

    void ChangeSprite(int spriteIndex)
    {
        // Belirli bir sprite'ý göstermek için spriteRenderer'ý güncelle
        if (spriteIndex >= 0 && spriteIndex < sprites.Length)
        {
            spriteRenderer.sprite = sprites[spriteIndex];
        }
    }
}
