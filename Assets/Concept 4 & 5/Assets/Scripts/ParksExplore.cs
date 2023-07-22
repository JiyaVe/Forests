using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParksExplore : MonoBehaviour
{
    [SerializeField] GameObject CamControler;
    [SerializeField] GameObject QuizPark;
    [SerializeField] GameObject ParkObject;
    [SerializeField] GameObject[] Animals;
    [SerializeField] GameObject[] AnimalsDetails;
    [SerializeField] GameObject[] Birds;
    [SerializeField] GameObject[] BirdsDetails;
    [SerializeField] GameObject[] Trees;
    [SerializeField] GameObject[] TreesDetails;
    [SerializeField] GameObject[] Plants;
    [SerializeField] GameObject[] PlantsDetails;
    [SerializeField] int AnimalCount;
    [SerializeField] int BirdCount;
    [SerializeField] int TreeCount;
    [SerializeField] int PlantCount;
    [SerializeField] AudioSource Click;

    private int currAnimal = 0;
    private int currBird = 0;
    private int currTree = 0;
    private int currPlant = 0;
    private int currSection = 0;
    private GameObject worldCanvas;

    private void OnEnable()
    {
        worldCanvas = GameObject.FindGameObjectWithTag("WorldCanvas");
    }

    public void Animal()
    {
        Click.Play();

        GameObject ui = GameObject.FindGameObjectWithTag("Model");
        if(worldCanvas.transform.childCount > 0)
        {
            GameObject uiText = worldCanvas.transform.GetChild(0).gameObject;
            if(uiText.activeSelf)
            {
                uiText.transform.SetParent(ui.transform);
                uiText.transform.SetAsFirstSibling();
                uiText.SetActive(false);
            }
        }

        currSection = 0;
        Destroy(GameObject.FindGameObjectWithTag("Model"));

        GameObject model = Instantiate(Animals[0], new Vector3(0, 0, 0), Quaternion.identity);
        model.transform.position = Animals[0].transform.position;
        model.transform.rotation = Animals[0].transform.rotation;

        currAnimal = 0;
    }

    public void Bird()
    {
        Click.Play();

        GameObject ui = GameObject.FindGameObjectWithTag("Model");
        if(worldCanvas.transform.childCount > 0)
        {
            GameObject uiText = worldCanvas.transform.GetChild(0).gameObject;
            if(uiText.activeSelf)
            {
                uiText.transform.SetParent(ui.transform);
                uiText.transform.SetAsFirstSibling();
                uiText.SetActive(false);
            }
        }

        currSection = 1;
        Destroy(GameObject.FindGameObjectWithTag("Model"));

        GameObject model = Instantiate(Birds[0], new Vector3(0, 0, 0), Quaternion.identity);
        model.transform.position = Birds[0].transform.position;
        model.transform.rotation = Birds[0].transform.rotation;
        currBird = 0;
    }

    public void Tree()
    {
        Click.Play();

        GameObject ui = GameObject.FindGameObjectWithTag("Model");
        if(worldCanvas.transform.childCount > 0)
        {
            GameObject uiText = worldCanvas.transform.GetChild(0).gameObject;
            if(uiText.activeSelf)
            {
                uiText.transform.SetParent(ui.transform);
                uiText.transform.SetAsFirstSibling();
                uiText.SetActive(false);
            }
        }

        currSection = 2;
        Destroy(GameObject.FindGameObjectWithTag("Model"));

        GameObject model = Instantiate(Trees[0], new Vector3(0, 0, 0), Quaternion.identity);
        model.transform.position = Trees[0].transform.position;
        model.transform.rotation = Trees[0].transform.rotation;

        currTree = 0;
    }

    public void Plant()
    {
        Click.Play();

        GameObject ui = GameObject.FindGameObjectWithTag("Model");
        if(worldCanvas.transform.childCount > 0)
        {
            GameObject uiText = worldCanvas.transform.GetChild(0).gameObject;
            if(uiText.activeSelf)
            {
                uiText.transform.SetParent(ui.transform);
                uiText.transform.SetAsFirstSibling();
                uiText.SetActive(false);
            }
        }

        currSection = 3;
        Destroy(GameObject.FindGameObjectWithTag("Model"));

        GameObject model = Instantiate(Plants[0], new Vector3(0, 0, 0), Quaternion.identity);
        model.transform.position = Plants[0].transform.position;
        model.transform.rotation = Plants[0].transform.rotation;

        currPlant = 0;
    }

    public void Next()
    {
        Click.Play();

        GameObject ui = GameObject.FindGameObjectWithTag("Model");
        if(worldCanvas.transform.childCount > 0)
        {
            GameObject uiText = worldCanvas.transform.GetChild(0).gameObject;
            if(uiText.activeSelf)
            {
                uiText.transform.SetParent(ui.transform);
                uiText.transform.SetAsFirstSibling();
                uiText.SetActive(false);
            }
        }

        if(currSection == 0)
        {
            if(AnimalsDetails[currAnimal].activeSelf)
                AnimalsDetails[currAnimal].SetActive(false);

            currAnimal++;
            if(currAnimal < AnimalCount)
            {
                Destroy(GameObject.FindGameObjectWithTag("Model"));
                GameObject model = Instantiate(Animals[currAnimal], new Vector3(0, 0, 0), Quaternion.identity);
                model.transform.position = Animals[currAnimal].transform.position;
                model.transform.rotation = Animals[currAnimal].transform.rotation;
            }
            else
                currAnimal--;
        }
        else if(currSection == 1)
        {
            if(BirdsDetails[currBird].activeSelf)
                BirdsDetails[currBird].SetActive(false);

            currBird++;
            if(currBird < BirdCount)
            {
                Destroy(GameObject.FindGameObjectWithTag("Model"));
                GameObject model = Instantiate(Birds[currBird], new Vector3(0, 0, 0), Quaternion.identity);
                model.transform.position = Birds[currBird].transform.position;
                model.transform.rotation = Birds[currBird].transform.rotation;
            }
            else
                currBird--;
        }
        else if(currSection == 2)
        {
            if(TreesDetails[currTree].activeSelf)
                TreesDetails[currTree].SetActive(false);

            currTree++;
            if(currTree < TreeCount)
            {
                Destroy(GameObject.FindGameObjectWithTag("Model"));
                GameObject model = Instantiate(Trees[currTree], new Vector3(0, 0, 0), Quaternion.identity);
                model.transform.position = Trees[currTree].transform.position;
                model.transform.rotation = Trees[currTree].transform.rotation;
            }
            else
                currTree--;
        }
        else if(currSection == 3)
        {
            if(PlantsDetails[currPlant].activeSelf)
                PlantsDetails[currPlant].SetActive(false);

            currPlant++;
            if(currPlant < PlantCount)
            {
                Destroy(GameObject.FindGameObjectWithTag("Model"));
                GameObject model = Instantiate(Plants[currPlant], new Vector3(0, 0, 0), Quaternion.identity);
                model.transform.position = Plants[currPlant].transform.position;
                model.transform.rotation = Plants[currPlant].transform.rotation;
            }
            else
                currPlant--;
        }
    }

    public void Prev()
    {
        Click.Play();

        GameObject ui = GameObject.FindGameObjectWithTag("Model");
        if(worldCanvas.transform.childCount > 0)
        {
            GameObject uiText = worldCanvas.transform.GetChild(0).gameObject;
            if(uiText.activeSelf)
            {
                uiText.transform.SetParent(ui.transform);
                uiText.transform.SetAsFirstSibling();
                uiText.SetActive(false);
            }
        }

        if(currSection == 0)
        {
            if(AnimalsDetails[currAnimal].activeSelf)
                AnimalsDetails[currAnimal].SetActive(false);

            currAnimal--;
            if(currAnimal >= 0)
            {
                Destroy(GameObject.FindGameObjectWithTag("Model"));
                GameObject model = Instantiate(Animals[currAnimal], new Vector3(0, 0, 0), Quaternion.identity);
                model.transform.position = Animals[currAnimal].transform.position;
                model.transform.rotation = Animals[currAnimal].transform.rotation;
            }
            else
                currAnimal++;
        }
        else if(currSection == 1)
        {
            if(BirdsDetails[currBird].activeSelf)
                BirdsDetails[currBird].SetActive(false);

            currBird--;
            if(currBird >= 0)
            {
                Destroy(GameObject.FindGameObjectWithTag("Model"));
                GameObject model = Instantiate(Birds[currBird], new Vector3(0, 0, 0), Quaternion.identity);
                model.transform.position = Birds[currBird].transform.position;
                model.transform.rotation = Birds[currBird].transform.rotation;
            }
            else
                currBird++;
        }
        else if(currSection == 2)
        {
            if(TreesDetails[currTree].activeSelf)
                TreesDetails[currTree].SetActive(false);

            currTree--;
            if(currTree >= 0)
            {
                Destroy(GameObject.FindGameObjectWithTag("Model"));
                GameObject model = Instantiate(Trees[currTree], new Vector3(0, 0, 0), Quaternion.identity);
                model.transform.position = Trees[currTree].transform.position;
                model.transform.rotation = Trees[currTree].transform.rotation;
            }
            else
                currTree++;
        }
        else if(currSection == 3)
        {
            if(PlantsDetails[currPlant].activeSelf)
                PlantsDetails[currPlant].SetActive(false);

            currPlant--;
            if(currPlant >= 0)
            {
                Destroy(GameObject.FindGameObjectWithTag("Model"));
                GameObject model = Instantiate(Trees[currPlant], new Vector3(0, 0, 0), Quaternion.identity);
                model.transform.position = Trees[currPlant].transform.position;
                model.transform.rotation = Trees[currPlant].transform.rotation;
            }
            else
                currPlant++;
        }
    }

    public void TakeQuiz()
    {
        Click.Play();

        GameObject ui = GameObject.FindGameObjectWithTag("Model");
        if(worldCanvas.transform.childCount > 0)
        {
            GameObject uiText = worldCanvas.transform.GetChild(0).gameObject;
            if(uiText.activeSelf)
            {
                uiText.transform.SetParent(ui.transform);
                uiText.transform.SetAsFirstSibling();
                uiText.SetActive(false);
            }
        }

        CamControler.SetActive(false);
        QuizPark.SetActive(true);
        ParkObject.SetActive(false);
        gameObject.SetActive(false);
        Destroy(GameObject.FindGameObjectWithTag("Model"));
        GameObject.FindGameObjectWithTag("Details").SetActive(false);
    }

    public void ShowDetails()
    {
        Click.Play();

        if(currSection == 0)
        {    
            if(AnimalsDetails[currAnimal].activeSelf)
                AnimalsDetails[currAnimal].SetActive(false);
            else
                AnimalsDetails[currAnimal].SetActive(true);
        }
        else if(currSection == 1)
        {    
            if(BirdsDetails[currBird].activeSelf)
                BirdsDetails[currBird].SetActive(false);
            else
                BirdsDetails[currBird].SetActive(true);
        }
        else if(currSection == 2)
        {    
            if(TreesDetails[currTree].activeSelf)
                TreesDetails[currTree].SetActive(false);
            else
                TreesDetails[currTree].SetActive(true);
        }
        else if(currSection == 3)
        {    
            if(PlantsDetails[currPlant].activeSelf)
                PlantsDetails[currPlant].SetActive(false);
            else
                PlantsDetails[currPlant].SetActive(true);
        }
    }

    public void Close()
    {
        Click.Play();
        
        if(currSection == 0)
            AnimalsDetails[currAnimal].SetActive(false);
        
        else if(currSection == 1)
            BirdsDetails[currBird].SetActive(false);
        
        else if(currSection == 2)
            TreesDetails[currTree].SetActive(false);
        
        else if(currSection == 3)
            PlantsDetails[currPlant].SetActive(false);
    }
}
