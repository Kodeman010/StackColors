﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackController : MonoBehaviour
{
#pragma warning disable CS0649
    [SerializeField]
    private StackView stackView;
#pragma warning restore CS0649

    private StackModel stackModel;

    private void Awake()
    {
        stackModel = new StackModel();
    }

    public void AddToStack(Pickable pickable)
    {
        stackModel.AddItem(pickable.Item);
        stackView.AddToStack(pickable);
    }

    public List<Item> GetItems()
    {
        return stackModel.Items;
    }

    //public List<Pickable> GetViewItems()
    //{
    //    return stackView.StackItems;
    //}
}
