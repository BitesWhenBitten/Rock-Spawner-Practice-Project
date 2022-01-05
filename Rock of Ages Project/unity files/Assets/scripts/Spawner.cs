using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{


    //create the timer & determine delay
    Timer spawnTimer;
    const float spawnDelay = 1;


    //prefabs to choose from
    [SerializeField]
    GameObject rock1;

    [SerializeField]
    GameObject rock2;

    [SerializeField]
    GameObject rock3;
        

    // Start is called before the first frame update
    void Start()
    {
        //add in the actual guts of the timer and get it spinning
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = spawnDelay;
        spawnTimer.Run();

    }

    // Update is called once per frame
    void Update()
    {
        //get # of rocks onscreen
     int numberOnScreen =   GameObject.FindGameObjectsWithTag("Rock").Length;

        
        if (numberOnScreen < 3 )
        {
            //has it been a second since last spawn
            if ( spawnTimer.Finished)
            {
                int rockNumber = Random.Range(1, 4);

                //switch for random rock #

                switch(rockNumber)
                {
                    case 1:
                        Instantiate<GameObject>(rock1);
                        break;
                    case 2:
                        Instantiate<GameObject>(rock2);
                        break;
                    case 3:
                        Instantiate<GameObject>(rock3);
                        break;
                    default:
                        break;
                }
                
            }
        }


        



    }
}
