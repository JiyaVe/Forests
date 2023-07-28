using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExploreForests : MonoBehaviour
{
    
    // References to required GameObjects and arrays for different elements
    [SerializeField] GameObject CamControler; // Camera controller GameObject (Assign in the Inspector)
    [SerializeField] GameObject ParkObject; // Park object GameObject (Assign in the Inspector)
    [SerializeField] GameObject[] Animals; // Array of animal models (Assign in the Inspector)
    [SerializeField] GameObject[] AnimalsDetails; // Array of animal detail UI elements (Assign in the Inspector)
    [SerializeField] GameObject[] Birds; // Array of bird models (Assign in the Inspector)
    [SerializeField] GameObject[] BirdsDetails; // Array of bird detail UI elements (Assign in the Inspector)
    [SerializeField] GameObject[] Trees; // Array of tree models (Assign in the Inspector)
    [SerializeField] GameObject[] TreesDetails; // Array of tree detail UI elements (Assign in the Inspector)
    [SerializeField] AudioSource Click; // AudioSource component to play sounds

    // Variables to keep track of the current selected element in each category
    private int currAnimal = 0; // Index for the current animal model
    private int currBird = 0; // Index for the current bird model
    private int currTree = 0; // Index for the current tree model

    private GameObject worldCanvas; // Reference to the WorldCanvas GameObject

    // This method is called when the script is enabled
    private void OnEnable()
    {
        // Find the WorldCanvas GameObject using the "WorldCanvas" tag
        worldCanvas = GameObject.FindGameObjectWithTag("WorldCanvas");
    }

    // Method to handle when the "Animal" button is clicked
    public void Animal()
    {
        Click.Play(); // Play the click sound

        // Check if there is any UI element active on the canvas and hide it
        GameObject ui = GameObject.FindGameObjectWithTag("Model");
        if (worldCanvas.transform.childCount > 0)
        {
            GameObject uiText = worldCanvas.transform.GetChild(0).gameObject;
            if (uiText.activeSelf)
            {
                uiText.transform.SetParent(ui.transform);
                uiText.transform.SetAsFirstSibling();
                uiText.SetActive(false);
            }
        }

        // Destroy any existing model and instantiate the first animal model
        Destroy(GameObject.FindGameObjectWithTag("Model"));
        GameObject model = Instantiate(Animals[0], new Vector3(0, 0, 0), Quaternion.identity);
        model.transform.position = Animals[0].transform.position;
        model.transform.rotation = Animals[0].transform.rotation;

        currAnimal = 0; // Reset the current animal index to the first one
    }

    // Method to handle when the "Bird" button is clicked
    public void Bird()
    {
        Click.Play(); // Play the click sound

        // Check if there is any UI element active on the canvas and hide it
        GameObject ui = GameObject.FindGameObjectWithTag("Model");
        if (worldCanvas.transform.childCount > 0)
        {
            GameObject uiText = worldCanvas.transform.GetChild(0).gameObject;
            if (uiText.activeSelf)
            {
                uiText.transform.SetParent(ui.transform);
                uiText.transform.SetAsFirstSibling();
                uiText.SetActive(false);
            }
        }

        // Destroy any existing model and instantiate the first bird model
        Destroy(GameObject.FindGameObjectWithTag("Model"));
        GameObject model = Instantiate(Birds[0], new Vector3(0, 0, 0), Quaternion.identity);
        model.transform.position = Birds[0].transform.position;
        model.transform.rotation = Birds[0].transform.rotation;
        currBird = 0; // Reset the current bird index to the first one
    }

    // Method to handle when the "Tree" button is clicked
    public void Tree()
    {
        Click.Play(); // Play the click sound

        // Check if there is any UI element active on the canvas and hide it
        GameObject ui = GameObject.FindGameObjectWithTag("Model");
        if (worldCanvas.transform.childCount > 0)
        {
            GameObject uiText = worldCanvas.transform.GetChild(0).gameObject;
            if (uiText.activeSelf)
            {
                uiText.transform.SetParent(ui.transform);
                uiText.transform.SetAsFirstSibling();
                uiText.SetActive(false);
            }
        }

        // Destroy any existing model and instantiate the first tree model
        Destroy(GameObject.FindGameObjectWithTag("Model"));
        GameObject model = Instantiate(Trees[0], new Vector3(0, 0, 0), Quaternion.identity);
        model.transform.position = Trees[0].transform.position;
        model.transform.rotation = Trees[0].transform.rotation;

        currTree = 0; // Reset the current tree index to the first one
    }

    // Method to handle when the "Next" button is clicked
    public void Next()
    {
        Click.Play(); // Play the click sound

        // Check if there is any UI element active on the canvas and hide it
        GameObject ui = GameObject.FindGameObjectWithTag("Model");
        if (worldCanvas.transform.childCount > 0)
        {
            GameObject uiText = worldCanvas.transform.GetChild(0).gameObject;
            if (uiText.activeSelf)
            {
                uiText.transform.SetParent(ui.transform);
                uiText.transform.SetAsFirstSibling();
                uiText.SetActive(false);
            }
        }

        // Check the current section (Animal, Bird, or Tree) and handle accordingly
        if (AnimalsDetails[currAnimal].activeSelf)
            AnimalsDetails[currAnimal].SetActive(false); // Hide the current animal detail if active

        // Increment the current index and show the next model if available
        currAnimal++;
        if (currAnimal < Animals.Length)
        {
            Destroy(GameObject.FindGameObjectWithTag("Model"));
            GameObject model = Instantiate(Animals[currAnimal], new Vector3(0, 0, 0), Quaternion.identity);
            model.transform.position = Animals[currAnimal].transform.position;
            model.transform.rotation = Animals[currAnimal].transform.rotation;
        }
        else
            currAnimal--; // If there are no more models, revert the index
    }

    // Method to handle when the "Prev" button is clicked
    public void Prev()
    {
        Click.Play(); // Play the click sound

        // Check if there is any UI element active on the canvas and hide it
        GameObject ui = GameObject.FindGameObjectWithTag("Model");
        if (worldCanvas.transform.childCount > 0)
        {
            GameObject uiText = worldCanvas.transform.GetChild(0).gameObject;
            if (uiText.activeSelf)
            {
                uiText.transform.SetParent(ui.transform);
                uiText.transform.SetAsFirstSibling();
                uiText.SetActive(false);
            }
        }

        // Check the current section (Animal, Bird, or Tree) and handle accordingly
        if (AnimalsDetails[currAnimal].activeSelf)
            AnimalsDetails[currAnimal].SetActive(false); // Hide the current animal detail if active

        // Decrement the current index and show the previous model if available
        currAnimal--;
        if (currAnimal >= 0)
        {
            Destroy(GameObject.FindGameObjectWithTag("Model"));
            GameObject model = Instantiate(Animals[currAnimal], new Vector3(0, 0, 0), Quaternion.identity);
            model.transform.position = Animals[currAnimal].transform.position;
            model.transform.rotation = Animals[currAnimal].transform.rotation;
        }
        else
            currAnimal++; // If there are no previous models, revert the index
    }

    // Method to handle when the "ShowDetails" button is clicked
    public void ShowDetails()
    {
        Click.Play(); // Play the click sound

        // Check the current section (Animal, Bird, or Tree) and toggle the detail UI accordingly
        if (AnimalsDetails[currAnimal].activeSelf)
            AnimalsDetails[currAnimal].SetActive(false); // Hide the animal detail if active
        else
            AnimalsDetails[currAnimal].SetActive(true); // Show the animal detail if not active
    }

    // Method to handle when the "Close" button is clicked
    public void Close()
    {
        Click.Play(); // Play the click sound

        AnimalsDetails[currAnimal].SetActive(false); // Hide the animal detail
    }
    
}
