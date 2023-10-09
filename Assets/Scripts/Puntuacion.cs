using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Puntuacion : MonoBehaviour
{
    public int puntuacionA;
    public TMP_Text puntuacionAtexto;
    public int puntuacionB;
    public TMP_Text puntuacionBtexto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntuacionAtexto.text = puntuacionA.ToString();
        puntuacionBtexto.text = puntuacionB.ToString();

        if (puntuacionA > 10 || puntuacionB > 10)
        {
            SceneManager.LoadScene("MenuPrincipal");
        }
    }
}
