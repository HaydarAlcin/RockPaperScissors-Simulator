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
    }

    // Update is called once per frame
    void Update()
    {
        gm.GetComponent<MenuManager>().scissorsSoldier = gameObject.GetComponent<GameManager>().scissorsSoldier;
        gm.GetComponent<MenuManager>().paperSoldier = gameObject.GetComponent<GameManager>().paperSoldier;
        gm.GetComponent<MenuManager>().rockSoldier = gameObject.GetComponent<GameManager>().rockSoldier;
    }


    public void RockSoldierUpBtn()
    {
        rockSoldier++;
        rockText.text = rockSoldier.ToString();  
    }

    public void RockSoldierDownBtn()
    {
        rockSoldier--;
        rockText.text = rockSoldier.ToString();

        if (rockSoldier == 0)
        {
            rockSoldier = 1;
            rockText.text = rockSoldier.ToString();
        }
    }

    public void PaperSoldierUpBtn()
    {
        paperSoldier++;
        paperText.text = paperSoldier.ToString(); 
    }

    public void PaperSoldierDownBtn()
    {
        paperSoldier--;
        paperText.text = paperSoldier.ToString();

        if (paperSoldier == 0)
        {
            paperSoldier = 1;
            paperText.text = paperSoldier.ToString();
        }
    }

    public void ScissorsSoldierUpBtn()
    {
        scissorsSoldier++;
        scissorText.text = scissorsSoldier.ToString();
    }

    public void ScissorsSoldierDownBtn()
    {
        scissorsSoldier--;
        scissorText.text = scissorsSoldier.ToString();

        if (scissorsSoldier == 0)
        {
            scissorsSoldier = 1;
            scissorText.text = scissorsSoldier.ToString();
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
