using BenchmarkDotNet.Attributes;
using Godot;
using Cat = BenchmarkDotNet.Attributes.BenchmarkCategoryAttribute;

#if OLD_GODOT
namespace Old;
#else
namespace New;
#endif

class MyBench : BenchmarkAttribute
{
#if OLD_GODOT
    public MyBench() { Baseline = true; }
#endif
}

public class BenchV3
{
    Vector3 vs1 = new(-100, 0.5f, 0);
    Vector3 vs2 = new(1, 2.3f, 2.3f);
    Vector3 vs3;
    float vs4;

    [MyBench, Cat("V3.Add")] public void Add() => vs3 = vs1 + vs2;
    [MyBench, Cat("V3.Sub")] public void Sub() => vs3 = vs1 - vs2;
    [MyBench, Cat("V3.Mul")] public void Mul() => vs3 = vs1 * vs2;
    [MyBench, Cat("V3.Div")] public void Div() => vs3 = vs1 / vs2;
    [MyBench, Cat("V3.Mod")] public void Mod() => vs3 = vs1 % vs2;
    [MyBench, Cat("V3.Muli")] public void Muli() => vs3 = vs1 * 3f;
    [MyBench, Cat("V3.Divi")] public void Divi() => vs3 = vs1 / 3f;
    [MyBench, Cat("V3.Modi")] public void Modi() => vs3 = vs1 % 3f;
    [MyBench, Cat("V3.Len")] public void Len() => vs4 = vs1.Length();
    [MyBench, Cat("V3.Norm")] public void Norm() => vs3 = vs1.Normalized();
    [MyBench, Cat("V3.LimitLen")] public void LimitLen() => vs3 = vs1.LimitLength(3);
    [MyBench, Cat("V3.Reflect")] public void Reflect() => vs3 = vs1.Reflect(vs2);
    [MyBench, Cat("V3.Dist")] public void Dist() => vs4 = vs1.DistanceTo(vs2);
    [MyBench, Cat("V3.DistSqrd")] public void DistSqrd() => vs4 = vs1.DistanceSquaredTo(vs2);
}

public class BenchV2
{
    Vector3 vs1 = new(-100, 0.5f, 0);
    Vector3 vs2 = new(1, 2.3f, 2.3f);
    Vector3 vs3;
    float vs4;

    [MyBench, Cat("V2.Add")] public void Add() => vs3 = vs1 + vs2;
    [MyBench, Cat("V2.Sub")] public void Sub() => vs3 = vs1 - vs2;
    [MyBench, Cat("V2.Mul")] public void Mul() => vs3 = vs1 * vs2;
    [MyBench, Cat("V2.Div")] public void Div() => vs3 = vs1 / vs2;
    [MyBench, Cat("V2.Mod")] public void Mod() => vs3 = vs1 % vs2;
    [MyBench, Cat("V2.Muli")] public void Muli() => vs3 = vs1 * 3f;
    [MyBench, Cat("V2.Divi")] public void Divi() => vs3 = vs1 / 3f;
    [MyBench, Cat("V2.Modi")] public void Modi() => vs3 = vs1 % 3f;
    [MyBench, Cat("V2.Len")] public void Len() => vs4 = vs1.Length();
    [MyBench, Cat("V2.Norm")] public void Norm() => vs3 = vs1.Normalized();
    [MyBench, Cat("V2.LimitLen")] public void LimitLen() => vs3 = vs1.LimitLength(3);
    [MyBench, Cat("V2.Reflect")] public void Reflect() => vs3 = vs1.Reflect(vs2);
    [MyBench, Cat("V2.Dist")] public void Dist() => vs4 = vs1.DistanceTo(vs2);
    [MyBench, Cat("V2.DistSqrd")] public void DistSqrd() => vs4 = vs1.DistanceSquaredTo(vs2);
}

public class BenchV4
{
    Vector4 vs1 = new(-100, 0.5f, 0, 2.4f);
    Vector4 vs2 = new(1, 2.3f, 2.3f, 50f);
    Vector4 vs3;
    float vs4;

    [MyBench, Cat("V4.Add")] public void Add() => vs3 = vs1 + vs2;
    [MyBench, Cat("V4.Sub")] public void Sub() => vs3 = vs1 - vs2;
    [MyBench, Cat("V4.Mul")] public void Mul() => vs3 = vs1 * vs2;
    [MyBench, Cat("V4.Div")] public void Div() => vs3 = vs1 / vs2;
    [MyBench, Cat("V4.Mod")] public void Mod() => vs3 = vs1 % vs2;
    [MyBench, Cat("V4.Muli")] public void Muli() => vs3 = vs1 * 3f;
    [MyBench, Cat("V4.Divi")] public void Divi() => vs3 = vs1 / 3f;
    [MyBench, Cat("V4.Modi")] public void Modi() => vs3 = vs1 % 3f;
    [MyBench, Cat("V4.Len")] public void Len() => vs4 = vs1.Length();
    [MyBench, Cat("V4.Norm")] public void Norm() => vs3 = vs1.Normalized();
    [MyBench, Cat("V4.Dist")] public void Dist() => vs4 = vs1.DistanceTo(vs2);
    [MyBench, Cat("V4.DistSqrd")] public void DistSqrd() => vs4 = vs1.DistanceSquaredTo(vs2);
}

