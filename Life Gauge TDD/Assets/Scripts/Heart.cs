﻿using System;
using UnityEngine.UI;

public class Heart
{
    private const float FillPercentHeartPiece = 0.25f;
    private readonly Image _image;
    public Heart(Image image)
    {
        _image = image;
    }   

    public void Replenish(int numberOfHeartPieces)
    {
        if (numberOfHeartPieces < 0) throw new ArgumentOutOfRangeException("numberOfHeartPieces");
        _image.fillAmount += numberOfHeartPieces * FillPercentHeartPiece;
    }

    public void Deplete(int numberOfHeartPieces)
    {
        if (numberOfHeartPieces < 0) throw new ArgumentOutOfRangeException("numberOfHeartPieces");
        _image.fillAmount -= numberOfHeartPieces * FillPercentHeartPiece;
    }
}

