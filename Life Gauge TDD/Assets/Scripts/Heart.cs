using System;
using UnityEngine.UI;

public class Heart
{
    public static readonly int HeartPiecesPerHeart = 4;
    private const float FillPercentHeartPiece = 0.25f;
    private readonly Image _image;

    public int FilledHeartPieces 
    {
        get { return CalculateFilledHeartPieces(); }
    }

    public int EmptyHeartPieces 
    {
        get { return HeartPiecesPerHeart - CalculateFilledHeartPieces(); }
    }
    private int CalculateFilledHeartPieces()
    {
        return (int)(_image.fillAmount * HeartPiecesPerHeart);
    }

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


