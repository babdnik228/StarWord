using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParametrsUI : MonoBehaviour
{
    [SerializeField] private ParametrsCountry parametrsCountry;
    //
    public Text prestig_UI;
    public Text loyalty_UI;
    public Text humans_UI;
    public Text fabric_UI;
    public Text teatr_UI;
    public Text scholl_UI;
    public Text specialists;
    public Text materials;
    public Text movies;
    private void Update()
    {
        specialists.text = parametrsCountry.specialists.ToString();
        materials.text = parametrsCountry.materials.ToString();
        movies.text = parametrsCountry.movies.ToString();
        prestig_UI.text = parametrsCountry.prestig.ToString();
        loyalty_UI.text = parametrsCountry.loyalty.ToString();
        humans_UI.text = parametrsCountry.humans.ToString();
        fabric_UI.text = parametrsCountry.fabric.ToString();
        teatr_UI.text = parametrsCountry.teatr.ToString();
        scholl_UI.text = parametrsCountry.scholl.ToString();
    }
}
