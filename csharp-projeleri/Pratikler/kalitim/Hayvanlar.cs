
public class Hayvanlar:Canlilar
{
    protected void Adaptasyon()
    {
        Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
    }
}
public class Sürüngenler:Hayvanlar
{
    public Sürüngenler()
    {
        base.Adaptasyon();
    }
    public void SurunerekHareketEder()
    {
        Console.WriteLine("---------Sürüngenler sürünerek hareket eder.---------");
    }
}
public class Kuslar:Hayvanlar
{
    public Kuslar()
    {
        base.Adaptasyon();
    }
    public void UcarakHareketEder()
    {
        Console.WriteLine("---------Kuşlar uçarak hareket eder.---------");
    }
}