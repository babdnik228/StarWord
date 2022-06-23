using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderAttributesUI : MonoBehaviour
{
    [SerializeField] private Attributes attributes;
    [SerializeField] private Leader leader;
    //
    [SerializeField] private Text dipl_lead;
    [SerializeField] private Text admin_lead;
    [SerializeField] private Text voen_lead;
    [SerializeField] private Text name_leader;
    private void Update()
    {
        admin_lead.text = attributes.administrius.ToString();
        dipl_lead.text = attributes.diplomaticus.ToString();
        voen_lead.text = attributes.voenus.ToString();
        name_leader.text = leader.name_leader;
    }
}
