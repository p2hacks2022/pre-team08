using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TurnIn : MonoBehaviour
{
    public GameObject DarkPanel;
    public SceneChange_DarkTurn dt;
    // Start is called before the first frame update
    void Start()
    {
        dt = DarkPanel.GetComponent<SceneChange_DarkTurn>();
        dt.startTurn_out();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
