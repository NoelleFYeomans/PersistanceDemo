using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Canvas TitleScreenUI;
    public Canvas Level1UI;
    public Canvas Level2UI;
    public Canvas Level3UI;

    public void TitlescreenActive()
    {
        TitleScreenUI.gameObject.SetActive(true);
        Level1UI.gameObject.SetActive(false);
        Level2UI.gameObject.SetActive(false);
        Level3UI.gameObject.SetActive(false);

        Cursor.visible = true;
    }

    public void Level1Active()
    {
        TitleScreenUI.gameObject.SetActive(false);
        Level1UI.gameObject.SetActive(true);
        Level2UI.gameObject.SetActive(false);
        Level3UI.gameObject.SetActive(false);

        Cursor.visible = true;
    }

    public void Level2Active()
    {
        TitleScreenUI.gameObject.SetActive(false);
        Level1UI.gameObject.SetActive(false);
        Level2UI.gameObject.SetActive(true);
        Level3UI.gameObject.SetActive(false);

        Cursor.visible = true;
    }

    public void Level3Active()
    {
        TitleScreenUI.gameObject.SetActive(false);
        Level1UI.gameObject.SetActive(false);
        Level2UI.gameObject.SetActive(false);
        Level3UI.gameObject.SetActive(true);

        Cursor.visible = true;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
