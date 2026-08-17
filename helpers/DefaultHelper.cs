using System;

namespace cocbrpcg;

public static class DefaultHelper
{
    public const int DefaultMoveRate = 8;
    public static readonly int[] DefaultCharacteristicValueArray = [ 40, 50, 50, 50, 60, 60, 70, 80 ];
    public static readonly int[] DefaultPersonalInterestSkillBonusArray = [ 20, 20 , 20, 20 ];

    public static int? CalculateBuild(int strength, int size)
    {
        int total = strength + size;

        int? result = total switch
        {
            (> 1) and (< 65) => -2,
            (> 64) and (< 85) => -1,
            (> 84) and (< 125) => 0,
            (> 124) and (< 165) => 1,
            (> 164) and (< 204) => 2,
            _ => null
        };

        return result;
    }

    public static string? CalculateDamageBonus(int strength, int size)
    {
        int total = strength + size;

        string? result = total switch
        {
            (> 1) and (< 65) => "-2",
            (> 64) and (< 85) => "-1",
            (> 84) and (< 125) => "auto",
            (> 124) and (< 165) => "1d4",
            (> 164) and (< 204) => "1d6",
            _ => null
        };

        return result;
    }

    public static int CalculateHitPoints(int size, int constitution)
    {
        double hp = (double)((size + constitution) / 10.0d);
        return (int)Math.Floor(hp);
    }

    public static int CalculateLuck()
    {
        int total = 0;

        int sides = 6;
        int dice = 3;

        Random r = new();
        for (int i = 0; i < dice; i++)
        {
            total += r.Next(1, sides + 1);
        }

        return total;
    }

    public static int CalculateMagicPoints(int power)
    {
        double mp = (double)((power) / 5.0d);
        return (int)Math.Floor(mp);
    }

    public static int CalculateMoveRate()
    {
        return DefaultHelper.DefaultMoveRate;
    }

    public static int CalculateSanityPoints(int power)
    {
        return power;
    }
}
