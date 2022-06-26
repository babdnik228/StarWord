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

    [SerializeField] private Text adm_vis;
    [SerializeField] private Text dip_vis;
    [SerializeField] private Text voen_vis;
    private void Update()
    {
        adm_vis.text = leader.characteristic_administraunion.ToString();
        dip_vis.text = leader.characteristic_diplomatic.ToString();
        voen_vis.text = leader.characteristic_voen.ToString();
        admin_lead.text = attributes.administrius.ToString();
        dipl_lead.text = attributes.diplomaticus.ToString();
        voen_lead.text = attributes.voenus.ToString();
        name_leader.text = leader.name_leader;
    }
}
