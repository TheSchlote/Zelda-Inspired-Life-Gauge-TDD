﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageBuilder : TestDataBuilder<Image>
{
    private float _fillAmount;

    public ImageBuilder(float fillAmount)
    {
        _fillAmount = fillAmount;
    }

    public ImageBuilder() : this(0)
    {
    }

    public ImageBuilder WithFillAmount(float fillAmount)
    {
        _fillAmount = fillAmount;
        return this;
    }

    public override Image Build
    {
        get
        {
            Image image = new GameObject().AddComponent<Image>();
            image.fillAmount = _fillAmount;
            return image;
        }
    }
}
