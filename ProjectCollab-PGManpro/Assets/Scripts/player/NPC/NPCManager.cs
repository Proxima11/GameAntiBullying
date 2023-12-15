using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NPCManager : MonoBehaviour
{
    public string dialogStatus;
    public List<string> listNpc = new List<string>(); 
    public List<Spawn> listSpawn;
    GameObject questMark;
    GameObject kevin;
    GameObject girl;
    GameObject guru;
    GameObject david;
    GameObject devi;
    GameObject alvin;
    GameObject vina;
    GameObject vero;
    GameObject claire;
    GameObject tino;
    GameObject doni;

    GameObject jessica;
    GameObject siska;
    GameObject satpam;
    GameObject instruktur;
    GameObject jaka;
    GameObject friska;
    GameObject risma;
    public bool randomEvent = false;
    void Start()
    {
        questMark = Resources.Load<GameObject>("QuestMark");
        guru = Resources.Load<GameObject>("Guru");
        kevin = Resources.Load<GameObject>("Murid Culun");
        girl = Resources.Load<GameObject>("Girl_FBX1");
        david = Resources.Load<GameObject>("David");
        devi = Resources.Load<GameObject>("Devi");
        alvin = Resources.Load<GameObject>("Alvin");
        vina = Resources.Load<GameObject>("Vina");
        vero = Resources.Load<GameObject>("Vero");
        claire = Resources.Load<GameObject>("Claire");
        tino = Resources.Load<GameObject>("Tino");
        doni = Resources.Load<GameObject>("Doni");
        siska = Resources.Load<GameObject>("Siska");
        jessica = Resources.Load<GameObject>("Jessica");
        satpam = Resources.Load<GameObject>("Satpam");
        instruktur = Resources.Load<GameObject>("Instruktur Renang");
        jaka = Resources.Load<GameObject>("Jaka");
        friska = Resources.Load<GameObject>("Bu Friska");
        risma = Resources.Load<GameObject>("Risma");

        listSpawn = FindObjectOfType<NPCSpawner>().spawns;
        // superScript.indexDialog = 10;
        // superScript.day = 3;
    }

    // Update is called once per frame
    void Update()
    {
        string[] dialog =  superScript.dialogProgress;
        int index =  superScript.indexDialog;
        // Debug.Log(dialog[index]);

        //main story
        if (dialog[index] == "Day 1 part 1" & superScript.day >= 1)
        {
            FindObjectOfType<UpdateUI>().navigation.SetText("GO TO CLASS 1");

            if (FindObjectOfType<DialogManager>().spawn)
            {
                removeNPC("QuestMark");
                FindObjectOfType<DialogManager>().spawn = false;
            }
            //dialog yang sekarang lagi play
            dialogStatus = "dialogday1_1";

            //di spawn di scene apa
            changeScene("kelas 1");
            addSpawn(questMark, new Vector3(-3.298f, 2.446f, -2.697f), new Vector3(0f, 0f, 0f), new Vector3(0.2f, 0.2f, 0.2f), "QuestMark");
            addNPC("QuestMark");
            GameObject questmark1 = GameObject.Find("QuestMark1");
            GameObject questmark2 = GameObject.Find("QuestMark2");
            if (questmark1 != null & questmark2 != null)
            {
                Renderer questmark1Renderer = questmark1.GetComponent<Renderer>();
                Renderer questmark2Renderer = questmark2.GetComponent<Renderer>();
                Color customColor = new Color(1.00f, 0.888f, 0.0400f, 1.0f);

                questmark1Renderer.material.color = customColor;
                questmark2Renderer.material.color = customColor;
                questmark1Renderer.material.SetColor("quest", customColor);
                questmark2Renderer.material.SetColor("quest", customColor);
            }

            addSpawn(guru, new Vector3(-2.43f, -0.358f, -3.14f), new Vector3(0f, 0f, 0f), new Vector3(1.5f, 1.5f, 1.5f), "Guru");
            addNPC("Guru");
            if (superScript.boy)
            {
                addSpawn(david, new Vector3(-3.89f, -0.2017f, -2.24f), new Vector3(0f, 60f, 0f), new Vector3(0.9f, 0.9f, 0.9f), "David");
                addNPC("David");
            }
            else
            {
                addSpawn(devi, new Vector3(-3.89f, -0.2017f, -2.24f), new Vector3(0f, 60f, 0f), new Vector3(1.3f, 1.3f, 1.3f), "Devi");
                addNPC("Devi");
            }

        }
        else if (dialog[index] == "Day 1 part 2" & superScript.day >= 1)
        {
            //removeNPC("QuestMark");
            if (FindObjectOfType<DialogManager>().spawn)
            {
                removeNPC("Guru");
                removeNPC("David");
                removeNPC("Devi");
                removeNPC("QuestMark");
                FindObjectOfType<DialogManager>().spawn = false;
            }
            dialogStatus = "dialogday1_2";
            changeScene("kelas 1");
            addSpawn(questMark, new Vector3(-3.298f, 2.446f, -2.697f), new Vector3(0f, 0f, 0f), new Vector3(0.2f, 0.2f, 0.2f), "QuestMark");
            addNPC("QuestMark");
            GameObject questmark1 = GameObject.Find("QuestMark1");
            GameObject questmark2 = GameObject.Find("QuestMark2");
            if (questmark1 != null & questmark2 != null)
            {
                Renderer questmark1Renderer = questmark1.GetComponent<Renderer>();
                Renderer questmark2Renderer = questmark2.GetComponent<Renderer>();
                Color customColor = new Color(1.00f, 0.888f, 0.0400f, 1.0f);

                questmark1Renderer.material.color = customColor;
                questmark2Renderer.material.color = customColor;
                questmark1Renderer.material.SetColor("quest", customColor);
                questmark2Renderer.material.SetColor("quest", customColor);
            }
            /*Color customColor = new Color(1.00f, 0.888f, 0.0400f, 1.0f);
            addSpawn(questMark, new Vector3(-3.298f, 2.446f, -2.697f), new Vector3(0f, 0f, 0f), new Vector3(0.2f, 0.2f, 0.2f), "QuestMark");
            addNPC("QuestMark");
            GameObject questmark1 = GameObject.Find("QuestMark1");
            Renderer questmark1Renderer = questmark1.GetComponent<Renderer>();
            GameObject questmark2 = GameObject.Find("QuestMark2");
            Renderer questmark2Renderer = questmark2.GetComponent<Renderer>();

            questmark1Renderer.material.color = customColor;
            questmark2Renderer.material.color = customColor; */

            if (superScript.boy)
            {
                addSpawn(alvin, new Vector3(-2.23f, 0.058f, -3.14f), new Vector3(0f, 0f, 0f), new Vector3(1.1f, 1.1f, 1.1f), "Alvin");
                addNPC("Alvin");
                addSpawn(david, new Vector3(-3.89f, -0.2017f, -2.24f), new Vector3(0f, 60f, 0f), new Vector3(0.9f, 0.9f, 0.9f), "David");
                addNPC("David");

            }
            else
            {
                addSpawn(vina, new Vector3(-2.23f, 0.058f, -3.14f), new Vector3(0f, 0f, 0f), new Vector3(1f, 1f, 1f), "Vina");
                addNPC("Vina");
                addSpawn(devi, new Vector3(-3.89f, -0.2017f, -2.24f), new Vector3(0f, 60f, 0f), new Vector3(1.3f, 1.3f, 1.3f), "Devi");
                addNPC("Devi");
            }
        }

        else if (dialog[index] == "Day 1 part 3" & superScript.day >= 1)
        {
            dialogStatus = "dialogday1_3";
            changeScene("kelas 1");

            if (superScript.boy)
            {
                if (FindObjectOfType<DialogManager>().spawn)
                {
                    removeNPC("David");
                    removeNPC("Alvin");
                    removeNPC("QuestMark");
                    FindObjectOfType<DialogManager>().spawn = false;
                }
                addSpawn(alvin, new Vector3(-2.23f, -0.158f, -3.14f), new Vector3(0f, 0f, 0f), new Vector3(1.1f, 1.1f, 1.1f), "Alvin");
                addNPC("Alvin");

            }
            else
            {
                if (FindObjectOfType<DialogManager>().spawn)
                {
                    removeNPC("Devi");
                    removeNPC("Vina");
                    removeNPC("QuestMark");
                    FindObjectOfType<DialogManager>().spawn = false;
                }

                addSpawn(vina, new Vector3(-2.23f, 0.058f, -3.14f), new Vector3(0f, 0f, 0f), new Vector3(1f, 1f, 1f), "Vina");
                addNPC("Vina");
            }
            addSpawn(questMark, new Vector3(-2.23f, 2.446f, -3.14f), new Vector3(0f, 0f, 0f), new Vector3(0.2f, 0.2f, 0.2f), "QuestMark");
            addNPC("QuestMark");
            GameObject questmark1 = GameObject.Find("QuestMark1");
            GameObject questmark2 = GameObject.Find("QuestMark2");
            if (questmark1 != null & questmark2 != null)
            {
                Renderer questmark1Renderer = questmark1.GetComponent<Renderer>();
                Renderer questmark2Renderer = questmark2.GetComponent<Renderer>();
                Color customColor = new Color(1.00f, 0.888f, 0.0400f, 1.0f);

                questmark1Renderer.material.color = customColor;
                questmark2Renderer.material.color = customColor;
                questmark1Renderer.material.SetColor("quest", customColor);
                questmark2Renderer.material.SetColor("quest", customColor);
            }

        }
        else if (dialog[index] == "Day 1 part 4" & superScript.day >= 1)
        {
            if (FindObjectOfType<DialogManager>().spawn)
            {
                removeNPC("Alvin");
                removeNPC("Vina");
                removeNPC("QuestMark");
                FindObjectOfType<DialogManager>().spawn = false;
            }
            dialogStatus = "dialogday1_4";
            changeScene("Lorong");
            if (superScript.boy)
            {
                addSpawn(alvin, new Vector3(61.887f, 0.058f, -3.524f), new Vector3(0f, 270f, 0f), new Vector3(1.1f, 1.1f, 1.1f), "Alvin");
                addNPC("Alvin");
            }
            else
            {
                addSpawn(vina, new Vector3(61.887f, 0.058f, -3.524f), new Vector3(0f, 270f, 0f), new Vector3(1f, 1f, 1f), "Vina");
                addNPC("Vina");
            }
            addSpawn(questMark, new Vector3(61.887f, 2.446f, -3.524f), new Vector3(0f, 0f, 0f), new Vector3(0.2f, 0.2f, 0.2f), "QuestMark");
            addNPC("QuestMark");
            GameObject questmark1 = GameObject.Find("QuestMark1");
            GameObject questmark2 = GameObject.Find("QuestMark2");
            if (questmark1 != null & questmark2 != null)
            {
                Renderer questmark1Renderer = questmark1.GetComponent<Renderer>();
                Renderer questmark2Renderer = questmark2.GetComponent<Renderer>();
                Color customColor = new Color(1.00f, 0.888f, 0.0400f, 1.0f);

                questmark1Renderer.material.color = customColor;
                questmark2Renderer.material.color = customColor;
                questmark1Renderer.material.SetColor("quest", customColor);
                questmark2Renderer.material.SetColor("quest", customColor);
            }
        }
        else if (dialog[index] == "Day 2 part 1 " & superScript.day < 2)
        {
            changeScene("Lorong");
            removeNPC("Alvin");
            removeNPC("Vina");
            removeNPC("QuestMark");
        }
        else if (dialog[index] == "Day 2 part 1 " & superScript.day >= 2)
        {
            if (FindObjectOfType<DialogManager>().spawn)
            {
                removeNPC("Alvin");
                removeNPC("Vina");
                removeNPC("QuestMark");
                FindObjectOfType<DialogManager>().spawn = false;
            }
            dialogStatus = "dialogday2_1";

            changeScene("Lorong");
            if (superScript.boy)
            {
                addSpawn(david, new Vector3(69.82f, 0.058f, -11.57f), new Vector3(0f, 180f, 0f), new Vector3(1f, 1f, 1f), "David");
                addNPC("David");
            }
            else
            {
                addSpawn(devi, new Vector3(69.82f, -0.258f, -11.57f), new Vector3(0f, 180f, 0f), new Vector3(1.3f, 1.3f, 1.3f), "Devi");
                addNPC("Devi");
            }

            addSpawn(questMark, new Vector3(69.827f, 2.446f, -11.57f), new Vector3(0f, 0f, 0f), new Vector3(0.2f, 0.2f, 0.2f), "QuestMark");
            addNPC("QuestMark");
            GameObject questmark1 = GameObject.Find("QuestMark1");
            GameObject questmark2 = GameObject.Find("QuestMark2");
            if (questmark1 != null & questmark2 != null)
            {
                Renderer questmark1Renderer = questmark1.GetComponent<Renderer>();
                Renderer questmark2Renderer = questmark2.GetComponent<Renderer>();
                Color customColor = new Color(1.00f, 0.888f, 0.0400f, 1.0f);

                questmark1Renderer.material.color = customColor;
                questmark2Renderer.material.color = customColor;
                questmark1Renderer.material.SetColor("quest", customColor);
                questmark2Renderer.material.SetColor("quest", customColor);
            }
        }
        else if (dialog[index] == "Day 2 part 2 " & superScript.day >= 2)
        {
            if (FindObjectOfType<DialogManager>().spawn)
            {
                removeNPC("David");
                removeNPC("Devi");
                removeNPC("QuestMark");
                FindObjectOfType<DialogManager>().spawn = false;
            }

            dialogStatus = "dialogday2_2";

            if (superScript.boy)
            {
                changeScene("Toilet Pria lt 1");
                addSpawn(david, new Vector3(46.106f, -0.08009219f, -0.072f), new Vector3(0f, 90f, 0f), new Vector3(1f, 1f, 1f), "David");
                addNPC("David");
                addSpawn(tino, new Vector3(46.646f, -0.08009219f, 0.748f), new Vector3(0f, 110f, 0f), new Vector3(1f, 1f, 1f), "Tino");
                addNPC("Tino");
                addSpawn(doni, new Vector3(46.66788f, -0.08009219f, -0.7924929f), new Vector3(0f, 60f, 0f), new Vector3(1f, 1f, 1f), "Doni");
                addNPC("Doni");

                addSpawn(questMark, new Vector3(46.106f, 2.2f, -0.072f), new Vector3(0f, 0f, 0f), new Vector3(0.2f, 0.2f, 0.2f), "QuestMark");
                addNPC("QuestMark");
                GameObject questmark1 = GameObject.Find("QuestMark1");
                GameObject questmark2 = GameObject.Find("QuestMark2");
                if (questmark1 != null & questmark2 != null)
                {
                    Renderer questmark1Renderer = questmark1.GetComponent<Renderer>();
                    Renderer questmark2Renderer = questmark2.GetComponent<Renderer>();
                    Color customColor = new Color(1.00f, 0.888f, 0.0400f, 1.0f);

                    questmark1Renderer.material.color = customColor;
                    questmark2Renderer.material.color = customColor;
                    questmark1Renderer.material.SetColor("quest", customColor);
                    questmark2Renderer.material.SetColor("quest", customColor);
                }
            }
            else
            {
                changeScene("Toilet Wanita lt 1");
                addSpawn(devi, new Vector3(37.075f, -0.40009148f, 1.222f), new Vector3(0f, 90f, 0f), new Vector3(1.3f, 1.3f, 1.3f), "Devi");
                addNPC("Devi");
                addSpawn(vero, new Vector3(37.284f, -0.40009148f, 1.918f), new Vector3(0f, 110f, 0f), new Vector3(1.3f, 1.3f, 1.3f), "Vero");
                addNPC("Vero");
                addSpawn(claire, new Vector3(37.322f, -0.217f, 0.532f), new Vector3(0f, 50f, 0f), new Vector3(1.1f, 1.1f, 1.1f), "Claire");
                addNPC("Claire");

                addSpawn(questMark, new Vector3(37.075f, 2.29f, 1.222f), new Vector3(0f, 0f, 0f), new Vector3(0.2f, 0.2f, 0.2f), "QuestMark");
                addNPC("QuestMark");
                GameObject questmark1 = GameObject.Find("QuestMark1");
                GameObject questmark2 = GameObject.Find("QuestMark2");
                if (questmark1 != null & questmark2 != null)
                {
                    Renderer questmark1Renderer = questmark1.GetComponent<Renderer>();
                    Renderer questmark2Renderer = questmark2.GetComponent<Renderer>();
                    Color customColor = new Color(1.00f, 0.888f, 0.0400f, 1.0f);

                    questmark1Renderer.material.color = customColor;
                    questmark2Renderer.material.color = customColor;
                    questmark1Renderer.material.SetColor("quest", customColor);
                    questmark2Renderer.material.SetColor("quest", customColor);
                }
            }

        }
        else if (dialog[index] == "Day 3 part 1 " & superScript.day < 3)
        {
            if (superScript.boy)
            {
                changeScene("Toilet Pria lt 1");
                removeNPC("David");
                removeNPC("Tino");
                removeNPC("Doni");
                removeNPC("QuestMark");
            }
            else
            {
                changeScene("Toilet Wanita lt 1");
                removeNPC("Devi");
                removeNPC("Vero");
                removeNPC("Claire");
                removeNPC("QuestMark");
            }

        }
        else if (dialog[index] == "Day 3 part 1 " & superScript.day >= 3)
        {
            dialogStatus = "day3_1";
            changeScene("Lorong");

            if (superScript.boy)
            {
                if (FindObjectOfType<DialogManager>().spawn)
                {
                    removeNPC("David");
                    removeNPC("Tino");
                    removeNPC("Doni");
                    removeNPC("QuestMark");
                    FindObjectOfType<DialogManager>().spawn = false;
                }
                addSpawn(david, new Vector3(61.88f, 4.119458f, -7.150001f), new Vector3(0f, 180f, 0f), new Vector3(1f, 1f, 1f), "David");
                addNPC("David");
                addSpawn(tino, new Vector3(62.35f, 4.119458f, -7.8f), new Vector3(0f, 230f, 0f), new Vector3(1f, 1f, 1f), "Tino");
                addNPC("Tino");
                addSpawn(doni, new Vector3(61.22f, 4.119458f, -7.38f), new Vector3(0f, 150f, 0f), new Vector3(1f, 1f, 1f), "Doni");
                addNPC("Doni");
            }
            else
            {
                if (FindObjectOfType<DialogManager>().spawn)
                {
                    removeNPC("Devi");
                    removeNPC("Vero");
                    removeNPC("Claire");
                    removeNPC("QuestMark");
                    FindObjectOfType<DialogManager>().spawn = false;
                }
                addSpawn(devi, new Vector3(61.88f, 3.844f, -7.150001f), new Vector3(0f, 180f, 0f), new Vector3(1.3f, 1.3f, 1.3f), "Devi");
                addNPC("Devi");
                addSpawn(vero, new Vector3(62.35f, 3.844f, -7.8f), new Vector3(0f, 230f, 0f), new Vector3(1.3f, 1.3f, 1.3f), "Vero");
                addNPC("Vero");
                addSpawn(claire, new Vector3(61.22f, 4.045f, -7.38f), new Vector3(0f, 150f, 0f), new Vector3(1.1f, 1.1f, 1.1f), "Claire");
                addNPC("Claire");
            }

            addSpawn(questMark, new Vector3(61.88f, 6.419458f, -7.150001f), new Vector3(0f, 0f, 0f), new Vector3(0.2f, 0.2f, 0.2f), "QuestMark");
            addNPC("QuestMark");
            GameObject questmark1 = GameObject.Find("QuestMark1");
            GameObject questmark2 = GameObject.Find("QuestMark2");
            if (questmark1 != null & questmark2 != null)
            {
                Renderer questmark1Renderer = questmark1.GetComponent<Renderer>();
                Renderer questmark2Renderer = questmark2.GetComponent<Renderer>();
                Color customColor = new Color(1.00f, 0.888f, 0.0400f, 1.0f);

                questmark1Renderer.material.color = customColor;
                questmark2Renderer.material.color = customColor;
                questmark1Renderer.material.SetColor("quest", customColor);
                questmark2Renderer.material.SetColor("quest", customColor);
            }
        }
        else if (dialog[index] == "Day 3 part 2 " & superScript.day >= 3)
        {
            dialogStatus = "day3_2";
            changeScene("Lorong");

            if (superScript.boy)
            {
                if (FindObjectOfType<DialogManager>().spawn)
                {
                    removeNPC("David");
                    removeNPC("Tino");
                    removeNPC("Doni");
                    removeNPC("QuestMark");
                    FindObjectOfType<DialogManager>().spawn = false;
                }
                addSpawn(david, new Vector3(55.41f, 0.058f, -5.18f), new Vector3(0f, 0f, 0f), new Vector3(1f, 1f, 1f), "David");
                addNPC("David");
                addSpawn(tino, new Vector3(54.62f, -0.08f, -5.18f), new Vector3(0f, 0f, 0f), new Vector3(1f, 1f, 1f), "Tino");
                addNPC("Tino");
                addSpawn(doni, new Vector3(56.214f, -0.08f, -5.18f), new Vector3(0f, 0f, 0f), new Vector3(1f, 1f, 1f), "Doni");
                addNPC("Doni");
            }
            else
            {
                if (FindObjectOfType<DialogManager>().spawn)
                {
                    removeNPC("Devi");
                    removeNPC("Vero");
                    removeNPC("Claire");
                    removeNPC("QuestMark");
                    FindObjectOfType<DialogManager>().spawn = false;
                }
                addSpawn(devi, new Vector3(55.41f, -0.28f, -5.18f), new Vector3(0f, 0f, 0f), new Vector3(1.3f, 1.3f, 1.3f), "Devi");
                addNPC("Devi");
                addSpawn(vero, new Vector3(54.62f, -0.28f, -5.18f), new Vector3(0f, 0f, 0f), new Vector3(1.3f, 1.3f, 1.3f), "Vero");
                addNPC("Vero");
                addSpawn(claire, new Vector3(56.214f, -0.03f, -5.18f), new Vector3(0f, 0f, 0f), new Vector3(1.1f, 1.1f, 1.1f), "Claire");
                addNPC("Claire");
            }
            addSpawn(questMark, new Vector3(55.41f, 2.446f, -5.18f), new Vector3(0f, 0f, 0f), new Vector3(0.2f, 0.2f, 0.2f), "QuestMark");
            addNPC("QuestMark");
            GameObject questmark1 = GameObject.Find("QuestMark1");
            GameObject questmark2 = GameObject.Find("QuestMark2");
            if (questmark1 != null & questmark2 != null)
            {
                Renderer questmark1Renderer = questmark1.GetComponent<Renderer>();
                Renderer questmark2Renderer = questmark2.GetComponent<Renderer>();
                Color customColor = new Color(1.00f, 0.888f, 0.0400f, 1.0f);

                questmark1Renderer.material.color = customColor;
                questmark2Renderer.material.color = customColor;
                questmark1Renderer.material.SetColor("quest", customColor);
                questmark2Renderer.material.SetColor("quest", customColor);
            }
        }
        else if (dialog[index] == "Day 3 part 3 " & superScript.day >= 3)
        {
            dialogStatus = "day3_3";
            changeScene("Outside");

            if (superScript.boy)
            {
                if (FindObjectOfType<DialogManager>().spawn)
                {
                    removeNPC("David");
                    removeNPC("Tino");
                    removeNPC("Doni");
                    removeNPC("QuestMark");
                    FindObjectOfType<DialogManager>().spawn = false;
                }
                addSpawn(alvin, new Vector3(9.67083f, -0.32f, 8.98f), new Vector3(0f, 270f, 0f), new Vector3(1.1f, 1.1f, 1.1f), "Alvin");
                addNPC("Alvin");
            }
            else
            {
                if (FindObjectOfType<DialogManager>().spawn)
                {
                    removeNPC("Devi");
                    removeNPC("Vero");
                    removeNPC("Claire");
                    removeNPC("QuestMark");
                    FindObjectOfType<DialogManager>().spawn = false;
                }
                addSpawn(vina, new Vector3(9.67083f, -0.12f, 8.98f), new Vector3(0f, 270f, 0f), new Vector3(1.1f, 1.1f, 1.1f), "Vina");
                addNPC("Vina");
            }

            addSpawn(questMark, new Vector3(9.737f, 2.346f, 8.938f), new Vector3(0f, 0f, 0f), new Vector3(0.2f, 0.2f, 0.2f), "QuestMark");
            addNPC("QuestMark");
            GameObject questmark1 = GameObject.Find("QuestMark1");
            GameObject questmark2 = GameObject.Find("QuestMark2");
            if (questmark1 != null & questmark2 != null)
            {
                Renderer questmark1Renderer = questmark1.GetComponent<Renderer>();
                Renderer questmark2Renderer = questmark2.GetComponent<Renderer>();
                Color customColor = new Color(1.00f, 0.888f, 0.0400f, 1.0f);

                questmark1Renderer.material.color = customColor;
                questmark2Renderer.material.color = customColor;
                questmark1Renderer.material.SetColor("quest", customColor);
                questmark2Renderer.material.SetColor("quest", customColor);
            }
        }
        else if (dialog[index] == "Day 4 " & superScript.day < 4)
        {
            changeScene("Outside");
            if (superScript.boy)
            {
                removeNPC("Alvin");
                removeNPC("QuestMark");

            }
            else
            {
                removeNPC("Vina");
                removeNPC("QuestMark");
            }
        }
        else if (dialog[index] == "Day 4 " & superScript.day >= 4)
        {
            dialogStatus = "dialogday4";
            changeScene("Outside");

            if (superScript.boy)
            {
                if (FindObjectOfType<DialogManager>().spawn)
                {
                    removeNPC("Alvin");
                    removeNPC("QuestMark");
                    FindObjectOfType<DialogManager>().spawn = false;
                }
                addSpawn(david, new Vector3(-86.34f, -0.426f, 93.72612f), new Vector3(0f, 0f, 0f), new Vector3(1f, 1f, 1f), "David");
                addNPC("David");
                addSpawn(tino, new Vector3(-87.13f, -0.556f, 93.93958f), new Vector3(0f, 0f, 0f), new Vector3(1f, 1f, 1f), "Tino");
                addNPC("Tino");
                addSpawn(doni, new Vector3(-85.53f, -0.556f, 93.80086f), new Vector3(0f, 0f, 0f), new Vector3(1f, 1f, 1f), "Doni");
                addNPC("Doni");
            }
            else
            {
                if (FindObjectOfType<DialogManager>().spawn)
                {
                    removeNPC("Vina");
                    removeNPC("QuestMark");
                    FindObjectOfType<DialogManager>().spawn = false;
                }
                addSpawn(devi, new Vector3(-86.34f, -0.73f, 93.72612f), new Vector3(0f, 0f, 0f), new Vector3(1.3f, 1.3f, 1.3f), "Devi");
                addNPC("Devi");
                addSpawn(vero, new Vector3(-87.13f, -0.73f, 93.93958f), new Vector3(0f, 0f, 0f), new Vector3(1.3f, 1.3f, 1.3f), "Vero");
                addNPC("Vero");
                addSpawn(claire, new Vector3(-85.53f, -0.473f, 93.80086f), new Vector3(0f, 0f, 0f), new Vector3(1.1f, 1.1f, 1.1f), "Claire");
                addNPC("Claire");
            }
            addSpawn(questMark, new Vector3(-86.34f, 2.046f, 93.72612f), new Vector3(0f, 0f, 0f), new Vector3(0.2f, 0.2f, 0.2f), "QuestMark");
            addNPC("QuestMark");
            GameObject questmark1 = GameObject.Find("QuestMark1");
            GameObject questmark2 = GameObject.Find("QuestMark2");
            if (questmark1 != null & questmark2 != null)
            {
                Renderer questmark1Renderer = questmark1.GetComponent<Renderer>();
                Renderer questmark2Renderer = questmark2.GetComponent<Renderer>();
                Color customColor = new Color(1.00f, 0.888f, 0.0400f, 1.0f);

                questmark1Renderer.material.color = customColor;
                questmark2Renderer.material.color = customColor;
                questmark1Renderer.material.SetColor("quest", customColor);
                questmark2Renderer.material.SetColor("quest", customColor);
            }
        }
        else if (dialog[index] == "Day 5 part 1 " & superScript.day < 5)
        {
            changeScene("Outside");
            if (superScript.boy)
            {
                removeNPC("David");
                removeNPC("Tino");
                removeNPC("Doni");
                removeNPC("QuestMark");
            }
            else
            {
                removeNPC("Devi");
                removeNPC("Vero");
                removeNPC("Claire");
                removeNPC("QuestMark");
            }
        }
        else if (dialog[index] == "Day 5 part 1 " & superScript.day >= 5)
        {
            if (superScript.boy)
            {
                if (FindObjectOfType<DialogManager>().spawn)
                {
                    removeNPC("David");
                    removeNPC("Tino");
                    removeNPC("Doni");
                    removeNPC("QuestMark");
                    FindObjectOfType<DialogManager>().spawn = false;
                }
            }
            else
            {
                if (FindObjectOfType<DialogManager>().spawn)
                {
                    removeNPC("Devi");
                    removeNPC("Vero");
                    removeNPC("Claire");
                    removeNPC("QuestMark");
                    FindObjectOfType<DialogManager>().spawn = false;
                }
            }
            dialogStatus = "dialogday5_1";
            changeScene("kelas 4");

            addSpawn(guru, new Vector3(-7.53f, -0.405f, -12.9f), new Vector3(0f, 90f, 0f), new Vector3(1.5f, 1.5f, 1.5f), "Guru");
            addNPC("Guru");

            addSpawn(questMark, new Vector3(-7.53f, 2.446f, -12.832f), new Vector3(0f, 0f, 0f), new Vector3(0.2f, 0.2f, 0.2f), "QuestMark");
            addNPC("QuestMark");
            GameObject questmark1 = GameObject.Find("QuestMark1");
            GameObject questmark2 = GameObject.Find("QuestMark2");
            if (questmark1 != null & questmark2 != null)
            {
                Renderer questmark1Renderer = questmark1.GetComponent<Renderer>();
                Renderer questmark2Renderer = questmark2.GetComponent<Renderer>();
                Color customColor = new Color(1.00f, 0.888f, 0.0400f, 1.0f);

                questmark1Renderer.material.color = customColor;
                questmark2Renderer.material.color = customColor;
                questmark1Renderer.material.SetColor("quest", customColor);
                questmark2Renderer.material.SetColor("quest", customColor);
            }
        }
        else if (dialog[index] == "Day 5 part 1_1 " & superScript.day >= 5)
        {
            //check choices story sebelum e
            //kalo dia pilih gak lapor langsung selesai story e
            if (superScript.choices.Contains("Tidak melaporkan kejadian kemarin ke guru")){
                superScript.indexDialog +=4;
                return;
            }

            dialogStatus = "dialogday5_1_1";
            changeScene("kelas 4");
            if (FindObjectOfType<DialogManager>().spawn)
            {
                removeNPC("Guru");
                removeNPC("QuestMark");
                FindObjectOfType<DialogManager>().spawn = false;
            }
            addSpawn(guru, new Vector3(-7.53f, -0.405f, -12.9f), new Vector3(0f, 90f, 0f), new Vector3(1.5f, 1.5f, 1.5f), "Guru");
            addNPC("Guru");

            addSpawn(questMark, new Vector3(-7.53f, 2.446f, -12.832f), new Vector3(0f, 0f, 0f), new Vector3(0.2f, 0.2f, 0.2f), "QuestMark");
            addNPC("QuestMark");
            GameObject questmark1 = GameObject.Find("QuestMark1");
            GameObject questmark2 = GameObject.Find("QuestMark2");
            if (questmark1 != null & questmark2 != null)
            {
                Renderer questmark1Renderer = questmark1.GetComponent<Renderer>();
                Renderer questmark2Renderer = questmark2.GetComponent<Renderer>();
                Color customColor = new Color(1.00f, 0.888f, 0.0400f, 1.0f);

                questmark1Renderer.material.color = customColor;
                questmark2Renderer.material.color = customColor;
                questmark1Renderer.material.SetColor("quest", customColor);
                questmark2Renderer.material.SetColor("quest", customColor);
            }
        }
        else if (dialog[index] == "Day 5 part 1_2 " & superScript.day >= 5)
        {
            if (FindObjectOfType<DialogManager>().spawn)
            {
                removeNPC("Guru");
                removeNPC("QuestMark");
                FindObjectOfType<DialogManager>().spawn = false;
            }
            dialogStatus = "dialogday5_1_2";
            changeScene("kelas 4");
            addSpawn(guru, new Vector3(-7.53f, -0.405f, -12.9f), new Vector3(0f, 90f, 0f), new Vector3(1.5f, 1.5f, 1.5f), "Guru");
            addNPC("Guru");
            if (superScript.boy)
            {
                addSpawn(david, new Vector3(-6.865f, 0.08039999f, -11.788f), new Vector3(0f, 130f, 0f), new Vector3(1f, 1f, 1f), "David");
                addNPC("David");
            }
            else
            {
                addSpawn(devi, new Vector3(-6.865f, -0.289f, -11.788f), new Vector3(0f, 130f, 0f), new Vector3(1.3f, 1.3f, 1.3f), "Devi");
                addNPC("Devi");
            }

            addSpawn(questMark, new Vector3(-7.135f, 2.446f, -12.187f), new Vector3(0f, 0f, 0f), new Vector3(0.2f, 0.2f, 0.2f), "QuestMark");
            addNPC("QuestMark");
            GameObject questmark1 = GameObject.Find("QuestMark1");
            GameObject questmark2 = GameObject.Find("QuestMark2");
            if (questmark1 != null & questmark2 != null)
            {
                Renderer questmark1Renderer = questmark1.GetComponent<Renderer>();
                Renderer questmark2Renderer = questmark2.GetComponent<Renderer>();
                Color customColor = new Color(1.00f, 0.888f, 0.0400f, 1.0f);

                questmark1Renderer.material.color = customColor;
                questmark2Renderer.material.color = customColor;
                questmark1Renderer.material.SetColor("quest", customColor);
                questmark2Renderer.material.SetColor("quest", customColor);
            }
        }
        else if (dialog[index] == "Day 5 part 1_3 " & superScript.day >= 5)
        {

            dialogStatus = "dialogday5_1_3";
            changeScene("kelas 4");

            addSpawn(guru, new Vector3(-7.53f, -0.405f, -12.9f), new Vector3(0f, 90f, 0f), new Vector3(1.5f, 1.5f, 1.5f), "Guru");
            addNPC("Guru");
            if (superScript.boy)
            {
                if (FindObjectOfType<DialogManager>().spawn)
                {
                    removeNPC("David");
                    removeNPC("Guru");
                    removeNPC("QuestMark");
                    FindObjectOfType<DialogManager>().spawn = false;
                }

                addSpawn(david, new Vector3(-7.065f, 0.08039999f, -11.788f), new Vector3(0f, 130f, 0f), new Vector3(1f, 1f, 1f), "David");
                addNPC("David");
                addSpawn(alvin, new Vector3(-6.77f, -0.289f, -13.766f), new Vector3(0f, 50f, 0f), new Vector3(1.1f, 1.1f, 1.1f), "Alvin");
                addNPC("Alvin");
            }
            else
            {
                if (FindObjectOfType<DialogManager>().spawn)
                {
                    removeNPC("Devi");
                    removeNPC("Guru");
                    removeNPC("QuestMark");
                    FindObjectOfType<DialogManager>().spawn = false;
                }

                addSpawn(devi, new Vector3(-7.065f, -0.289f, -11.788f), new Vector3(0f, 130f, 0f), new Vector3(1.3f, 1.3f, 1.3f), "Devi");
                addNPC("Devi");
                addSpawn(vina, new Vector3(-6.77f, 0.08039999f, -13.766f), new Vector3(0f, 50f, 0f), new Vector3(1f, 1f, 1f), "Vina");
                addNPC("Vina");
            }

            addSpawn(questMark, new Vector3(-7.289f, 2.446f, -12.795f), new Vector3(0f, 0f, 0f), new Vector3(0.2f, 0.2f, 0.2f), "QuestMark");
            addNPC("QuestMark");
            GameObject questmark1 = GameObject.Find("QuestMark1");
            GameObject questmark2 = GameObject.Find("QuestMark2");
            if (questmark1 != null & questmark2 != null)
            {
                Renderer questmark1Renderer = questmark1.GetComponent<Renderer>();
                Renderer questmark2Renderer = questmark2.GetComponent<Renderer>();
                Color customColor = new Color(1.00f, 0.888f, 0.0400f, 1.0f);

                questmark1Renderer.material.color = customColor;
                questmark2Renderer.material.color = customColor;
                questmark1Renderer.material.SetColor("quest", customColor);
                questmark2Renderer.material.SetColor("quest", customColor);
            }
        }
        else if (dialog[index] == "Day 5 part 1_4 " & superScript.day >= 5)
        {
            removeNPC("Guru");
            dialogStatus = "dialogday5_1_4";
            changeScene("kelas 4");

            if (superScript.boy)
            {
                if (FindObjectOfType<DialogManager>().spawn)
                {
                    removeNPC("David");
                    removeNPC("Alvin");
                    removeNPC("QuestMark");
                    FindObjectOfType<DialogManager>().spawn = false;
                }

                addSpawn(alvin, new Vector3(-6.77f, -0.289f, -13.766f), new Vector3(0f, 50f, 0f), new Vector3(1.1f, 1.1f, 1.1f), "Alvin");
                addNPC("Alvin");
            }
            else
            {
                if (FindObjectOfType<DialogManager>().spawn)
                {
                    removeNPC("Devi");
                    removeNPC("Vina");
                    removeNPC("QuestMark");
                    FindObjectOfType<DialogManager>().spawn = false;
                }

                addSpawn(vina, new Vector3(-6.77f, 0.08039999f, -13.766f), new Vector3(0f, 50f, 0f), new Vector3(1f, 1f, 1f), "Vina");
                addNPC("Vina");
            }
            addSpawn(questMark, new Vector3(-6.77f, 2.446f, -13.766f), new Vector3(0f, 0f, 0f), new Vector3(0.2f, 0.2f, 0.2f), "QuestMark");
            addNPC("QuestMark");
            GameObject questmark1 = GameObject.Find("QuestMark1");
            GameObject questmark2 = GameObject.Find("QuestMark2");
            if (questmark1 != null & questmark2 != null)
            {
                Renderer questmark1Renderer = questmark1.GetComponent<Renderer>();
                Renderer questmark2Renderer = questmark2.GetComponent<Renderer>();
                Color customColor = new Color(1.00f, 0.888f, 0.0400f, 1.0f);

                questmark1Renderer.material.color = customColor;
                questmark2Renderer.material.color = customColor;
                questmark1Renderer.material.SetColor("quest", customColor);
                questmark2Renderer.material.SetColor("quest", customColor);
            }
        }
        else if (dialog[index] == "End" & superScript.day == 5)
        {
            Debug.Log("masuk");
            changeScene("kelas 4");
            dialogStatus = "end";
            if (superScript.boy)
            {
                Debug.Log("masuk laki");


                if (FindObjectOfType<DialogManager>().spawn)
                {
                    removeNPC("Alvin");
                    removeNPC("Guru");
                    removeNPC("QuestMark");
                    FindObjectOfType<DialogManager>().spawn = false;
                }

            }
            else
            {
                Debug.Log("masuk perempuan");
                
                if (FindObjectOfType<DialogManager>().spawn)
                {
                    removeNPC("Vina");
                    removeNPC("Guru");
                    removeNPC("QuestMark");
                    FindObjectOfType<DialogManager>().spawn = false;

                }
            }
        }
        else
        {
            removeNPC("QuestMark");
        }

        //npc idle
        if(SceneManager.GetActiveScene().name == "kelas 1")
        {
            changeScene("kelas 1");
            addSpawn(siska, new Vector3(4.95f, 0.05939972f, 1.21f), new Vector3(0f, 270f, 0f), new Vector3(1f, 1f, 1f), "Siska");
            addNPC("Siska");
            addSpawn(jessica, new Vector3(-3.8f, 0.05939984f, 5.59f), new Vector3(0f, 180f, 0f), new Vector3(1f, 1f, 1f), "Jessica");
            addNPC("Jessica");
        }
        else if(SceneManager.GetActiveScene().name == "kelas 2")
        {
            changeScene("kelas 2");
        }
        else if (SceneManager.GetActiveScene().name == "kelas 3")
        {
            changeScene("kelas 3");
            addSpawn(friska, new Vector3(43.3f, -0.327f, -13.257f), new Vector3(0f, 310f, 0f), new Vector3(1.4f, 1.4f, 1.4f), "Bu Friska");
            addNPC("Bu Friska");
        }
        else if (SceneManager.GetActiveScene().name == "kelas 4")
        {
            changeScene("kelas 4");
            addSpawn(jessica, new Vector3(-4.06f, 0.08039999f, -4.94f), new Vector3(0f, 180f, 0f), new Vector3(1f, 1f, 1f), "Jessica");
            addNPC("Jessica");
        }
        else if (SceneManager.GetActiveScene().name == "Lorong")
        {
            // Debug.Log(randomEvent);
            changeScene("Lorong");
            addSpawn(kevin, new Vector3(90.98f, 0.05885804f, -14.22f), new Vector3(0f, 270f, 0f), new Vector3(1.1f, 1.1f, 1.1f), "Kevin");
            addNPC("Kevin");
            if (randomEvent == false && superScript.day == 1){
                addSpawn(kevin, new Vector3(58.445f, 0.05885804f, 4.902f), new Vector3(0f, 270f, 0f), new Vector3(1.1f, 1.1f, 1.1f), "Kevin");
                addNPC("Kevin");
                addSpawn(jessica, new Vector3(58.445f, 0.08039999f, 4.902f), new Vector3(0f, 180f, 0f), new Vector3(1f, 1f, 1f), "Jessica");
                addNPC("Jessica");
                addSpawn(siska, new Vector3(58.53472f, -0.005f, 2.831273f), new Vector3(0f, 355.488f, 0f), new Vector3(1f, 1f, 1f), "Siska");
                addNPC("Siska");
                addSpawn(vero, new Vector3(59.30309f, -0.274f, 3.964572f), new Vector3(0f, 272.132f, 0f), new Vector3(1.3f, 1.3f, 1.3f), "Vero");
                addNPC("Vero");
                //FindObjectOfType<GameVariable>().TakeStress(10);
                randomEvent = true;
                // Debug.Log(randomEvent);
            }
        }
        else if (SceneManager.GetActiveScene().name == "Toilet Pria lt 1")
        {
            changeScene("Toilet Pria lt 1");
        }
        else if (SceneManager.GetActiveScene().name == "Toilet Pria lt 2")
        {
            changeScene("Toilet Pria lt 2");
        }
        else if (SceneManager.GetActiveScene().name == "Toilet Wanita lt 1")
        {
            changeScene("Toilet Wanita lt 1");
        }
        else if (SceneManager.GetActiveScene().name == "Toilet Wanita lt 2")
        {
            changeScene("Toilet Wanita lt 2");
        }
        else if (SceneManager.GetActiveScene().name == "Outside")
        {
            changeScene("Outside");
            addSpawn(satpam, new Vector3(36.72613f, -0.456f, 117.64f), new Vector3(0f, 270f, 0f), new Vector3(1.2f, 1.2f, 1.2f), "Satpam");
            addNPC("Satpam");
            addSpawn(instruktur, new Vector3(-79.38026f, -0.657f, 74.83f), new Vector3(0f, 180f, 0f), new Vector3(1.5f, 1.5f, 1.5f), "Instruktur");
            addNPC("Instruktur");
            addSpawn(jaka, new Vector3(-29.445f, -0.309f, 55.23f), new Vector3(0f, 0f, 0f), new Vector3(1f, 1f, 1f), "Jaka");
            addNPC("Jaka");
        }
    }

    public void addNPC(string name){
        if (!listNpc.Contains(name)){
            bool added = FindObjectOfType<NPCSpawner>().SpawnNpc(name);
            if (added){
                listNpc.Add(name);
            }
        }
    }

    public void removeNPC(string name)
    {
        if (listNpc.Contains(name))
        {
            bool removed = FindObjectOfType<NPCSpawner>().removeNPC(name);
            if (removed)
            {
                listNpc.Remove(name);
            }
        }
        foreach (Spawn npcSpawn in listSpawn)
        {
            if (npcSpawn.name == name)
            {
                listSpawn.Remove(npcSpawn);
                break;
            }
        }
    }

    public void changeScene(string name){
        FindObjectOfType<NPCSpawner>().sceneName = name;
    }   

    public void addSpawn(GameObject prefab, Vector3 position, Vector3 rotation, Vector3 scale, string name){
        bool isExist = false;
        foreach(Spawn npcSpawn in listSpawn){
            if(npcSpawn.name == name){
                isExist = true;
                break;
            }
        }

        if(!isExist){
            Spawn spawn = new Spawn(prefab, position,rotation, scale, name);
            listSpawn.Add(spawn);
        }
    }
}
