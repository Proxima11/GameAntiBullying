using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Soal : MonoBehaviour
{

    public TextAsset assetSoal;

    private string[] soal;

    private string[,] soalBag;


    int indexSoal;
    int maxSoal;
    bool ambilSoal;
    char kunciJ;

    bool[] soalSelesai;

    public Text txtSoal, txtOpsiA, txtOpsiB, txtOpsiC, txtOpsiD,txtScore, txtTime;

    bool isHasil;
    private float durasi, durasiGame;
    public float durasiPenilaian;

    int jwbBenar, jwbSalah;

    GameVariable gameVariable;

    public GameObject panel;
    public GameObject imgPenilaian, imgHasil, ButtonA, ButtonB, ButtonC, ButtonD;
    public Text txtHasil;


    // Start is called before the first frame update
    void Start()
    {
        gameVariable = FindObjectOfType<GameVariable>();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        txtScore.text = "Score : " + superScript.score;
        panel.SetActive(false);
        SalahObj.SetActive(false);
        BenarObj.SetActive(false);
        durasiGame=150f;
        durasi = durasiPenilaian;
        txtTime.text = "Time: " + (int)durasiGame;
        soal = assetSoal.ToString().Split('#');

        soalSelesai = new bool[soal.Length];

        soalBag = new string[soal.Length, 6];
        maxSoal = 5;
        OlahSoal();

        ambilSoal = true; 
        TampilkanSoal();

        print(soalBag[1,3]);

    }

    private void OlahSoal()
    {
        for (int i=0; i < soal.Length; i++)
        {
            string[] tempSoal = soal[i].Split('@');
            for(int j = 0; j < tempSoal.Length; j++)
            {
                soalBag[i, j] = tempSoal[j];
                continue;
            }
            continue;
        }
    }

    private void TampilkanSoal()
    {
        if (indexSoal<maxSoal)
        {
            if(ambilSoal)
            {
                for (int i = 0; i < soal.Length; i++)
                {
                    int randomIndexSoal = Random.Range(0, soal.Length);
                    if(!soalSelesai[randomIndexSoal])
                    {
                        txtSoal.text = soalBag[randomIndexSoal, 0];
                        txtOpsiA.text = soalBag[randomIndexSoal, 1];
                        txtOpsiB.text = soalBag[randomIndexSoal, 2];
                        txtOpsiC.text = soalBag[randomIndexSoal, 3];
                        txtOpsiD.text = soalBag[randomIndexSoal, 4];
                        kunciJ = soalBag[randomIndexSoal, 5][0];

                        soalSelesai[randomIndexSoal] = true;

                        ambilSoal = false;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                if(gameVariable.score <= 20){
                    gameVariable.TakeStress(5);
                }else if(gameVariable.score <= 50){
                    gameVariable.TakeStress(2);
                }else if(gameVariable.score >= 80){
                    gameVariable.TakeStress(-2);
                }else if(gameVariable.score >= 65){
                    gameVariable.TakeStress(-5);
                }
                
            }
        }
    }

   
    public void Opsi(string opsiHuruf)
    {
       CheckJawaban(opsiHuruf[0]);
        
       if(indexSoal == maxSoal - 1)
        {
            isHasil = true;
        }
        else
        {
            indexSoal++;
            ambilSoal = true;
        }

        panel.SetActive(true);
    }

    public GameObject BenarObj;
    public GameObject SalahObj;
    private void CheckJawaban(char huruf)
    {
        if (huruf.Equals(kunciJ))
        {
            if (kunciJ.Equals('A')){
                ButtonB.SetActive(false);
                ButtonC.SetActive(false);
                ButtonD.SetActive(false);
            }
            else if (kunciJ.Equals('B')){
                ButtonA.SetActive(false);
                ButtonC.SetActive(false);
                ButtonD.SetActive(false);
            }
            else if (kunciJ.Equals('C'))
            {
                ButtonB.SetActive(false);
                ButtonA.SetActive(false);
                ButtonD.SetActive(false);
            }
            else if (kunciJ.Equals('D'))
            {
                ButtonB.SetActive(false);
                ButtonC.SetActive(false);
                ButtonA.SetActive(false);
            }
            BenarObj.SetActive(true);
            SalahObj.SetActive(false);
            jwbBenar++;
            gameVariable.score+=20;
            txtScore.text = "Score : " + gameVariable.score;
        }
        else
        {
            if (kunciJ.Equals('A')){
                ButtonB.SetActive(false);
                ButtonC.SetActive(false);
                ButtonD.SetActive(false);
            }
            else if (kunciJ.Equals('B')){
                ButtonA.SetActive(false);
                ButtonC.SetActive(false);
                ButtonD.SetActive(false);
            }
            else if (kunciJ.Equals('C'))
            {
                ButtonB.SetActive(false);
                ButtonA.SetActive(false);
                ButtonD.SetActive(false);
            }
            else if (kunciJ.Equals('D'))
            {
                ButtonB.SetActive(false);
                ButtonC.SetActive(false);
                ButtonA.SetActive(false);
            }
            SalahObj.SetActive(true);
            BenarObj.SetActive(false);
            jwbSalah++;
            if(gameVariable.score > 0)
            {
                gameVariable.score -= 20;
            }
            else
            {
                gameVariable.score = 0;
            }
            txtScore.text = "Score : " + gameVariable.score;
        }
    }

    // Update is called once per frame
    void Update()
    {
        durasiGame -= Time.deltaTime;
        txtTime.text = "Time : " + (int)durasiGame;
        if (durasiGame <=0)
        {   
            panel.SetActive(true);
            txtHasil.text = "" + gameVariable.score;
                    
            imgPenilaian.SetActive(false);
            imgHasil.SetActive(true);

            durasiPenilaian = 0;
            durasiGame=0;
        }
        else{
            if(panel.activeSelf)
            {
                durasiPenilaian -= Time.deltaTime;
                
            
                if (isHasil)
                {
                    imgPenilaian.SetActive(true);
                    imgHasil.SetActive(false);

                    if (durasiPenilaian <= 0)
                    {
                        txtHasil.text = "" + gameVariable.score;
                        
                        imgPenilaian.SetActive(false);
                        imgHasil.SetActive(true);

                        durasiPenilaian = 0;

                    }
                } 
                else
                {
                    imgPenilaian.SetActive(true);
                    imgHasil.SetActive(false);

                    if (durasiPenilaian <= 0)
                    {
                        ButtonA.SetActive(true);
                        ButtonB.SetActive(true);
                        ButtonC.SetActive(true);
                        ButtonD.SetActive(true);
                        panel.SetActive(false);
                        durasiPenilaian = durasi;

                        TampilkanSoal();
                    }
                }
            }

        }
    }
}
