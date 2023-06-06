using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Animal
{
    public int health;
    public int food;
    public int sleep;
    public int hygiene;
    public int toy;


    private float decrementInterval = 1f; // Interval for stat decrements
    private float decrementTimer = 0f; // Timer for tracking stat decrements


    public Animal(int initialHealth, int initialFood, int initialSleep, int initialHygiene, int initialToy)
    {
        health = initialHealth;
        food = initialFood;
        sleep = initialSleep;
        hygiene = initialHygiene;
        toy = initialToy;
    }

    public void UpdateStats()
    {
        // Decrease stats once per second
        decrementTimer += Time.deltaTime;
        if (decrementTimer >= decrementInterval)
        {
            decrementTimer = 0f;
            DecreaseStats();
        }
    }

    private void DecreaseStats()
    {
        // Decrease food, sleep, hygiene, toy
        food--;
        sleep--;
        hygiene--;
        toy--;

        // Check if any stat reaches 0, and decrease health if true
        if (food <= 0 || sleep <= 0 || hygiene <= 0 || toy <= 0)
        {
            health--;
        }
        if (health==0)
        {
           //endgame
        }
        
    }
}

public class AnimalStats : MonoBehaviour
{
    public Animal dog;
    public Animal cat;
    public Animal parrot;
    public Animal gerbil;

    public Slider healthSlider;
    public Slider foodSlider;
    public Slider sleepSlider;
    public Slider hygieneSlider;
    public Slider toySlider;
    public TextMeshProUGUI nametxts;
    public movetokennel mk;
    public GameObject pnkl;

    
    private void Start()
    {
        // Instantiate variables for each animal
        dog = new Animal(100, 90, 80, 90, 90);
        cat = new Animal(90, 70, 70, 80, 70);
        parrot = new Animal(80, 70, 60, 70, 50);
        gerbil = new Animal(70, 80, 50, 60, 60);

        // Get references to the sliders
      
    }

    private void Update()
    {
        // Update animal stats once per frame
        dog.UpdateStats();
        cat.UpdateStats();
        parrot.UpdateStats();
        gerbil.UpdateStats();
        DisplayAnimalStats(nametxts.text) ;
        if (dog.health==0 || cat.health==0||parrot.health==0||gerbil.health==0)
        {
            pnkl.SetActive(true);
        }
       
    }

    public void DisplayAnimalStats(string animalName)
    {
        // Display the stats of the specified animal in the sliders
        Animal animal = null;
        switch (animalName)
        {
            case "Dog":
                animal = dog;
                nametxts.text = "Dog";
               

                break;
            case "Cat":
                nametxts.text = "Cat";
                animal = cat;
                
                break;
            case "Parrot":
                animal = parrot;
                nametxts.text = "Parrot";
                
                break;
            case "Gerbil":
                animal = gerbil;
                nametxts.text = "Gerbil";
                
                break;
        }
               mk.an = animal;
        if (animal != null)
        {
            healthSlider.value = animal.health;
            foodSlider.value = animal.food;
            sleepSlider.value = animal.sleep;
            hygieneSlider.value = animal.hygiene;
            toySlider.value = animal.toy;
        }
    }
}
