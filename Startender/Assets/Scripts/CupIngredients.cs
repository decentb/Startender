﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CupIngredients : MonoBehaviour {

    //Ingredients in cup, in order. Added by Rebeca Rey. Necessary to remember order.
    List<Ingredient> ingredientList = new List<Ingredient>();

	// Use this for initialization
	void Start ()
    {
        
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Trigger detected from: " + collision.gameObject.name);
        Bubble bubble = collision.gameObject.GetComponent<Bubble>();

        if (bubble != null && bubble.getIngredient() != null)
        {
            //Add ingredient to list organized.
            ingredientList.Add(bubble.getIngredient());
            bubble.getIngredient().transform.parent = transform;

            Destroy(collision.gameObject);
            audio.Play();
        }
    }

    public void ResetIngredients()
    {
        foreach (Ingredient child in GetComponentsInChildren<Ingredient>())
        {
            Destroy(child.gameObject);
        }
        //Reset the list.
        ingredientList.Clear();
    }

    public List<Ingredient> GetIngredients()
    {
        return ingredientList;
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
