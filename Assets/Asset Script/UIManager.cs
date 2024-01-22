using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform MenuUtama, MenuInformasi, MenuPetunjuk;
    // Start is called before the first frame update
    void Start()
    {
        MenuUtama.DOAnchorPos(new Vector2(0,0), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -3000), 1.0f);
    }
    public void MenuUtamabutton()
    {
        MenuUtama.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -3000), 1.0f);
    }
    public void MenuInformasibutton()
    {
        MenuUtama.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, -3000), 1.0f);
    }
    public void MenuPetunjukbutton()
    {
        MenuUtama.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }

}
