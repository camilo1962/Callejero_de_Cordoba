using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class D36 : MonoBehaviour
{

    private void Start()
    {
        var dropdown = transform.GetComponent<TMP_Dropdown>();

        dropdown.options.Clear();

        List<string> items = new List<string>();
        items.Add(" ");
        items.Add("1");
        items.Add("2");
        items.Add("3");
        items.Add("4");
        items.Add("5");
        items.Add("6");
        items.Add("7");
        items.Add("8");
        items.Add("9");
        items.Add("10");
        items.Add("11");
        items.Add("12");
        items.Add("13");
        items.Add("14");
        items.Add("15");
        items.Add("16");
        items.Add("17");
        items.Add("18");
        items.Add("19");
        items.Add("20");
        items.Add("21");
        items.Add("22");
        items.Add("23");
        items.Add("24");
        items.Add("25");
        items.Add("26");
        items.Add("27");
        items.Add("28");
        items.Add("29");
        items.Add("30");
        items.Add("31");
        items.Add("32");
        items.Add("33");
        items.Add("34");
        items.Add("35");
        items.Add("36");



        foreach (var item in items)
        {
            dropdown.options.Add(new TMP_Dropdown.OptionData() { text = item });
        }
    }
}