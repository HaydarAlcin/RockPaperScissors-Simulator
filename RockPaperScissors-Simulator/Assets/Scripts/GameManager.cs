using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gm;
    public GameObject panel;

    public float paperSoldier, rockSoldier, scissorsSoldier;

    public Text paperText,rockText,scissorText;

    private void Start()
    {
        panel.SetActive(false);
        gm.GetComponent<MenuManager>().rockSoldier = rockSoldier;
        gm.GetComponent<MenuManager>().paperSoldier = paperSoldier;
        gm.GetComponent<MenuManager>().scissorsSoldier = scissorsSoldier;
    }

    


    public void RockSoldierUpBtn()
    {
        rockSoldier++;
        rockText.text = rockSoldier.ToString();
        gm.GetComponent<MenuManager>().rockSoldier = rockSoldier;
    }

    public void RockSoldierDownBtn()
    {
        rockSoldier--;
        rockText.text = rockSoldier.ToString();
        gm.GetComponent<MenuManager>().rockSoldier = rockSoldier;

        if (rockSoldier == 0)
        {
            rockSoldier = 1;
            rockText.text = rockSoldier.ToString();
            gm.GetComponent<MenuManager>().rockSoldier = rockSoldier;
        }
    }

    public void PaperSoldierUpBtn()
    {
        paperSoldier++;
        paperText.text = paperSoldier.ToString();
        gm.GetComponent<MenuManager>().paperSoldier = paperSoldier;
    }

    public void PaperSoldierDownBtn()
    {
        paperSoldier--;
        paperText.text = paperSoldier.ToString();
        gm.GetComponent<MenuManager>().paperSoldier = paperSoldier;

        if (paperSoldier == 0)
        {
            paperSoldier = 1;
            paperText.text = paperSoldier.ToString();
            gm.GetComponent<MenuManager>().paperSoldier = paperSoldier;
        }
    }

    public void ScissorsSoldierUpBtn()
    {
        scissorsSoldier++;
        scissorText.text = scissorsSoldier.ToString();
        gm.GetComponent<MenuManager>().scissorsSoldier = scissorsSoldier;
    }

    public void ScissorsSoldierDownBtn()
    {
        scissorsSoldier--;
        scissorText.text = scissorsSoldier.ToString();
        gm.GetComponent<MenuManager>().scissorsSoldier = scissorsSoldier;

        if (scissorsSoldier == 0)
        {
            scissorsSoldier = 1;
            scissorText.text = scissorsSoldier.ToString();
            gm.GetComponent<MenuManager>().scissorsSoldier = scissorsSoldier;
        }
    }


    public void StartBtn()
    {
        SceneManager.LoadScene(1);

    }

    public void PlayBtn() 
    {
        panel.SetActive(true);
        
    }
}
