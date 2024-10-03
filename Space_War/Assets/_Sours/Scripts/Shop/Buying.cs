using Player.Resources;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buying : MonoBehaviour
{

    [SerializeField]
    private int _liveCoust;
    [SerializeField]
    private int CannonmagCoust;
    [SerializeField]
    private int CannonReloadSpeedCoust;
    [SerializeField]
    private int ReinforsmentCoust;
    public void BuyingLive()
    {
        if (PlayerResources.Instance.ReturnScore() > _liveCoust)
        {
            PlayerResources.Instance.Bought(_liveCoust);
            _liveCoust += 900;
            PlayerResources.Instance.Live(1);
        }
    }
    public void BuyingBullets()
    {
        if (PlayerResources.Instance.ReturnScore() > CannonmagCoust)
        {
            PlayerResources.Instance.Bought(CannonmagCoust);
            CannonmagCoust += 500;
            PlayerResources.Instance.bullets(1);
        }
    }
    public void BuyingReloadTime()
    {
        if (PlayerResources.Instance.ReturnScore() > CannonReloadSpeedCoust)
        {
            PlayerResources.Instance.Bought(CannonReloadSpeedCoust);
            CannonReloadSpeedCoust += 900;
            PlayerResources.Instance.ReloadCannonTime(1);
        }
    }
    public void BuyingReinforsment()
    {
        if (PlayerResources.Instance.ReturnScore() > ReinforsmentCoust)
        {
            PlayerResources.Instance.Bought(ReinforsmentCoust);
            PlayerResources.Instance.Reinforsment(1);
        }
    }
}
