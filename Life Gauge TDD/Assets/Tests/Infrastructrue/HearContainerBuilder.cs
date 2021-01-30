using System.Collections.Generic;
using static HeartContainerTests.TheReplenishMethod;

public class HeartContainerBuilder : TestDataBuilder<HeartContainer>
{
    private List<Heart> _hearts;

    public HeartContainerBuilder(List<Heart> hearts)
    {
        _hearts = hearts;
    }

    public HeartContainerBuilder() : this(new List<Heart>())
    {
    }

    public HeartContainerBuilder With(Heart heart, Heart target = null)
    {
        _hearts.Add(heart);
        if (target != null)
            _hearts.Add(target);
        return this;
    }

    public override HeartContainer Build => new HeartContainer(_hearts);
}
